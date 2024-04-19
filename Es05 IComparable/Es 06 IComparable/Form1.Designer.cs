namespace Es_06_IComparable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCognome = new System.Windows.Forms.Label();
            this.txtCognome = new System.Windows.Forms.TextBox();
            this.lblEta = new System.Windows.Forms.Label();
            this.txtEta = new System.Windows.Forms.TextBox();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnElenco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "lblNome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(108, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // lblCognome
            // 
            this.lblCognome.AutoSize = true;
            this.lblCognome.Location = new System.Drawing.Point(27, 69);
            this.lblCognome.Name = "lblCognome";
            this.lblCognome.Size = new System.Drawing.Size(62, 13);
            this.lblCognome.TabIndex = 2;
            this.lblCognome.Text = "lblCognome";
            // 
            // txtCognome
            // 
            this.txtCognome.Location = new System.Drawing.Point(108, 66);
            this.txtCognome.Name = "txtCognome";
            this.txtCognome.Size = new System.Drawing.Size(100, 20);
            this.txtCognome.TabIndex = 3;
            // 
            // lblEta
            // 
            this.lblEta.AutoSize = true;
            this.lblEta.Location = new System.Drawing.Point(27, 108);
            this.lblEta.Name = "lblEta";
            this.lblEta.Size = new System.Drawing.Size(33, 13);
            this.lblEta.TabIndex = 4;
            this.lblEta.Text = "lblEta";
            // 
            // txtEta
            // 
            this.txtEta.Location = new System.Drawing.Point(108, 105);
            this.txtEta.Name = "txtEta";
            this.txtEta.Size = new System.Drawing.Size(100, 20);
            this.txtEta.TabIndex = 5;
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(30, 157);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 6;
            this.btnInserisci.Text = "btnInserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnElenco
            // 
            this.btnElenco.Location = new System.Drawing.Point(133, 157);
            this.btnElenco.Name = "btnElenco";
            this.btnElenco.Size = new System.Drawing.Size(75, 23);
            this.btnElenco.TabIndex = 7;
            this.btnElenco.Text = "btnElenco";
            this.btnElenco.UseVisualStyleBackColor = true;
            this.btnElenco.Click += new System.EventHandler(this.btnElenco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 211);
            this.Controls.Add(this.btnElenco);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.txtEta);
            this.Controls.Add(this.lblEta);
            this.Controls.Add(this.txtCognome);
            this.Controls.Add(this.lblCognome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCognome;
        private System.Windows.Forms.TextBox txtCognome;
        private System.Windows.Forms.Label lblEta;
        private System.Windows.Forms.TextBox txtEta;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnElenco;
    }
}
