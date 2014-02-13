using System;
using System.Collections.Generic;
using System.Text;
using libReservationVol;
using libReservationHotel;
using System.EnterpriseServices;
namespace libValiderCommande
{
    public class clsValiderCommande : ServicedComponent
    {
        public clsValiderCommande() { }

        [AutoComplete]
        public bool effectuerReservationVol(int idVol, double montant, String nomClient, String prenomClient, String adresseClient, String numeroCarte)
        {
            clsReservationVol myC = new clsReservationVol();
            bool reservation =  myC.setReservationVol(idVol, montant, nomClient, prenomClient, adresseClient, numeroCarte);
            return reservation;
        }

        [AutoComplete]
        public bool effectuerReservationHotel(int idHotel, DateTime dateArrivee, int duree, double montant, String nomClient, String prenomClient, String adresseClient, String numeroCarte)
        {
            clsReservationHotel myC = new clsReservationHotel();
            bool reservation =  myC.setReservationHotel(idHotel, dateArrivee, duree , montant, nomClient, prenomClient, adresseClient, numeroCarte);
            return reservation;
        }

    }
}
