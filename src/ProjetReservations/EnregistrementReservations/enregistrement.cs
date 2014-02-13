using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Messaging;
using System.EnterpriseServices;
using Model.Vol;
using Model.Hotel;
using libReservationVol;
using libReservationHotel;
using libValiderCommande;
using Model.Client;

namespace EnregistrementReservations
{
    public partial class enregistrement : Form
    {
        public enregistrement()
        {
            InitializeComponent();
        }

        private void btn_reservVol_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\queuereservationvol");
            //récupération sans vider la file d'un message, de type clsVolEnregistrement
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsVolMSMQ) });

<<<<<<< HEAD
            clsVolMSMQ message = (clsVolMSMQ)MyMQ.Peek().Body;
            clsVolMSMQ client = message.CLIENT;
=======
            var message = (clsVolMSMQ)MyMQ.Peek().Body;
            clsClient client = message.CLIENT;
            clsValiderCommande myC = new clsValiderCommande();
>>>>>>> c132cfc9201f893a652e0ba98e4f2eb28f91e82e

            //Enregistrement de la réservation de vol ( dans libValiderCommande)
            bool ResT = myC.effectuerReservationVol(message.ID_VOL, message.MONTANT, client.NOM, client.PRENOM, client.ADRESSE, client.NUM_CARTE);

            //Transaction OK
            if (ResT == true)
            {

                txtReservVol.AppendText("La réservation du vol " + message.ID + " de " + client.PRENOM + "  " + client.NOM + " s'est déroulée avec succès.");
                //Zone critique : le Receive devrait être sous forme de composant lui aussi dans le serveu d'application
                MyMQ.Receive();
            }
            //Transaction KO
            else
            {
                txtReservVol.AppendText("La réservation du vol " + message.ID_VOL + " de " + client.PRENOM + "  " + client.NOM + " n'a pas pu aboutir.");
            }
            MyMQ.Close();
        }

        private void btn_reservHotel_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\emnbank2014");
            //récupération sans vider la file d'un message, de type clsVolEnregistrement
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsHotelMSMQ) });

            var message = (clsHotelMSMQ)MyMQ.Peek().Body;
            clsClient client = message.CLIENT;
            clsValiderCommande myC = new clsValiderCommande();

            //Enregistrement de la réservation de vol ( dans libValiderCommande)
            bool ResT = myC.effectuerReservationVol(message.ID_HOTEL, message.MONTANT, client.NOM, client.PRENOM, client.ADRESSE, client.NUM_CARTE);

            //Transaction OK
            if (ResT == true)
            {

                txtReservHotel.AppendText("La réservation de l'hôtel " + message.ID_HOTEL + " de " + client.PRENOM + "  " + client.NOM + " s'est déroulée avec succès.");
                //Zone critique : le Receive devrait être sous forme de composant lui aussi dans le serveu d'application
                MyMQ.Receive();
            }
            //Transaction KO
            else
            {
                txtReservHotel.AppendText("La réservation de l'hôtel " + message.ID + " de " + client.PRENOM + "  " + client.NOM + " n'a pas pu aboutir.");
            }
            MyMQ.Close();
        }

        private void btn_reservHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
