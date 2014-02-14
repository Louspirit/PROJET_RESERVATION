using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model.Client;
using Model.Vol;
using Model.Hotel;
using System.Messaging;

namespace SiteReservation
{
    public partial class InfosClient : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            rappelVolDepart.Text = (String)Session["volDepart"];
            rappelVolArrivee.Text = (String)Session["volArrivee"];
            rappelVolDate.Text = (String)Session["volDate"];
            rappelVolMontant.Text = ((Double)Session["volTarif"]).ToString();
            rappelHotelNom.Text = (String)Session["hotelNom"];
            rappelHotelDuree.Text = ((int)Session["duree"]).ToString();
            //calcul du cout total 
            rappelHotelMontantTotal.Text = ((Double)Session["hotelTarifTotal"]).ToString();
            montantTotalReservation.Text = ((Double)Session["montantTotalReservation"]).ToString();
        }

        protected void validerCommande(object sender, EventArgs e)
        {
            string nomClient = tbNomClient.Text;
            string prenomClient = tbPrenomClient.Text;
            string adresseClient = tbAdresseClient.Text;
            string carteClient = tbNumCarteClient.Text;
            if (nomClient == "" || prenomClient == "" || adresseClient == "" || carteClient == "")
            {
                errorMsg.Text = "Veuillez remplir le formulaire";
            }
            else
            {
                errorMsg.Text = "";
                //preparation donnees pour le push MSMQ
                clsClientModel client = new clsClientModel();
                client.NOM = nomClient;
                client.PRENOM = prenomClient;
                client.ADRESSE = adresseClient;
                client.NUM_CARTE = carteClient;

                clsHotelMSMQ resaHotel = new clsHotelMSMQ();
                resaHotel.ID_HOTEL = (int)Session["hotelId"];
                resaHotel.DATE_ARRIVEE = new DateTime((int)Session["date_depart_annee"],(int)Session["date_depart_mois"],(int)Session["date_depart_jour"]);
                resaHotel.DUREE = (int)Session["duree"];
                resaHotel.MONTANT = (Double)Session["hotelTarifTotal"];
                resaHotel.CLIENT = client;

                clsVolMSMQ resaVol = new clsVolMSMQ();
                resaVol.ID_VOL = (int)Session["volId"];
                resaVol.MONTANT = (Double)Session["volTarif"];
                resaVol.CLIENT = client;

                //push MSMQ
                MessageQueue MyMQ = new MessageQueue(@".\private$\queuereservationhotel");
                MyMQ.Send(resaHotel, "Reservation hotel, client "+nomClient+" - "+prenomClient);
                MyMQ.Close();

                MessageQueue MyMQ2 = new MessageQueue(@".\private$\queuereservationvol");
                MyMQ2.Send(resaVol, "Reservation vol, client " + nomClient + " - " + prenomClient);
                MyMQ2.Close();

                //fin des push
                btnValiderCommande.Enabled = false;
                errorMsg.Text = "Votre réservation a bien été prise en compte.";
            }
        }
    }
}