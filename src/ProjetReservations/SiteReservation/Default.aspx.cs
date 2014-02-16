using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using libConsulteAeroports;

namespace SiteReservation
{
    public partial class _Default : System.Web.UI.Page
    {
        clsConsulteAeroports consultAeroports;

        protected void Page_Init(object sender, EventArgs e)
        {
            consultAeroports = new clsConsulteAeroports();
            //récupération des villes de départ
            listVilleDepart.DataSource = consultAeroports.getAeroportsDepart().Tables[0];
            listVilleDepart.DataTextField = "NOM";
            listVilleDepart.DataValueField = "ID";
            listVilleDepart.DataBind();
            //récupération des villes d'arrivée
            listVilleArrivee.DataSource = consultAeroports.getAeroportsArrivee().Tables[0];
            listVilleArrivee.DataTextField = "NOM";
            listVilleArrivee.DataValueField = "ID";
            listVilleArrivee.DataBind();
        }

        protected void rechercherVolsHotels(object sender, EventArgs e)
        {
            string aeroport_depart = listVilleDepart.SelectedValue;
            string aeroport_arrivee = listVilleArrivee.SelectedValue;
            int duree = Convert.ToInt32(dureeSejour.SelectedValue);
            int date_depart_annee = dateDepart.SelectedDate.Year;
            int date_depart_mois = dateDepart.SelectedDate.Month;
            int date_depart_jour = dateDepart.SelectedDate.Day;
            //controle sur les données saisies
            if (null == aeroport_depart || null == aeroport_arrivee || null == duree)
            {
                errorMsg.Text = "Veuillez vérifier votre saisie.";
            } if (1 == date_depart_annee && 1 == date_depart_mois && 1 == date_depart_jour)
            {
                errorMsg.Text = "Veuillez sélectionner une date.";
            }
            else
            {
                errorMsg.Text = "";
                Session["aeroport_depart"] = aeroport_depart;
                Session["aeroport_arrivee"] = aeroport_arrivee;
                Session["duree"] = duree;
                Session["date_depart_annee"] = date_depart_annee;
                Session["date_depart_mois"] = date_depart_mois;
                Session["date_depart_jour"] = date_depart_jour;
                Response.Redirect("ResultatsRecherche.aspx");
            }
        }
    }
}