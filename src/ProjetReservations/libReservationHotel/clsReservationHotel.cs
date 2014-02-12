using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using HotelModel;

namespace libReservationHotel
{
    public class clsReservationHotel : ServicedComponent
    {        
        public clsReservationHotel()
        {
        }

     [AutoComplete]
        public void setReservationHotel(int idHotel, int idClient, String ,)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=Environment.MachineName;Initial Catalog=PROJET_RESERVATION;Integrated Security = true";
            myC.Open();

            SqlCommand myCom = new SqlCommand("dbo.sp_setHotel", myC);
            myCom.CommandType = CommandType.StoredProcedure;

             SqlDataReader reader = myCom.ExecuteReader();
             List<clsHotel> listHotels = new List<clsHotel>();
             while (reader.Read())
             {
                 clsHotel hotel = new clsHotel();
                 hotel.ID = reader.GetInt32(0);
                 hotel.NOM = reader.GetString(1);
                 hotel.ADRESSE = reader.GetString(2);
                 hotel.AEROPORT_PROCHE = reader.GetString(3);
                 hotel.TARIF_NUIT = reader.GetInt32(4);
                 listHotels.Add(hotel);
             }
            myCom.Dispose();
            myC.Close();
        }
    }
}
