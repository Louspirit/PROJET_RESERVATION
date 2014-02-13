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
        public bool effectuerReservationVol(message.ID, message.MONTANT, client.NOM, client.PRENOM, client.ADRESSE, client.NUM_CARTE)
        {
            clsReservationVol MyC = new clsReservationVol();
            bool reservation =  setReservationVol();
            return return reservation;
        }

        [AutoComplete]
        public bool effectuerReservationHotel(message.ID, message.MONTANT, client.NOM, client.PRENOM, client.ADRESSE, client.NUM_CARTE)
        {
            clsReservationHotel MyC = new clsReservationHotel();
            bool reservation =  setReservationHotel();
            return return reservation;
        }

    }
}
