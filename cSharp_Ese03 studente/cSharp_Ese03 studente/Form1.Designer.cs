namespace cSharp_Ese03_studente
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
            this.buttonVoti = new System.Windows.Forms.Button();
            this.labelMediaVoti = new System.Windows.Forms.Label();
            this.labelVoti = new System.Windows.Forms.Label();
            this.labelCittà = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.tbCitta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVoti
            // 
            this.buttonVoti.Location = new System.Drawing.Point(13, 150);
            this.buttonVoti.Margin = new System.Windows.Forms.Padding(2);
            this.buttonVoti.Name = "buttonVoti";
            this.buttonVoti.Size = new System.Drawing.Size(85, 23);
            this.buttonVoti.TabIndex = 9;
            this.buttonVoti.Text = "Assegna Voti";
            this.buttonVoti.UseVisualStyleBackColor = true;
            this.buttonVoti.Click += new System.EventHandler(this.buttonVoti_Click);
            // 
            // labelMediaVoti
            // 
            this.labelMediaVoti.AutoSize = true;
            this.labelMediaVoti.Location = new System.Drawing.Point(8, 113);
            this.labelMediaVoti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMediaVoti.Name = "labelMediaVoti";
            this.labelMediaVoti.Size = new System.Drawing.Size(57, 13);
            this.labelMediaVoti.TabIndex = 8;
            this.labelMediaVoti.Text = "Media Voti";
            // 
            // labelVoti
            // 
            this.labelVoti.AutoSize = true;
            this.labelVoti.Location = new System.Drawing.Point(11, 77);
            this.labelVoti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVoti.Name = "labelVoti";
            this.labelVoti.Size = new System.Drawing.Size(25, 13);
            this.labelVoti.TabIndex = 7;
            this.labelVoti.Text = "Voti";
            // 
            // labelCittà
            // 
            this.labelCittà.AutoSize = true;
            this.labelCittà.Location = new System.Drawing.Point(11, 41);
            this.labelCittà.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCittà.Name = "labelCittà";
            this.labelCittà.Size = new System.Drawing.Size(28, 13);
            this.labelCittà.TabIndex = 6;
            this.labelCittà.Text = "Città";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 9);
            this.labelNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 5;
            this.labelNome.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(128, 152);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(76, 20);
            this.tbNome.TabIndex = 10;
            // 
            // tbCitta
            // 
            this.tbCitta.Location = new System.Drawing.Point(210, 152);
            this.tbCitta.Name = "tbCitta";
            this.tbCitta.Size = new System.Drawing.Size(76, 20);
            this.tbCitta.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 136);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Città:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 186);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCitta);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.buttonVoti);
            this.Controls.Add(this.labelMediaVoti);
            this.Controls.Add(this.labelVoti);
            this.Controls.Add(this.labelCittà);
            this.Controls.Add(this.labelNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoti;
        private System.Windows.Forms.Label labelMediaVoti;
        private System.Windows.Forms.Label labelVoti;
        private System.Windows.Forms.Label labelCittà;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.TextBox tbCitta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

