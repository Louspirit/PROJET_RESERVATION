using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.EnterpriseServices;
using Model.Vol;
using Model.Client;
using libClient;

namespace libReservationVol
{
    public class clsReservationVol
    {

        private clsLibClient clientLib;

        public clsReservationVol()
        {
            clientLib = new clsLibClient();
        }

        public bool setReservationVol(clsVolMSMQ volMsmq)
        {
            SqlConnection myC = new SqlConnection();
            myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_RESERVATIONS\";Integrated Security=True";
            myC.Open();
            
            // Ensuite on insère la commande comportant l'id du client
            SqlCommand myCom = new SqlCommand("dbo.sp_reserveVol", myC);
            myCom.CommandType = CommandType.StoredProcedure;
            myCom.Parameters.Add("@ID_VOL", SqlDbType.Int);
            myCom.Parameters["@ID_VOL"].Value = volMsmq.ID_VOL;
            myCom.Parameters.Add("@MONTANT", SqlDbType.Float);
            myCom.Parameters["@MONTANT"].Value = volMsmq.MONTANT;

            //l'objet client est fournit à la SP sous forme de datatable (= type as table coté bdd)
            DataTable table = new DataTable();
            table.Columns.Add("@NOM", typeof(string));
            table.Columns.Add("@PRENOM", typeof(string));
            table.Columns.Add("@ADRESSE", typeof(string));
            table.Columns.Add("@NUM_CARTE", typeof(string));
            table.Rows.Add(volMsmq.CLIENT.NOM, volMsmq.CLIENT.PRENOM, volMsmq.CLIENT.ADRESSE, volMsmq.CLIENT.NUM_CARTE);
            SqlParameter clientParam = myCom.Parameters.AddWithValue("@CLIENT", table);
            clientParam.SqlDbType = SqlDbType.Structured;

            //gestion return value
            var returnParameter = myCom.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            int Res = myCom.ExecuteNonQuery();
            myCom.Dispose();
            myC.Close();
            if ((int)returnParameter.Value == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
