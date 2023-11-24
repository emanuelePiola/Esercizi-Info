namespace cSharp_Ese01
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
            this.label3 = new System.Windows.Forms.Label();
            this.xPuntoA = new System.Windows.Forms.TextBox();
            this.yPuntoA = new System.Windows.Forms.TextBox();
            this.xPuntoB = new System.Windows.Forms.TextBox();
            this.yPuntoB = new System.Windows.Forms.TextBox();
            this.xPuntoC = new System.Windows.Forms.TextBox();
            this.yPuntoC = new System.Windows.Forms.TextBox();
            this.btnCreaA = new System.Windows.Forms.Button();
            this.btnCreaB = new System.Windows.Forms.Button();
            this.btnCreaC = new System.Windows.Forms.Button();
            this.btnRandomA = new System.Windows.Forms.Button();
            this.btnRandomB = new System.Windows.Forms.Button();
            this.btnRandomC = new System.Windows.Forms.Button();
            this.btnCopiaAInB = new System.Windows.Forms.Button();
            this.btnDistanzaAC = new System.Windows.Forms.Button();
            this.btnDistanzaAO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "punto A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "punto B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "punto C";
            // 
            // xPuntoA
            // 
            this.xPuntoA.BackColor = System.Drawing.Color.Yellow;
            this.xPuntoA.Location = new System.Drawing.Point(76, 12);
            this.xPuntoA.Name = "xPuntoA";
            this.xPuntoA.Size = new System.Drawing.Size(60, 20);
            this.xPuntoA.TabIndex = 3;
            // 
            // yPuntoA
            // 
            this.yPuntoA.BackColor = System.Drawing.Color.Yellow;
            this.yPuntoA.Location = new System.Drawing.Point(142, 12);
            this.yPuntoA.Name = "yPuntoA";
            this.yPuntoA.Size = new System.Drawing.Size(60, 20);
            this.yPuntoA.TabIndex = 4;
            // 
            // xPuntoB
            // 
            this.xPuntoB.BackColor = System.Drawing.Color.Yellow;
            this.xPuntoB.Location = new System.Drawing.Point(76, 46);
            this.xPuntoB.Name = "xPuntoB";
            this.xPuntoB.Size = new System.Drawing.Size(60, 20);
            this.xPuntoB.TabIndex = 5;
            // 
            // yPuntoB
            // 
            this.yPuntoB.BackColor = System.Drawing.Color.Yellow;
            this.yPuntoB.Location = new System.Drawing.Point(142, 46);
            this.yPuntoB.Name = "yPuntoB";
            this.yPuntoB.Size = new System.Drawing.Size(60, 20);
            this.yPuntoB.TabIndex = 6;
            // 
            // xPuntoC
            // 
            this.xPuntoC.BackColor = System.Drawing.Color.Yellow;
            this.xPuntoC.Location = new System.Drawing.Point(76, 78);
            this.xPuntoC.Name = "xPuntoC";
            this.xPuntoC.Size = new System.Drawing.Size(60, 20);
            this.xPuntoC.TabIndex = 7;
            // 
            // yPuntoC
            // 
            this.yPuntoC.BackColor = System.Drawing.Color.Yellow;
            this.yPuntoC.Location = new System.Drawing.Point(142, 79);
            this.yPuntoC.Name = "yPuntoC";
            this.yPuntoC.Size = new System.Drawing.Size(60, 20);
            this.yPuntoC.TabIndex = 8;
            // 
            // btnCreaA
            // 
            this.btnCreaA.Location = new System.Drawing.Point(17, 120);
            this.btnCreaA.Name = "btnCreaA";
            this.btnCreaA.Size = new System.Drawing.Size(75, 23);
            this.btnCreaA.TabIndex = 9;
            this.btnCreaA.Text = "Crea A";
            this.btnCreaA.UseVisualStyleBackColor = true;
            this.btnCreaA.Click += new System.EventHandler(this.btnCreaA_Click);
            // 
            // btnCreaB
            // 
            this.btnCreaB.Location = new System.Drawing.Point(98, 120);
            this.btnCreaB.Name = "btnCreaB";
            this.btnCreaB.Size = new System.Drawing.Size(75, 23);
            this.btnCreaB.TabIndex = 10;
            this.btnCreaB.Text = "Crea B";
            this.btnCreaB.UseVisualStyleBackColor = true;
            this.btnCreaB.Click += new System.EventHandler(this.btnCreaB_Click);
            // 
            // btnCreaC
            // 
            this.btnCreaC.Location = new System.Drawing.Point(179, 120);
            this.btnCreaC.Name = "btnCreaC";
            this.btnCreaC.Size = new System.Drawing.Size(75, 23);
            this.btnCreaC.TabIndex = 11;
            this.btnCreaC.Text = "Crea C";
            this.btnCreaC.UseVisualStyleBackColor = true;
            this.btnCreaC.Click += new System.EventHandler(this.btnCreaC_Click);
            // 
            // btnRandomA
            // 
            this.btnRandomA.Location = new System.Drawing.Point(17, 149);
            this.btnRandomA.Name = "btnRandomA";
            this.btnRandomA.Size = new System.Drawing.Size(75, 23);
            this.btnRandomA.TabIndex = 12;
            this.btnRandomA.Text = "A casuale";
            this.btnRandomA.UseVisualStyleBackColor = true;
            // 
            // btnRandomB
            // 
            this.btnRandomB.Location = new System.Drawing.Point(98, 149);
            this.btnRandomB.Name = "btnRandomB";
            this.btnRandomB.Size = new System.Drawing.Size(75, 23);
            this.btnRandomB.TabIndex = 13;
            this.btnRandomB.Text = "B casuale";
            this.btnRandomB.UseVisualStyleBackColor = true;
            // 
            // btnRandomC
            // 
            this.btnRandomC.Location = new System.Drawing.Point(179, 149);
            this.btnRandomC.Name = "btnRandomC";
            this.btnRandomC.Size = new System.Drawing.Size(75, 23);
            this.btnRandomC.TabIndex = 14;
            this.btnRandomC.Text = "C casuale";
            this.btnRandomC.UseVisualStyleBackColor = true;
            // 
            // btnCopiaAInB
            // 
            this.btnCopiaAInB.Location = new System.Drawing.Point(179, 178);
            this.btnCopiaAInB.Name = "btnCopiaAInB";
            this.btnCopiaAInB.Size = new System.Drawing.Size(75, 23);
            this.btnCopiaAInB.TabIndex = 17;
            this.btnCopiaAInB.Text = "Copia B <- A";
            this.btnCopiaAInB.UseVisualStyleBackColor = true;
            // 
            // btnDistanzaAC
            // 
            this.btnDistanzaAC.Location = new System.Drawing.Point(98, 178);
            this.btnDistanzaAC.Name = "btnDistanzaAC";
            this.btnDistanzaAC.Size = new System.Drawing.Size(75, 23);
            this.btnDistanzaAC.TabIndex = 16;
            this.btnDistanzaAC.Text = "Distanza AC";
            this.btnDistanzaAC.UseVisualStyleBackColor = true;
            // 
            // btnDistanzaAO
            // 
            this.btnDistanzaAO.Location = new System.Drawing.Point(17, 178);
            this.btnDistanzaAO.Name = "btnDistanzaAO";
            this.btnDistanzaAO.Size = new System.Drawing.Size(75, 23);
            this.btnDistanzaAO.TabIndex = 15;
            this.btnDistanzaAO.Text = "Distanza AO";
            this.btnDistanzaAO.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(272, 213);
            this.Controls.Add(this.btnCopiaAInB);
            this.Controls.Add(this.btnDistanzaAC);
            this.Controls.Add(this.btnDistanzaAO);
            this.Controls.Add(this.btnRandomC);
            this.Controls.Add(this.btnRandomB);
            this.Controls.Add(this.btnRandomA);
            this.Controls.Add(this.btnCreaC);
            this.Controls.Add(this.btnCreaB);
            this.Controls.Add(this.btnCreaA);
            this.Controls.Add(this.yPuntoC);
            this.Controls.Add(this.xPuntoC);
            this.Controls.Add(this.yPuntoB);
            this.Controls.Add(this.xPuntoB);
            this.Controls.Add(this.yPuntoA);
            this.Controls.Add(this.xPuntoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Punto cartesiano";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xPuntoA;
        private System.Windows.Forms.TextBox yPuntoA;
        private System.Windows.Forms.TextBox xPuntoB;
        private System.Windows.Forms.TextBox yPuntoB;
        private System.Windows.Forms.TextBox xPuntoC;
        private System.Windows.Forms.TextBox yPuntoC;
        private System.Windows.Forms.Button btnCreaA;
        private System.Windows.Forms.Button btnCreaB;
        private System.Windows.Forms.Button btnCreaC;
        private System.Windows.Forms.Button btnRandomA;
        private System.Windows.Forms.Button btnRandomB;
        private System.Windows.Forms.Button btnRandomC;
        private System.Windows.Forms.Button btnCopiaAInB;
        private System.Windows.Forms.Button btnDistanzaAC;
        private System.Windows.Forms.Button btnDistanzaAO;
    }
}

