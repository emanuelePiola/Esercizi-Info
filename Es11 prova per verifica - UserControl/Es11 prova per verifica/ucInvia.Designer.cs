namespace Es11_prova_per_verifica
{
    partial class ucInvia
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

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTestoDaInviare = new System.Windows.Forms.TextBox();
            this.btnInvia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTestoDaInviare
            // 
            this.txtTestoDaInviare.Location = new System.Drawing.Point(19, 19);
            this.txtTestoDaInviare.Name = "txtTestoDaInviare";
            this.txtTestoDaInviare.Size = new System.Drawing.Size(159, 26);
            this.txtTestoDaInviare.TabIndex = 0;
            this.txtTestoDaInviare.TextChanged += new System.EventHandler(this.txtTestoDaInviare_TextChanged);
            // 
            // btnInvia
            // 
            this.btnInvia.Location = new System.Drawing.Point(75, 67);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(103, 33);
            this.btnInvia.TabIndex = 1;
            this.btnInvia.Text = "Invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // ucInvia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInvia);
            this.Controls.Add(this.txtTestoDaInviare);
            this.Name = "ucInvia";
            this.Size = new System.Drawing.Size(197, 121);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTestoDaInviare;
        private System.Windows.Forms.Button btnInvia;
    }
}
