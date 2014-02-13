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
            this.SuspendLayout();
            // 
            // btn_reservVol
            // 
            this.btn_reservVol.Location = new System.Drawing.Point(49, 202);
            this.btn_reservVol.Name = "btn_reservVol";
            this.btn_reservVol.Size = new System.Drawing.Size(122, 23);
            this.btn_reservVol.TabIndex = 0;
            this.btn_reservVol.Text = "Valider réservation vol";
            this.btn_reservVol.UseVisualStyleBackColor = true;
            this.btn_reservVol.Click += new System.EventHandler(this.btn_reservVol_Click);
            // 
            // btn_reservHotel
            // 
            this.btn_reservHotel.Location = new System.Drawing.Point(461, 202);
            this.btn_reservHotel.Name = "btn_reservHotel";
            this.btn_reservHotel.Size = new System.Drawing.Size(135, 23);
            this.btn_reservHotel.TabIndex = 1;
            this.btn_reservHotel.Text = "Valider réservation hôtel";
            this.btn_reservHotel.UseVisualStyleBackColor = true;
            // 
            // enregistrement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 262);
            this.Controls.Add(this.btn_reservHotel);
            this.Controls.Add(this.btn_reservVol);
            this.Name = "enregistrement";
            this.Text = "Enregistrement des réservations de vols & hôtels";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_reservVol;
        private System.Windows.Forms.Button btn_reservHotel;
    }
}

