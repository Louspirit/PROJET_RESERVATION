using System;
using System.Collections.Generic;
using System.Text;
using libReservationVol;
using libReservationHotel;
using System.EnterpriseServices;
using Model.Hotel;
using Model.Vol;

namespace libEnregistrerReservation
{
    public class clsEnregistrerReservation
    {
        private clsReservationVol RV;
        private clsReservationHotel RH;

        public clsEnregistrerReservation() 
        {
            RV = new clsReservationVol();
            RH = new clsReservationHotel();
        }

        public bool effectuerReservationVol(clsVolMSMQ volMsmq)
        {
            bool reservation =  RV.setReservationVol(volMsmq);
            return reservation;
        }

        public bool effectuerReservationHotel(clsHotelMSMQ hotelMsmq)
        {
            bool reservation =  RH.setReservationHotel(hotelMsmq);
            return reservation;
        }

    }
}
