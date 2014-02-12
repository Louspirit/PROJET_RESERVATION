using System;
using System.Collections.Generic;
using System.Text;
using Model.Client;

namespace Model.Vol
{
    public class clsVolMSMQ
    {
        public int ID { get; set; }
        public int ID_VOL { get; set; }
        public double MONTANT { get; set; }
        public clsClient CLIENT { get; set; }

        public clsVolMSMQ() { }
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
