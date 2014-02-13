using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using libClient;
using Model.Vol;
using Model.Client;

namespace libReservationVol
{
    public class clsReservationVol : ServicedComponent
    {
        public clsReservationVol()
        {
        }

        [AutoComplete]
        public bool setReservationVol(int idVol, double montant, String nomClient, String prenomClient, String adresseClient, String numeroCarte)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_RESERVATIONS\";Integrated Security=True";
            myC.Open();
            // Vérification que le client n'existe pas déjà 
            clsLibClient myClient = new clsLibClient();
            clsClient client = myClient.getClient(nomClient, prenomClient, adresseClient);
            //Si non, on le crée dans la table client
            if (client.ID == 0)
            {
                myClient.addClient(nomClient, prenomClient, adresseClient, numeroCarte);
                //On récupère l'id
                client = myClient.getClient(nomClient, prenomClient, adresseClient);
            }

            // Ensuite on insère la commande comportant l'id du client
            SqlCommand myCom = new SqlCommand("dbo.sp_addCmdVol", myC);
            myCom.CommandType = CommandType.StoredProcedure;
            myCom.Parameters.Add("@ID_VOL", SqlDbType.Int);
            myCom.Parameters["@ID_VOL"].Value = idVol;
            myCom.Parameters.Add("@MONTANT", SqlDbType.Float);
            myCom.Parameters["@MONTANT"].Value = montant;

            myCom.ExecuteNonQuery();
            myCom.Dispose();
            myC.Close();
            return true;
        }
    }
}
