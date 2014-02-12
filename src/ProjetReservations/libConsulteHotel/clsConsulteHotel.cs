using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using HotelModel;

namespace libConsulteHotel
{
    public class clsConsulteHotel: ServicedComponent
    {
        public clsConsulteHotel()
        {
        }

        [AutoComplete]
        public List<clsHotel> getHotels(string aeroport_proche)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=Environment.MachineName;Initial Catalog=PROJET_DATA;Integrated Security = true";
            myC.Open();

            SqlCommand myCom = new SqlCommand("dbo.sp_getHotel", myC);
            myCom.CommandType = CommandType.StoredProcedure;
            myCom.Parameters["@AEROPORT_ARRIVEE"].Value = aeroport_proche;

             SqlDataReader reader = myCom.ExecuteReader();
             List<clsHotel> listHotels = new List<clsHotel>();
             while (reader.Read())
             {
                 clsHotel hotel = new clsHotel();
                 hotel.ID = reader.GetInt32(0);
                 hotel.NOM = reader.GetString(1);
                 hotel.ADRESSE = reader.GetString(2);
                 hotel.AEROPORT_PROCHE = reader.GetString(3);
                 hotel.TARIF_NUIT = reader.GetInt32(4); ;
                 listHotels.Add(hotel);
             }
            myCom.Dispose();
            myC.Close();
            return listHotels;
        }
    }
}
