using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Web.Services;
using libConsulteHotel;

namespace WSHotelConsultation
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
        public DataSet getHotels(string aeroport_Arrivee)
        {
            return (new clsConsulteHotel()).getHotels(aeroport_Arrivee);
        }
    }
}