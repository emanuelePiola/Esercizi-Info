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
            this.txtAutore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitolo = new System.Windows.Forms.TextBox();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "UTENTE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(113, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtNTessera
            // 
            this.txtNTessera.Location = new System.Drawing.Point(113, 68);
            this.txtNTessera.Name = "txtNTessera";
            this.txtNTessera.Size = new System.Drawing.Size(100, 20);
            this.txtNTessera.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NumeroTessera:";
            // 
            // btnUtente
            // 
            this.btnUtente.Location = new System.Drawing.Point(38, 105);
            this.btnUtente.Name = "btnUtente";
            this.btnUtente.Size = new System.Drawing.Size(131, 26);
            this.btnUtente.TabIndex = 5;
            this.btnUtente.Text = "Aggiungi Utente";
            this.btnUtente.UseVisualStyleBackColor = true;
            this.btnUtente.Click += new System.EventHandler(this.btnUtente_Click);
            // 
            // btnLibro
            // 
            this.btnLibro.Location = new System.Drawing.Point(305, 105);
            this.btnLibro.Name = "btnLibro";
            this.btnLibro.Size = new System.Drawing.Size(131, 26);
            this.btnLibro.TabIndex = 11;
            this.btnLibro.Text = "Inserisci Libro";
            this.btnLibro.UseVisualStyleBackColor = true;
            this.btnLibro.Click += new System.EventHandler(this.btnLibro_Click);
            // 
            // txtAutore
            // 
            this.txtAutore.Location = new System.Drawing.Point(314, 68);
            this.txtAutore.Name = "txtAutore";
            this.txtAutore.Size = new System.Drawing.Size(147, 20);
            this.txtAutore.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Autore:";
            // 
            // txtTitolo
            // 
            this.txtTitolo.Location = new System.Drawing.Point(314, 42);
            this.txtTitolo.Name = "txtTitolo";
            this.txtTitolo.Size = new System.Drawing.Size(147, 20);
            this.txtTitolo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Titolo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "LIBRI";
            // 
            // btnPrestito
            // 
            this.btnPrestito.Location = new System.Drawing.Point(38, 221);
            this.btnPrestito.Name = "btnPrestito";
            this.btnPrestito.Size = new System.Drawing.Size(131, 26);
            this.btnPrestito.TabIndex = 17;
            this.btnPrestito.Text = "Prendi In Prestito";
            this.btnPrestito.UseVisualStyleBackColor = true;
            this.btnPrestito.Click += new System.EventHandler(this.btnPrestito_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "PRESTITO/RESTITUZIONE";
            // 
            // txtTitoloPrestito
            // 
            this.txtTitoloPrestito.Location = new System.Drawing.Point(68, 183);
            this.txtTitoloPrestito.Name = "txtTitoloPrestito";
            this.txtTitoloPrestito.Size = new System.Drawing.Size(145, 20);
            this.txtTitoloPrestito.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Titolo:";
            // 
            // btnRestitutisci
            // 
            this.btnRestitutisci.Location = new System.Drawing.Point(38, 253);
            this.btnRestitutisci.Name = "btnRestitutisci";
            this.btnRestitutisci.Size = new System.Drawing.Size(131, 26);
            this.btnRestitutisci.TabIndex = 20;
            this.btnRestitutisci.Text = "Restituisci";
            this.btnRestitutisci.UseVisualStyleBackColor = true;
            // 
            // btnStatoPrestiti
            // 
            this.btnStatoPrestiti.Location = new System.Drawing.Point(305, 199);
            this.btnStatoPrestiti.Name = "btnStatoPrestiti";
            this.btnStatoPrestiti.Size = new System.Drawing.Size(131, 71);
            this.btnStatoPrestiti.TabIndex = 21;
            this.btnStatoPrestiti.Text = "Visualizza Stato Prestiti";
            this.btnStatoPrestiti.UseVisualStyleBackColor = true;
            this.btnStatoPrestiti.Click += new System.EventHandler(this.btnStatoPrestiti_Click);
            // 
            // txtNumeroPag
            // 
            this.txtNumeroPag.Location = new System.Drawing.Point(481, 68);
            this.txtNumeroPag.Name = "txtNumeroPag";
            this.txtNumeroPag.Size = new System.Drawing.Size(80, 20);
            this.txtNumeroPag.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Numero Pagine:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 322);
            this.Controls.Add(this.txtNumeroPag);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnStatoPrestiti);
            this.Controls.Add(this.btnRestitutisci);
            this.Controls.Add(this.txtTitoloPrestito);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrestito);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLibro);
            this.Controls.Add(this.txtAutore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTitolo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnUtente);
            this.Controls.Add(this.txtNTessera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.TextBox txtAutore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitolo;
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
    }
}

