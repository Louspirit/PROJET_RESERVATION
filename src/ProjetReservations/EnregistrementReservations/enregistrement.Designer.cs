namespace EnregistrementReservations
{
    partial class enregistrement
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_reservVol = new System.Windows.Forms.Button();
            this.btn_reservHotel = new System.Windows.Forms.Button();
            this.textBoxResaVol = new System.Windows.Forms.TextBox();
            this.textBoxResaHotel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_reservVol
            // 
            this.btn_reservVol.Location = new System.Drawing.Point(232, 649);
            this.btn_reservVol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_reservVol.Name = "btn_reservVol";
            this.btn_reservVol.Size = new System.Drawing.Size(244, 44);
            this.btn_reservVol.TabIndex = 0;
            this.btn_reservVol.Text = "Lire réservation vol";
            this.btn_reservVol.UseVisualStyleBackColor = true;
            this.btn_reservVol.Click += new System.EventHandler(this.btn_reservVol_Click);
            // 
            // btn_reservHotel
            // 
            this.btn_reservHotel.Location = new System.Drawing.Point(1010, 649);
            this.btn_reservHotel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_reservHotel.Name = "btn_reservHotel";
            this.btn_reservHotel.Size = new System.Drawing.Size(270, 44);
            this.btn_reservHotel.TabIndex = 1;
            this.btn_reservHotel.Text = "Lire réservation hôtel";
            this.btn_reservHotel.UseVisualStyleBackColor = true;
            this.btn_reservHotel.Click += new System.EventHandler(this.btn_reservHotel_Click);
            // 
            // textBoxResaVol
            // 
            this.textBoxResaVol.Location = new System.Drawing.Point(31, 22);
            this.textBoxResaVol.Multiline = true;
            this.textBoxResaVol.Name = "textBoxResaVol";
            this.textBoxResaVol.Size = new System.Drawing.Size(742, 596);
            this.textBoxResaVol.TabIndex = 2;
            // 
            // textBoxResaHotel
            // 
            this.textBoxResaHotel.Location = new System.Drawing.Point(779, 22);
            this.textBoxResaHotel.Multiline = true;
            this.textBoxResaHotel.Name = "textBoxResaHotel";
            this.textBoxResaHotel.Size = new System.Drawing.Size(764, 596);
            this.textBoxResaHotel.TabIndex = 3;
            // 
            // enregistrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 724);
            this.Controls.Add(this.textBoxResaHotel);
            this.Controls.Add(this.textBoxResaVol);
            this.Controls.Add(this.btn_reservHotel);
            this.Controls.Add(this.btn_reservVol);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "enregistrement";
            this.Text = "Enregistrement des réservations de vols & hôtels";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reservVol;
        private System.Windows.Forms.Button btn_reservHotel;
        private System.Windows.Forms.TextBox textBoxResaVol;
        private System.Windows.Forms.TextBox textBoxResaHotel;
    }
}

