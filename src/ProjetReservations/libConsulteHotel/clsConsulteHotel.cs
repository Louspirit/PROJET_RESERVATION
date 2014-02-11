using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace libConsulteHotel
{
    public class clsConsulteHotel : ServicedComponent
    {
        public clsConsulteHotel()
        {
        }
        [AutoComplete]
        public int clsConsulteHotel  ()
        {
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=Environment.MachineName;Initial Catalog=PROJET_DATA;Integrated Security = true";
            MyC.Open();
            SqlCommand MyCom = new SqlCommand("sp_getHotel", MyC);
            MyCom.CommandType = CommandType.StoredProcedure;
            //int Res = Convert.ToInt32 (MyCom.ExecuteScalar());
            MyCom.Dispose();
            MyC.Close();
            return Res;
        }

    }
}
