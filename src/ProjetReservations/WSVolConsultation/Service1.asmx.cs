using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using libConsulteVol;

namespace WSVolConsultation
{
    /// <summary>
    /// Description résumée de Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet getVols(string aeroport_depart, string aeroport_Arrivee, int annee, int mois, int jour)
        {
            return (new clsConsulteVol()).getVols(aeroport_depart, aeroport_Arrivee, annee, mois, jour);
        }
    }
}