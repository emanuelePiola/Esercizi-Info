namespace Es_prova_per_verifica_PT2
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
            this.ucInvia = new Es11_prova_per_verifica.ucInvia();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ucInvia
            // 
            this.ucInvia.Inviata = false;
            this.ucInvia.Location = new System.Drawing.Point(411, 175);
            this.ucInvia.Name = "ucInvia";
            this.ucInvia.Size = new System.Drawing.Size(197, 121);
            this.ucInvia.TabIndex = 0;
            this.ucInvia.Valore = "";
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(532, 121);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(75, 48);
            this.btnPulisci.TabIndex = 1;
            this.btnPulisci.Text = "clear";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.ucInvia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Es11_prova_per_verifica.ucInvia ucInvia;
        private System.Windows.Forms.Button btnPulisci;
    }
}

