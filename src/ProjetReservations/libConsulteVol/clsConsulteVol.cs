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

            /*SqlDataReader reader = MyCom.ExecuteReader();//MyCom.ExecuteScalar(); 
            List<clsVol> list = new List<clsVol>();
            while (reader.Read())
            {
                clsVol vol = new clsVol();
                vol.ID = reader.GetInt32(0);
                Console.WriteLine("id : " + vol.ID);
                vol.AEROPORT_DEPART = reader.GetString(1);
                Console.WriteLine("aero depart : " + vol.AEROPORT_DEPART);
                vol.AEROPORT_ARRIVEE = reader.GetString(2);
                Console.WriteLine("aero_arrivee : " + vol.AEROPORT_ARRIVEE);
                vol.DATE_DEPART = reader.GetDateTime(3);
                Console.WriteLine("date : " + vol.DATE_DEPART);
                vol.TARIF = reader.GetDouble(4);
                Console.WriteLine("tarif : " + vol.TARIF);
                list.Add(vol);
            }
            reader.Close();*/
            DataSet DS = new DataSet();
            MyCom.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            MyCom.Fill(DS, "table");
            MyCom.Dispose();
            MyC.Close();
            return DS;
        }
    }
}
