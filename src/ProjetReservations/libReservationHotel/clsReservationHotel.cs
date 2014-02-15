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
    public class clsReservationHotel
    {

        private clsLibClient clientLib;

        public clsReservationHotel()
        {
            clientLib = new clsLibClient();
        }

        public bool setReservationHotel(clsHotelMSMQ hotelMsmq )
        {
            var returnParameter = new SqlParameter(); ;
            try
            {
                SqlConnection myC = new SqlConnection();
                myC.ConnectionString = "Data Source=" + Environment.MachineName + "\\SQLEXPRESS;Initial Catalog=\"PROJET_RESERVATIONS\";Integrated Security=True";
                myC.Open();

                SqlCommand myCom = new SqlCommand("dbo.sp_reserveHotel", myC);
                myCom.CommandType = CommandType.StoredProcedure;
                myCom.Parameters.Add("@ID_HOTEL", SqlDbType.Int);
                myCom.Parameters["@ID_HOTEL"].Value = hotelMsmq.ID_HOTEL;
                myCom.Parameters.Add("@DATE_ARRIVEE", SqlDbType.DateTime);
                myCom.Parameters["@DATE_ARRIVEE"].Value = hotelMsmq.DATE_ARRIVEE;
                myCom.Parameters.Add("@DUREE", SqlDbType.Int);
                myCom.Parameters["@DUREE"].Value = hotelMsmq.DUREE;
                myCom.Parameters.Add("@MONTANT", SqlDbType.Float);
                myCom.Parameters["@MONTANT"].Value = hotelMsmq.MONTANT;

                //l'objet client est fournit à la SP sous forme de datatable (= type as table coté bdd)
                DataTable table = new DataTable();
                table.Columns.Add("@NOM", typeof(string));
                table.Columns.Add("@PRENOM", typeof(string));
                table.Columns.Add("@ADRESSE", typeof(string));
                table.Columns.Add("@NUM_CARTE", typeof(string));
                table.Rows.Add(hotelMsmq.CLIENT.NOM, hotelMsmq.CLIENT.PRENOM, hotelMsmq.CLIENT.ADRESSE, hotelMsmq.CLIENT.NUM_CARTE);
                SqlParameter clientParam = myCom.Parameters.AddWithValue("@CLIENT", table);
                clientParam.SqlDbType = SqlDbType.Structured;

                //gestion return value
                returnParameter = myCom.Parameters.Add("@ReturnVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                int Res = myCom.ExecuteNonQuery();
                myCom.Dispose();
                myC.Close();
            }
            catch
            {
                return false;
            }

            //enregistrement OK ?
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
