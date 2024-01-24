namespace AbstractClass01
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStampaStudenti = new System.Windows.Forms.Button();
            this.btnStampaCalciatori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStampaStudenti
            // 
            this.btnStampaStudenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampaStudenti.Location = new System.Drawing.Point(15, 25);
            this.btnStampaStudenti.Name = "btnStampaStudenti";
            this.btnStampaStudenti.Size = new System.Drawing.Size(116, 74);
            this.btnStampaStudenti.TabIndex = 0;
            this.btnStampaStudenti.Text = "Stampa Studenti";
            this.btnStampaStudenti.UseVisualStyleBackColor = true;
            this.btnStampaStudenti.Click += new System.EventHandler(this.btnStampaStudenti_Click);
            // 
            // btnStampaCalciatori
            // 
            this.btnStampaCalciatori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStampaCalciatori.Location = new System.Drawing.Point(12, 146);
            this.btnStampaCalciatori.Name = "btnStampaCalciatori";
            this.btnStampaCalciatori.Size = new System.Drawing.Size(116, 74);
            this.btnStampaCalciatori.TabIndex = 1;
            this.btnStampaCalciatori.Text = "Stampa Calciatori";
            this.btnStampaCalciatori.UseVisualStyleBackColor = true;
            this.btnStampaCalciatori.Click += new System.EventHandler(this.btnStampaCalciatori_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 255);
            this.Controls.Add(this.btnStampaCalciatori);
            this.Controls.Add(this.btnStampaStudenti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStampaStudenti;
        private System.Windows.Forms.Button btnStampaCalciatori;
    }
}

