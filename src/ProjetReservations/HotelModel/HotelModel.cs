using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Hotel
{
    public class clsHotel
    {
        public int ID { get; set; }
        public String NOM { get; set; }
        public String ADRESSE { get; set; }
        public String AEROPORT_PROCHE { get; set; }
        public double TARIF_NUIT { get; set; }

        public clsHotel() { }
    }

    public class clsHotelEnregistrement
    {
        public int ID { get; set; }
        public int ID_CLIENT { get; set; }
        public String ID_HOTEL { get; set; }
        public DateTime DATE_ARRIVEE { get; set; }
        public int DUREE { get; set; }
        public double MONTANT { get; set; }

        public clsHotelEnregistrement() { }
    }
}
