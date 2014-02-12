using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Vol
{
    public class clsVol
    {
        public int ID { get; set; }
        public String AEROPORT_DEPART { get; set; }
        public String AEROPORT_ARRIVEE { get; set; }
        public DateTime DATE_DEPART { get; set; }
        public double TARIF { get; set; }

        public clsVol() { }
    }

    public class clsVolEnregistrement
    {
        public int ID { get; set; }
        public int ID_CLIENT { get; set; }
        public String ID_VOL { get; set; }
        public double MONTANT { get; set; }

        public clsVolEnregistrement() { }
    }
}
