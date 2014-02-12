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

         [AutoComplete]
        public clsClient getClient(String nom, String prenom, String adresse)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=Environment.MachineName;Initial Catalog=PROJET_RESERVATION;Integrated Security = true";
            myC.Open();

            SqlCommand myCom = new SqlCommand("dbo.sp_getClient", myC);
            myCom.CommandType = CommandType.StoredProcedure;
            myCom.Parameters.Add("@NOM", SqlDbType.VarChar);
            myCom.Parameters["@NOM"].Value = nom;
            myCom.Parameters.Add("@PRENOM", SqlDbType.VarChar);
            myCom.Parameters["@PRENOM"].Value = prenom;
            myCom.Parameters.Add("@ADRESSE", SqlDbType.VarChar);
            myCom.Parameters["@ADRESSE"].Value = prenom;

             SqlDataReader reader = myCom.ExecuteReader();
             clsClient client = new clsClient();
             while (reader.Read())
             {
                 client.ID = reader.GetInt32(0);
                 client.NOM = reader.GetString(1);
                 client.PRENOM = reader.GetString(2);
                 client.ADRESSE = reader.GetString(3);
                 client.NUM_CARTE = reader.GetString(4);
             }
            myCom.Dispose();
            myC.Close();
            return client;
        }

        [AutoComplete]
        public void setClient(string nom, String prenom,String adresse, int numeroCarte)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=Environment.MachineName;Initial Catalog=PROJET_RESERVATION;Integrated Security = true";
            myC.Open();

            SqlCommand myCom = new SqlCommand("dbo.sp_addClient", myC);
            myCom.CommandType = CommandType.StoredProcedure;
            myCom.Parameters.Add("@NOM", SqlDbType.VarChar);
            myCom.Parameters["@NOM"].Value = nom;
            myCom.Parameters.Add("@PRENOM", SqlDbType.VarChar);
            myCom.Parameters["@PRENOM"].Value = prenom;
            myCom.Parameters.Add("@ADRESSE", SqlDbType.VarChar);
            myCom.Parameters["@ADRESSE"].Value = adresse;
            myCom.Parameters.Add("@NUM_CARTE", SqlDbType.VarChar);
            myCom.Parameters["@NUM_CARTE"].Value = numeroCarte;   

            myCom.ExecuteNonQuery();
            myCom.Dispose();
            myC.Close();
        }
    }
}
