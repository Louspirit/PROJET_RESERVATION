using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SiteReservation
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void rechercherVolsHotels(object sender, EventArgs e)
        {
            Session["aeroport_depart"] = listVilleDepart.SelectedValue;
            Session["aeroport_arrivee"] = listVilleArrivee.SelectedValue;
            Session["duree"] = dureeSejour.SelectedValue;
            Session["date_depart_annee"] = dateDepart.SelectedDate.Year;
            Session["date_depart_mois"] = dateDepart.SelectedDate.Month;
            Session["date_depart_jour"] = dateDepart.SelectedDate.Day;
            Response.Redirect("ResultatsRecherche.aspx");
        }
    }
}