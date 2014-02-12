using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using Model.Vol;

namespace libConsulteVol
{
    public class clsConsulteVol
    {
        public clsConsulteVol() { }

        [AutoComplete]
        public DataSet getVols(string aeroport_depart, string aeroport_arrivee, DateTime date_depart, int annee, int mois, int jour)
        {
            //appel de sp_getVols avec les paramètres
            return null;
        }
    }
}
