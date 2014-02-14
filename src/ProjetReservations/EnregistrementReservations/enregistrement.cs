using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Messaging;
using System.EnterpriseServices;
using Model.Vol;
using Model.Hotel;
using libEnregistrerReservation;

namespace EnregistrementReservations
{
    public partial class enregistrement : Form
    {
        private clsEnregistrerReservation EnregistrerReservation;
        
        public enregistrement()
        {
            InitializeComponent();
            EnregistrerReservation = new clsEnregistrerReservation();
        }

        private void btn_reservVol_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\queuereservationvol");
            //récupération sans vider la file d'un message, de type clsVolMSMQ
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsVolMSMQ) });

            clsVolMSMQ message = (clsVolMSMQ)MyMQ.Peek().Body;

            //Enregistrement de la réservation de vol ( dans libValiderCommande)
            bool ResT = EnregistrerReservation.effectuerReservationVol(message);

            //Transaction OK
            if (ResT == true)
            {

                textBoxResaVol.AppendText("SUCCES : Réservation du vol " + message.ID_VOL + " pour " + message.CLIENT.PRENOM + "  " + message.CLIENT.NOM + ".\n");
                MyMQ.Receive();
            }
            //Transaction KO
            else
            {
                textBoxResaVol.AppendText("ECHEC : Réservation du vol " + message.ID_VOL + " pour " + message.CLIENT.PRENOM + "  " + message.CLIENT.NOM + ".\n");
            }
            MyMQ.Close();
        }

        private void btn_reservHotel_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\queuereservationhotel");
            //récupération sans vider la file d'un message, de type clsHotelMSMQ
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsHotelMSMQ) });

            var message = (clsHotelMSMQ)MyMQ.Peek().Body;

            //Enregistrement de la réservation de vol ( dans libValiderCommande)
            bool ResT = EnregistrerReservation.effectuerReservationHotel(message);

            if (ResT == true)
            {
                //Transaction OK
                textBoxResaHotel.AppendText("SUCCES : Réservation de l'hôtel " + message.ID_HOTEL + " de " + message.CLIENT.PRENOM + "  " + message.CLIENT.NOM + ".\n");
                MyMQ.Receive();
            }
            else
            {
                //Transaction KO
                textBoxResaHotel.AppendText("ECHEC : Réservation de l'hôtel " + message.ID + " de " + message.CLIENT.PRENOM + "  " + message.CLIENT.NOM + ".\n");
            }
            MyMQ.Close();
        }
    }
}
