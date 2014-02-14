using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;

namespace libConsulteAeroports
{
    public class clsConsulteAeroports
    {

        public clsConsulteAeroports(){

        }

        public DataSet getAeroportsArrivee()
        {
            //appel de sp_getAeroportsArrivee avec les paramètres
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_DATA\";Integrated Security=True";
            myC.Open();
            SqlDataAdapter myCom = new SqlDataAdapter("dbo.sp_getAeroportsArrivee", myC);
            myCom.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet DS = new DataSet();
            myCom.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            myCom.Fill(DS, "table");
            myCom.Dispose();
            myC.Close();
            return DS;
        }


        public DataSet getAeroportsDepart()
        {
            //appel de sp_getAeroportsDepart avec les paramètres
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_DATA\";Integrated Security=True";
            myC.Open();
            SqlDataAdapter myCom = new SqlDataAdapter("dbo.sp_getAeroportsDepart", myC);
            myCom.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet DS = new DataSet();
            myCom.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            myCom.Fill(DS, "table");
            myCom.Dispose();
            myC.Close();
            return DS;
        }
    }

}
