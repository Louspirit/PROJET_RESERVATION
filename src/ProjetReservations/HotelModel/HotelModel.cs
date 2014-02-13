using System;
using System.Collections.Generic;
using System.Text;
using Model.Client;

namespace Model.Hotel
{
    public class clsHotelMSMQ
    {
        public int? ID { get; set; } //vaudra probablement null lors de la lecture dans MSMQ
        public int ID_HOTEL { get; set; }
        public DateTime DATE_ARRIVEE { get; set; }
        public int DUREE { get; set; }
        public double MONTANT { get; set; }
        public clsClient CLIENT { get; set; }

        public clsHotelMSMQ() { }
    }

    public class clsHotelEnregistrement
    {
        public int? ID { get; set; }
        public int ID_CLIENT { get; set; }
        public String ID_HOTEL { get; set; }
        public DateTime DATE_ARRIVEE { get; set; }
        public int DUREE { get; set; }
        public double MONTANT { get; set; }

        public clsHotelEnregistrement() { }
    }
}
