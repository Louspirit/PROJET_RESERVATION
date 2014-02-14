using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Client
{
    public class clsClientModel
    {
        public int? ID { get; set; }
        public String NOM { get; set; }
        public String PRENOM { get; set; }
        public String ADRESSE { get; set; }
        public String NUM_CARTE { get; set; }

        public clsClientModel() { }
    }
}
