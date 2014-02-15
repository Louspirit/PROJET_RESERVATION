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

        public DataSet getHotels(string aeroport_proche)
        {
            DataSet hotels = new DataSet();

            try
            {
                SqlConnection myC = new SqlConnection();
                myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_DATA\";Integrated Security=True";
                myC.Open();

                SqlDataAdapter myCom = new SqlDataAdapter("dbo.sp_getHotels", myC);
                myCom.SelectCommand.CommandType = CommandType.StoredProcedure;
                myCom.SelectCommand.Parameters.Add("@AEROPORT_PROCHE", SqlDbType.VarChar);
                myCom.SelectCommand.Parameters["@AEROPORT_PROCHE"].Value = aeroport_proche;

                myCom.Fill(hotels, "table");

                myCom.Dispose();
                myC.Close();
            }
            catch
            {
                return hotels;
            }

            return hotels;
        }
    }
}
