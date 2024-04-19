namespace EsInterfaccie08
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
            this.txtMaxValue = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnIncr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaxValue
            // 
            this.txtMaxValue.Location = new System.Drawing.Point(22, 23);
            this.txtMaxValue.Name = "txtMaxValue";
            this.txtMaxValue.Size = new System.Drawing.Size(155, 26);
            this.txtMaxValue.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(22, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 39);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnIncr
            // 
            this.btnIncr.Location = new System.Drawing.Point(163, 70);
            this.btnIncr.Name = "btnIncr";
            this.btnIncr.Size = new System.Drawing.Size(103, 38);
            this.btnIncr.TabIndex = 2;
            this.btnIncr.Text = "Incrementa";
            this.btnIncr.UseVisualStyleBackColor = true;
            this.btnIncr.Click += new System.EventHandler(this.btnIncr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 151);
            this.Controls.Add(this.btnIncr);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtMaxValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxValue;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnIncr;
    }
}

