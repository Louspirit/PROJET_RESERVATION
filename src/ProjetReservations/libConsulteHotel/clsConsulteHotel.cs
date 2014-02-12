using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace libConsulteHotel
{
    public class clsConsulteHotel
    {
        public clsConsulteHotel()
        {
        }

        [AutoComplete]
        public int getHotels(string aeroport_proche)
        {
            SqlDataReader reader;
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=Environment.MachineName;Initial Catalog=PROJET_DATA;Integrated Security = true";
            MyC.Open();

            SqlCommand MyCom = new SqlCommand("dbo.sp_getHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;

            reader = MyCom.ExecuteReader();
            

            MyCom.Dispose();
            MyC.Close();
            return 0;
        }

    }
}
