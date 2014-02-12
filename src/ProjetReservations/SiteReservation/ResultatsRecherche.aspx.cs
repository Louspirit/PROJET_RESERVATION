﻿using System;
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
            string duree = ((String) Session["duree"]);

            labelRequestParam.Text = "Votre recherche : Depart "+aeroport_depart+", Arrivee "+aeroport_arrivee+", Duree "+duree +", Date"+date_depart_annee.ToString()+"-"+date_depart_mois.ToString()+"-"+date_depart_jour.ToString();
            /*if (Page.PreviousPage != null)
            {
                aeroport_depart = ((DropDownList)Page.PreviousPage.FindControl("listVilleDepart")).SelectedValue;
                aeroport_arrivee = ((DropDownList)Page.PreviousPage.FindControl("listVilleArrivee")).SelectedValue;
                date_depart = ((Calendar)Page.PreviousPage.FindControl("dateDepart")).SelectedDate;
                string dureeString = ((DropDownList)Page.PreviousPage.FindControl("dureeSejour")).SelectedValue;
                try
                {
                    duree = int.Parse(dureeString);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de parsing duree Sejour");
                }
            }*/
            //récupération des vols
            DataSet vols = (new WSVolConsultation.Service1()).getVols(aeroport_depart, aeroport_arrivee, date_depart_annee, date_depart_mois, date_depart_jour);
            listVols.DataSource = vols.Tables[0];
            listVols.DataBind();
            //récupération hotels
            DataSet hotels = (new WSHotelConsultation.Service1()).getHotels(aeroport_arrivee);
            listHotels.DataSource = hotels.Tables[0];
            listHotels.DataBind();
        }

        protected void selectionVol(object sender, EventArgs e)
        {
            GridViewRow row = listVols.SelectedRow;
            selectedVol.Text = row.Cells[1].Text;
        }
    }
}