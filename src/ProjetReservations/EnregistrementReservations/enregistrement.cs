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
using libReservationVol;
using libReservationHotel; 

namespace EnregistrementReservations
{
    public partial class enregistrement : Form
    {
        public enregistrement()
        {
            InitializeComponent();
        }

        private void btn_reservVol_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\queuereservationvol");
            //récupération sans vider la file d'un message, de type clsVolEnregistrement
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(clsVolMSMQ) });

            clsVolMSMQ message = (clsVolMSMQ)MyMQ.Peek().Body;
            clsVolMSMQ client = message.CLIENT;

            //Enregistrement de la réservation de vol ( dans libValiderCommande)
            bool ResT = effectuerReservationVol(message.ID, message.MONTANT, client.NOM, client.PRENOM, client.ADRESSE, client.NUM_CARTE);

            //Transaction OK
            if (ResT == true)
            {

                //txtTransfert.AppendText("Transfert de " + message.Montant + " du compte " + message.CD + " vers " + message.CC + "\n");
                //Zone critique : le Receive devrait être sous forme de composant lui aussi dans le serveu d'application
                MyMQ.Receive();
            }
            //Transaction KO
            else
            {
                //txtTransfert.AppendText("Impossible de transférer " + message.Montant + " du compte " + message.CD + " vers " + message.CC + "\n");
            }
            MyMQ.Close();
        }

        private void btn_reservHotel_Click(object sender, EventArgs e)
        {

        }
    }
}
