using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using libClient;
using Model.Hotel;
using Model.Client;

namespace libReservationHotel
{
    public class clsReservationHotel : ServicedComponent
    {        
        public clsReservationHotel()
        {
        }

     [AutoComplete]
        public void setReservationHotel(int idHotel,DateTime dateArrivee,int duree , int montant, String nomClient, String prenomClient, String adresseClient, String numeroCarte )
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source="+Environment.MachineName+";Initial Catalog=PROJET_RESERVATIONS;Integrated Security = true";
            myC.Open();
            // Vérification que le client n'existe pas déjà 
            clsLibClient myClient = new clsLibClient();
            clsClient client =  myClient.getClient(nomClient,prenomClient,adresseClient);
            //Si non, on le crée dans la table client
            if(client.ID == 0){
                myClient.addClient(nomClient,prenomClient,adresseClient, numeroCarte);
               //On récupère l'id
                client =  myClient.getClient(nomClient,prenomClient,adresseClient);
            }
            
            // Ensuite on insère la commande comportant l'id du client
            SqlCommand myCom = new SqlCommand("dbo.sp_addCmdHotel", myC);
            myCom.CommandType = CommandType.StoredProcedure;
            myCom.Parameters.Add("@ID_HOTEL", SqlDbType.Int);
            myCom.Parameters["@ID_HOTEL"].Value = idHotel;
            myCom.Parameters.Add("@ID_CLIENT", SqlDbType.Int);
            myCom.Parameters["@ID_CLIENT"].Value = client.ID;
            myCom.Parameters.Add("@DATE_ARRIVEE", SqlDbType.DateTime);
            myCom.Parameters["@DATE_ARRIVEE"].Value = dateArrivee;
            myCom.Parameters.Add("@DUREE", SqlDbType.Int);
            myCom.Parameters["@DUREE"].Value = duree;
            myCom.Parameters.Add("@MONTANT", SqlDbType.Float);
            myCom.Parameters["@MONTANT"].Value = montant;   

            myCom.ExecuteNonQuery();
            myCom.Dispose();
            myC.Close();
        }
    }
}
