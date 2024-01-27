namespace RegEX05
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnTelefono = new System.Windows.Forms.Button();
            this.btnImporto = new System.Windows.Forms.Button();
            this.btnClasse = new System.Windows.Forms.Button();
            this.btnSpecializzazione = new System.Windows.Forms.Button();
            this.btnCodFiscale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INPUT DA CONTROLLARE";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(175, 13);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(295, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnTelefono
            // 
            this.btnTelefono.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTelefono.Location = new System.Drawing.Point(16, 70);
            this.btnTelefono.Name = "btnTelefono";
            this.btnTelefono.Size = new System.Drawing.Size(105, 39);
            this.btnTelefono.TabIndex = 2;
            this.btnTelefono.Text = "TELEFONO";
            this.btnTelefono.UseVisualStyleBackColor = false;
            this.btnTelefono.Click += new System.EventHandler(this.btnTelefono_Click);
            // 
            // btnImporto
            // 
            this.btnImporto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImporto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnImporto.Location = new System.Drawing.Point(16, 151);
            this.btnImporto.Name = "btnImporto";
            this.btnImporto.Size = new System.Drawing.Size(105, 39);
            this.btnImporto.TabIndex = 3;
            this.btnImporto.Text = "IMPORTO";
            this.btnImporto.UseVisualStyleBackColor = false;
            // 
            // btnClasse
            // 
            this.btnClasse.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClasse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClasse.Location = new System.Drawing.Point(365, 70);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(105, 39);
            this.btnClasse.TabIndex = 4;
            this.btnClasse.Text = "CLASSE";
            this.btnClasse.UseVisualStyleBackColor = false;
            // 
            // btnSpecializzazione
            // 
            this.btnSpecializzazione.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSpecializzazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecializzazione.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSpecializzazione.Location = new System.Drawing.Point(148, 70);
            this.btnSpecializzazione.Name = "btnSpecializzazione";
            this.btnSpecializzazione.Size = new System.Drawing.Size(186, 61);
            this.btnSpecializzazione.TabIndex = 5;
            this.btnSpecializzazione.Text = "SPECIALIZZAZIONE (INF, MEC, ELT)";
            this.btnSpecializzazione.UseVisualStyleBackColor = false;
            // 
            // btnCodFiscale
            // 
            this.btnCodFiscale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCodFiscale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCodFiscale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCodFiscale.Location = new System.Drawing.Point(350, 151);
            this.btnCodFiscale.Name = "btnCodFiscale";
            this.btnCodFiscale.Size = new System.Drawing.Size(120, 39);
            this.btnCodFiscale.TabIndex = 6;
            this.btnCodFiscale.Text = "COD. FISCALE";
            this.btnCodFiscale.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 202);
            this.Controls.Add(this.btnCodFiscale);
            this.Controls.Add(this.btnSpecializzazione);
            this.Controls.Add(this.btnClasse);
            this.Controls.Add(this.btnImporto);
            this.Controls.Add(this.btnTelefono);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnTelefono;
        private System.Windows.Forms.Button btnImporto;
        private System.Windows.Forms.Button btnClasse;
        private System.Windows.Forms.Button btnSpecializzazione;
        private System.Windows.Forms.Button btnCodFiscale;
    }
}

