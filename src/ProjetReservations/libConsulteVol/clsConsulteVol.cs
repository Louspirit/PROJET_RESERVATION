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
        public clsConsulteVol()
        {
        }

        public DataSet getVols(string aeroport_depart, string aeroport_arrivee, int annee, int mois, int jour)
        {
            //appel de sp_getVols avec les paramètres
            SqlConnection MyC = new SqlConnection();
            MyC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_DATA\";Integrated Security=True";
            MyC.Open();
            SqlDataAdapter MyCom = new SqlDataAdapter("dbo.sp_getVols", MyC);
            MyCom.SelectCommand.CommandType = CommandType.StoredProcedure;
            MyCom.SelectCommand.Parameters.Add("@AEROPORT_DEPART", SqlDbType.VarChar);
            MyCom.SelectCommand.Parameters["@AEROPORT_DEPART"].Value = aeroport_depart;

            MyCom.SelectCommand.Parameters.Add("@AEROPORT_ARRIVEE", SqlDbType.VarChar);
            MyCom.SelectCommand.Parameters["@AEROPORT_ARRIVEE"].Value = aeroport_arrivee;

            MyCom.SelectCommand.Parameters.Add("@DATE_DEPART_MIN", SqlDbType.DateTime);
            MyCom.SelectCommand.Parameters["@DATE_DEPART_MIN"].Value = new DateTime(annee, mois, jour, 0, 0, 0);

            MyCom.SelectCommand.Parameters.Add("@DATE_DEPART_MAX", SqlDbType.DateTime);
            MyCom.SelectCommand.Parameters["@DATE_DEPART_MAX"].Value = new DateTime(annee, mois, jour, 23, 59, 59);

            DataSet DS = new DataSet();
            MyCom.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            MyCom.Fill(DS, "table");
            MyCom.Dispose();
            MyC.Close();
            return DS;

        
        }
    }
}
