namespace _17_UsoUserControl
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
            this.chkNumeri = new System.Windows.Forms.CheckBox();
            this.nudCifreDecimali = new System.Windows.Forms.NumericUpDown();
            this.btnPulisci = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtMiaTextBox = new _16_UserControl.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).BeginInit();
            this.SuspendLayout();
            // 
            // chkNumeri
            // 
            this.chkNumeri.AutoSize = true;
            this.chkNumeri.Location = new System.Drawing.Point(54, 140);
            this.chkNumeri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNumeri.Name = "chkNumeri";
            this.chkNumeri.Size = new System.Drawing.Size(183, 24);
            this.chkNumeri.TabIndex = 1;
            this.chkNumeri.Text = "Accetta solo Numero";
            this.chkNumeri.UseVisualStyleBackColor = true;
            this.chkNumeri.CheckedChanged += new System.EventHandler(this.chkNumeri_CheckedChanged);
            // 
            // nudCifreDecimali
            // 
            this.nudCifreDecimali.Location = new System.Drawing.Point(351, 140);
            this.nudCifreDecimali.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCifreDecimali.Name = "nudCifreDecimali";
            this.nudCifreDecimali.Size = new System.Drawing.Size(63, 26);
            this.nudCifreDecimali.TabIndex = 2;
            this.nudCifreDecimali.ValueChanged += new System.EventHandler(this.nudCifreDecimali_ValueChanged);
            // 
            // btnPulisci
            // 
            this.btnPulisci.Location = new System.Drawing.Point(264, 214);
            this.btnPulisci.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPulisci.Name = "btnPulisci";
            this.btnPulisci.Size = new System.Drawing.Size(112, 35);
            this.btnPulisci.TabIndex = 3;
            this.btnPulisci.Text = "Pulisci";
            this.btnPulisci.UseVisualStyleBackColor = true;
            this.btnPulisci.Click += new System.EventHandler(this.btnPulisci_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Visualizza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMiaTextBox
            // 
            this.txtMiaTextBox.CifreDecimali = 0;
            this.txtMiaTextBox.Location = new System.Drawing.Point(54, 59);
            this.txtMiaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMiaTextBox.Name = "txtMiaTextBox";
            this.txtMiaTextBox.Numero = false;
            this.txtMiaTextBox.Size = new System.Drawing.Size(192, 28);
            this.txtMiaTextBox.TabIndex = 5;
            this.txtMiaTextBox.Testo = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 300);
            this.Controls.Add(this.txtMiaTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPulisci);
            this.Controls.Add(this.nudCifreDecimali);
            this.Controls.Add(this.chkNumeri);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCifreDecimali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNumeri;
        private System.Windows.Forms.NumericUpDown nudCifreDecimali;
        private System.Windows.Forms.Button btnPulisci;
        private System.Windows.Forms.Button button1;
        private _16_UserControl.ucTextBox txtMiaTextBox;
    }
}

