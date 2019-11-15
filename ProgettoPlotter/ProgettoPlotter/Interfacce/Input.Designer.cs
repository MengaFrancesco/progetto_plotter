namespace ProgettoPlotter
{
    partial class Input
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
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.domainUpDownX1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownY1 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.domainUpDownX2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDownY2 = new System.Windows.Forms.DomainUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(70, 124);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(75, 28);
            this.buttonAnnulla.TabIndex = 0;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.buttonAnnulla_Click);
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(167, 124);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(75, 28);
            this.buttonInserisci.TabIndex = 1;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inserire qui le coordinate:";
            // 
            // domainUpDownX1
            // 
            this.domainUpDownX1.Location = new System.Drawing.Point(148, 45);
            this.domainUpDownX1.Name = "domainUpDownX1";
            this.domainUpDownX1.Size = new System.Drawing.Size(44, 20);
            this.domainUpDownX1.TabIndex = 3;
            // 
            // domainUpDownY1
            // 
            this.domainUpDownY1.Location = new System.Drawing.Point(198, 45);
            this.domainUpDownY1.Name = "domainUpDownY1";
            this.domainUpDownY1.Size = new System.Drawing.Size(44, 20);
            this.domainUpDownY1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coordinate punto 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Coordinate punto 2";
            // 
            // domainUpDownX2
            // 
            this.domainUpDownX2.Location = new System.Drawing.Point(148, 86);
            this.domainUpDownX2.Name = "domainUpDownX2";
            this.domainUpDownX2.Size = new System.Drawing.Size(44, 20);
            this.domainUpDownX2.TabIndex = 7;
            // 
            // domainUpDownY2
            // 
            this.domainUpDownY2.Location = new System.Drawing.Point(198, 86);
            this.domainUpDownY2.Name = "domainUpDownY2";
            this.domainUpDownY2.Size = new System.Drawing.Size(44, 20);
            this.domainUpDownY2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Image = global::ProgettoPlotter.Properties.Resources.help3;
            this.button1.Location = new System.Drawing.Point(12, 125);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(28, 28);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Y";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 165);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.domainUpDownY2);
            this.Controls.Add(this.domainUpDownX2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.domainUpDownY1);
            this.Controls.Add(this.domainUpDownX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInserisci);
            this.Controls.Add(this.buttonAnnulla);
            this.Name = "Input";
            this.Text = "Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown domainUpDownX1;
        private System.Windows.Forms.DomainUpDown domainUpDownY1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown domainUpDownX2;
        private System.Windows.Forms.DomainUpDown domainUpDownY2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}