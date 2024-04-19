namespace Es03Interfaccie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtNTessera = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUtente = new System.Windows.Forms.Button();
            this.btnLibro = new System.Windows.Forms.Button();
            this.txtAutoreLibro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitoloLibro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrestito = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTitoloPrestito = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRestitutisci = new System.Windows.Forms.Button();
            this.btnStatoPrestiti = new System.Windows.Forms.Button();
            this.txtNumeroPag = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDVD = new System.Windows.Forms.Button();
            this.txtAutoreDVD = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTitoloDVD = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtGenere = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(170, 65);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtNTessera
            // 
            this.txtNTessera.Location = new System.Drawing.Point(170, 105);
            this.txtNTessera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNTessera.Name = "txtNTessera";
            this.txtNTessera.Size = new System.Drawing.Size(148, 26);
            this.txtNTessera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "NumeroTessera:";
            // 
            // btnUtente
            // 
            this.btnUtente.Location = new System.Drawing.Point(57, 162);
            this.btnUtente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUtente.Name = "btnUtente";
            this.btnUtente.Size = new System.Drawing.Size(196, 40);
            this.btnUtente.TabIndex = 5;
            this.btnUtente.Text = "Aggiungi Utente";
            this.btnUtente.UseVisualStyleBackColor = true;
            this.btnUtente.Click += new System.EventHandler(this.btnUtente_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(458, 162);
            this.btnLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(196, 40);
            this.btnLibro.TabIndex = 11;
            this.btnLibro.Text = "Inserisci Libro";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // txtAutoreLibro
            // 
            this.txtAutoreLibro.Location = new System.Drawing.Point(471, 105);
            this.txtAutoreLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutoreLibro.Name = "txtAutoreLibro";
            this.txtAutoreLibro.Size = new System.Drawing.Size(218, 26);
            this.txtAutoreLibro.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autore:";
            // 
            // txtTitoloLibro
            // 
            this.txtTitoloLibro.Location = new System.Drawing.Point(471, 65);
            this.txtTitoloLibro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitoloLibro.Name = "txtTitoloLibro";
            this.txtTitoloLibro.Size = new System.Drawing.Size(218, 26);
            this.txtTitoloLibro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Titolo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "LIBRI";
            // 
            // btnPrestito
            // 
            this.btnPrestito.Location = new System.Drawing.Point(57, 340);
            this.btnPrestito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrestito.Name = "btnPrestito";
            this.btnPrestito.Size = new System.Drawing.Size(196, 40);
            this.btnPrestito.TabIndex = 17;
            this.btnPrestito.Text = "Prendi In Prestito";
            this.btnPrestito.UseVisualStyleBackColor = true;
            this.btnPrestito.Click += new System.EventHandler(this.btnPrestito_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(45, 235);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(210, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "PRESTITO/RESTITUZIONE";
            // 
            // txtTitoloPrestito
            // 
            this.txtTitoloPrestito.Location = new System.Drawing.Point(102, 282);
            this.txtTitoloPrestito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitoloPrestito.Name = "txtTitoloPrestito";
            this.txtTitoloPrestito.Size = new System.Drawing.Size(216, 26);
            this.txtTitoloPrestito.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 282);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Titolo:";
            // 
            // btnRestitutisci
            // 
            this.btnRestitutisci.Location = new System.Drawing.Point(57, 389);
            this.btnRestitutisci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRestitutisci.Name = "btnRestitutisci";
            this.btnRestitutisci.Size = new System.Drawing.Size(196, 40);
            this.btnRestitutisci.TabIndex = 20;
            this.btnRestitutisci.Text = "Restituisci";
            this.btnRestitutisci.UseVisualStyleBackColor = true;
            this.btnRestitutisci.Click += new System.EventHandler(this.btnRestitutisci_Click);
            // 
            // btnStatoPrestiti
            // 
            this.btnStatoPrestiti.Location = new System.Drawing.Point(458, 306);
            this.btnStatoPrestiti.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStatoPrestiti.Name = "btnStatoPrestiti";
            this.btnStatoPrestiti.Size = new System.Drawing.Size(196, 109);
            this.btnStatoPrestiti.TabIndex = 21;
            this.btnStatoPrestiti.Text = "Visualizza Stato Prestiti";
            this.btnStatoPrestiti.UseVisualStyleBackColor = true;
            this.btnStatoPrestiti.Click += new System.EventHandler(this.btnStatoPrestiti_Click);
            // 
            // txtNumeroPag
            // 
            this.txtNumeroPag.Location = new System.Drawing.Point(722, 105);
            this.txtNumeroPag.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumeroPag.Name = "txtNumeroPag";
            this.txtNumeroPag.Size = new System.Drawing.Size(118, 26);
            this.txtNumeroPag.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(717, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Numero Pagine:";
            // 
            // btnDVD
            // 
            this.btnDVD.Location = new System.Drawing.Point(854, 375);
            this.btnDVD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDVD.Name = "btnDVD";
            this.btnDVD.Size = new System.Drawing.Size(196, 40);
            this.btnDVD.TabIndex = 29;
            this.btnDVD.Text = "Inserisci DVD";
            this.btnDVD.UseVisualStyleBackColor = true;
            this.btnDVD.Click += new System.EventHandler(this.btnDVD_Click);
            // 
            // txtAutoreDVD
            // 
            this.txtAutoreDVD.Location = new System.Drawing.Point(879, 273);
            this.txtAutoreDVD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAutoreDVD.Name = "txtAutoreDVD";
            this.txtAutoreDVD.Size = new System.Drawing.Size(218, 26);
            this.txtAutoreDVD.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(798, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "Autore:";
            // 
            // txtTitoloDVD
            // 
            this.txtTitoloDVD.Location = new System.Drawing.Point(879, 233);
            this.txtTitoloDVD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitoloDVD.Name = "txtTitoloDVD";
            this.txtTitoloDVD.Size = new System.Drawing.Size(218, 26);
            this.txtTitoloDVD.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 233);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Titolo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(930, 182);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "DVD";
            // 
            // txtGenere
            // 
            this.txtGenere.Location = new System.Drawing.Point(879, 318);
            this.txtGenere.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGenere.Name = "txtGenere";
            this.txtGenere.Size = new System.Drawing.Size(218, 26);
            this.txtGenere.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(798, 322);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Genere:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 495);
            this.Controls.Add(this.txtGenere);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnDVD);
            this.Controls.Add(this.txtAutoreDVD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTitoloDVD);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtNumeroPag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStatoPrestiti);
            this.Controls.Add(this.btnRestitutisci);
            this.Controls.Add(this.txtTitoloPrestito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrestito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.txtAutoreLibro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitoloLibro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUtente);
            this.Controls.Add(this.txtNTessera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtNTessera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUtente;
        private System.Windows.Forms.Button btnLibro;
        private System.Windows.Forms.TextBox txtAutoreLibro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitoloLibro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrestito;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTitoloPrestito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRestitutisci;
        private System.Windows.Forms.Button btnStatoPrestiti;
        private System.Windows.Forms.TextBox txtNumeroPag;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDVD;
        private System.Windows.Forms.TextBox txtAutoreDVD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTitoloDVD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGenere;
        private System.Windows.Forms.Label label13;
    }
}

