using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WSVolConsultation;
using WSHotelConsultation;
using System.Data;

namespace SiteReservation
{
    public partial class _ResultatsRecherche : System.Web.UI.Page
    {
        public _ResultatsRecherche()
        {
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            //récupération des données de session
            string aeroport_depart = (String) Session["aeroport_depart"];
            string aeroport_arrivee = (String)Session["aeroport_arrivee"];
            int date_depart_annee = (int)Session["date_depart_annee"];
            int date_depart_mois = (int)Session["date_depart_mois"];
            int date_depart_jour = (int)Session["date_depart_jour"];
            int duree = (int)Session["duree"];

            labelRequestParam.Text = "Depart "+aeroport_depart+", Arrivee "+aeroport_arrivee+", Duree "+duree +" jours, Date "+date_depart_annee.ToString()+"-"+date_depart_mois.ToString()+"-"+date_depart_jour.ToString();
    
            //récupération des vols
            DataSet vols = (new WSVolConsultation.Service1()).getVols(aeroport_depart, aeroport_arrivee, date_depart_annee, date_depart_mois, date_depart_jour);
            if (vols.Tables.Count == 0 || vols.Tables[0].Rows.Count == 0)
            {
                labelNoVols.Text = "Aucun vol n'a été trouvé pour votre recherche.";
                buttonValiderCommande.Visible = false;
            }
            else
            {
                vols.Tables[0].Columns[0].ColumnName = "Numero de vol";
                vols.Tables[0].Columns[1].ColumnName = "Aeroport depart";
                vols.Tables[0].Columns[2].ColumnName = "Aeroport arrivee";
                vols.Tables[0].Columns[3].ColumnName = "Date vol";
                vols.Tables[0].Columns[4].ColumnName = "Tarif billet";
                listVols.DataSource = vols.Tables[0];
                listVols.DataBind();
            }

            //récupération hotels
            DataSet hotels = (new WSHotelConsultation.Service1()).getHotels(aeroport_arrivee);
            if (hotels.Tables.Count == 0 || hotels.Tables[0].Rows.Count == 0)
            {
                labelNoHotels.Text = "Aucun hotel n'a été trouvé pour votre recherche.";
                buttonValiderCommande.Visible = false;
            }
            else
            {
                hotels.Tables[0].Columns[0].ColumnName = "Identifiant hotel";
                hotels.Tables[0].Columns[1].ColumnName = "Nom de l'hotel";
                hotels.Tables[0].Columns[2].ColumnName = "Adresse";
                hotels.Tables[0].Columns[4].ColumnName = "Tarif / nuit";
                hotels.Tables[0].Columns.RemoveAt(3);
                listHotels.DataSource = hotels.Tables[0];
                listHotels.DataBind();
            }
        }

        protected void selectionVol(object sender, EventArgs e)
        {
            GridViewRow row = listVols.SelectedRow;
            selectedVol.Text = row.Cells[1].Text;
            selectedVolDepart.Text = row.Cells[2].Text;
            selectedVolArrivee.Text = row.Cells[3].Text;
            selectedVolDate.Text = row.Cells[4].Text;
            selectedVolTarif.Text = row.Cells[5].Text;
            for (int i = 0; i < listVols.Rows.Count; i++ )
            {
                listVols.Rows[i].CssClass = "";
            }
            row.CssClass = "selected_table_row";
        }

        protected void selectionHotel(object sender, EventArgs e)
        {
            GridViewRow row = listHotels.SelectedRow;
            selectedHotel.Text = row.Cells[1].Text;
            selectedHotelNom.Text = row.Cells[2].Text;
            selectedHotelAdresse.Text = row.Cells[3].Text;
            selectedHotelTarifNuit.Text = row.Cells[4].Text;
            for (int i = 0; i < listHotels.Rows.Count; i++)
            {
                listHotels.Rows[i].CssClass = "";
            }
            row.CssClass = "selected_table_row";
        }

        protected void validerSelection(object sender, EventArgs e)
        {
            if (selectedHotel.Text == "" || selectedVol.Text == "")
            {
                //vol ou hotel non sélectionné
                errorMsg.Text = "Vous devez sélectionner un vol et un hotel pour votre séjour.";
            }
            else
            {
                errorMsg.Text = "";
                //tout est ok, enregistrement en session des donnees
                Session["volId"] = Convert.ToInt32(selectedVol.Text);
                Session["volDepart"] = selectedVolDepart.Text;
                Session["volArrivee"] = selectedVolArrivee.Text;
                Session["volDate"] = selectedVolDate.Text;
                double tarifVol = Convert.ToDouble(selectedVolTarif.Text);
                Session["volTarif"] = tarifVol;
                Session["hotelID"] = Convert.ToInt32(selectedHotel.Text);
                Session["hotelNom"] = selectedHotelNom.Text;
                Session["hotelAdresse"] = selectedHotelAdresse.Text;
                int duree = (int)Session["duree"];
                double tarifNuit = Convert.ToDouble(selectedHotelTarifNuit.Text);
                double tarifTotalHotel = duree * tarifNuit;
                Session["hotelTarifTotal"] = tarifTotalHotel;
                Session["montantTotalReservation"] = tarifVol + tarifTotalHotel;
                Response.Redirect("InfosClient.aspx");
            }
        }

        protected void btnRetour_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}