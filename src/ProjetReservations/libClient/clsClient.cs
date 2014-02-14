using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using Model.Client;

namespace libClient
{

    public class clsLibClient
    {
        public clsLibClient()
        {
    
        }

        public clsClientModel getClient(String nom, String prenom, String adresse, String num_carte)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_RESERVATIONS\";Integrated Security=True";
            myC.Open();

            SqlDataAdapter myCom = new SqlDataAdapter("dbo.sp_getClient", myC);
            myCom.SelectCommand.CommandType = CommandType.StoredProcedure;
            myCom.SelectCommand.Parameters.Add("@NOM", SqlDbType.VarChar);
            myCom.SelectCommand.Parameters["@NOM"].Value = nom;
            myCom.SelectCommand.Parameters.Add("@PRENOM", SqlDbType.VarChar);
            myCom.SelectCommand.Parameters["@PRENOM"].Value = prenom;
            myCom.SelectCommand.Parameters.Add("@ADRESSE", SqlDbType.VarChar);
            myCom.SelectCommand.Parameters["@ADRESSE"].Value = prenom;
            myCom.SelectCommand.Parameters.Add("@NUM_CARTE", SqlDbType.VarChar);
            myCom.SelectCommand.Parameters["@NUM_CARTE"].Value = num_carte;

            DataSet DS = new DataSet();
            myCom.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            myCom.Fill(DS, "table");
            myCom.Dispose();
            myC.Close();

            if (DS.Tables[0].Rows.Count == 0)
            {
                return null;
            }
            else
            {
                clsClientModel client = new clsClientModel();
                client.ID = Convert.ToInt32(DS.Tables[0].Rows[0][0].ToString());
                client.NOM = DS.Tables[0].Rows[0][1].ToString();
                client.PRENOM = DS.Tables[0].Rows[0][2].ToString();
                client.ADRESSE = DS.Tables[0].Rows[0][3].ToString();
                client.NUM_CARTE = DS.Tables[0].Rows[0][4].ToString();

                return client;
            }
        }
    }
}
