namespace Es_07_Delegates {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnAddizione = new System.Windows.Forms.Button();
            this.btnMoltiplicazione = new System.Windows.Forms.Button();
            this.btnSottrazione1 = new System.Windows.Forms.Button();
            this.btnSottrazione2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddizione
            // 
            this.btnAddizione.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddizione.Location = new System.Drawing.Point(25, 24);
            this.btnAddizione.Name = "btnAddizione";
            this.btnAddizione.Size = new System.Drawing.Size(75, 75);
            this.btnAddizione.TabIndex = 0;
            this.btnAddizione.Text = "+";
            this.btnAddizione.Click += new System.EventHandler(this.btnAddizione_Click);
            // 
            // btnMoltiplicazione
            // 
            this.btnMoltiplicazione.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoltiplicazione.Location = new System.Drawing.Point(124, 24);
            this.btnMoltiplicazione.Name = "btnMoltiplicazione";
            this.btnMoltiplicazione.Size = new System.Drawing.Size(75, 75);
            this.btnMoltiplicazione.TabIndex = 1;
            this.btnMoltiplicazione.Text = "*";
            this.btnMoltiplicazione.UseVisualStyleBackColor = true;
            this.btnMoltiplicazione.Click += new System.EventHandler(this.btnMoltiplicazione_Click);
            // 
            // btnSottrazione1
            // 
            this.btnSottrazione1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSottrazione1.Location = new System.Drawing.Point(223, 24);
            this.btnSottrazione1.Name = "btnSottrazione1";
            this.btnSottrazione1.Size = new System.Drawing.Size(75, 75);
            this.btnSottrazione1.TabIndex = 2;
            this.btnSottrazione1.Text = "-";
            this.btnSottrazione1.UseVisualStyleBackColor = true;
            this.btnSottrazione1.Click += new System.EventHandler(this.btnSottrazione1_Click);
            // 
            // btnSottrazione2
            // 
            this.btnSottrazione2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSottrazione2.Location = new System.Drawing.Point(322, 24);
            this.btnSottrazione2.Name = "btnSottrazione2";
            this.btnSottrazione2.Size = new System.Drawing.Size(75, 75);
            this.btnSottrazione2.TabIndex = 3;
            this.btnSottrazione2.Text = "-";
            this.btnSottrazione2.UseVisualStyleBackColor = true;
            this.btnSottrazione2.Click += new System.EventHandler(this.btnSottrazione2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 129);
            this.Controls.Add(this.btnSottrazione2);
            this.Controls.Add(this.btnSottrazione1);
            this.Controls.Add(this.btnMoltiplicazione);
            this.Controls.Add(this.btnAddizione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddizione;
        private System.Windows.Forms.Button btnMoltiplicazione;
        private System.Windows.Forms.Button btnSottrazione1;
        private System.Windows.Forms.Button btnSottrazione2;
    }
}