namespace ProgettoPlotter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxLinee = new System.Windows.Forms.ListBox();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonPulisci = new System.Windows.Forms.Button();
            this.buttonStampa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDisconnetti = new System.Windows.Forms.Button();
            this.buttonConnetti = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.labelCollegamento = new System.Windows.Forms.Label();
            this.buttonInfoInserisci = new System.Windows.Forms.Button();
            this.buttonInfoStampa = new System.Windows.Forms.Button();
            this.buttonInfoAnnulla = new System.Windows.Forms.Button();
            this.buttonInfoPulisci = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonInfoElimina = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxLinee
            // 
            this.listBoxLinee.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxLinee.FormattingEnabled = true;
            this.listBoxLinee.Location = new System.Drawing.Point(384, 44);
            this.listBoxLinee.Name = "listBoxLinee";
            this.listBoxLinee.Size = new System.Drawing.Size(255, 238);
            this.listBoxLinee.TabIndex = 1;
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Location = new System.Drawing.Point(6, 66);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(84, 28);
            this.buttonAnnulla.TabIndex = 2;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonPulisci
            // 
            this.buttonPulisci.Location = new System.Drawing.Point(6, 32);
            this.buttonPulisci.Name = "buttonPulisci";
            this.buttonPulisci.Size = new System.Drawing.Size(84, 28);
            this.buttonPulisci.TabIndex = 3;
            this.buttonPulisci.Text = "Pulisci";
            this.buttonPulisci.UseVisualStyleBackColor = true;
            this.buttonPulisci.Click += new System.EventHandler(this.buttonPulisci_Click);
            // 
            // buttonStampa
            // 
            this.buttonStampa.Location = new System.Drawing.Point(6, 170);
            this.buttonStampa.Name = "buttonStampa";
            this.buttonStampa.Size = new System.Drawing.Size(84, 28);
            this.buttonStampa.TabIndex = 4;
            this.buttonStampa.Text = "Stampa";
            this.buttonStampa.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elenco delle linee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operazioni:";
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Location = new System.Drawing.Point(6, 102);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(84, 28);
            this.buttonInserisci.TabIndex = 10;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonDisconnetti);
            this.panel1.Controls.Add(this.buttonConnetti);
            this.panel1.Controls.Add(this.comboBoxCOM);
            this.panel1.Controls.Add(this.labelSerial);
            this.panel1.Controls.Add(this.labelCollegamento);
            this.panel1.Location = new System.Drawing.Point(12, 288);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 102);
            this.panel1.TabIndex = 12;
            // 
            // buttonDisconnetti
            // 
            this.buttonDisconnetti.Location = new System.Drawing.Point(265, 29);
            this.buttonDisconnetti.Name = "buttonDisconnetti";
            this.buttonDisconnetti.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnetti.TabIndex = 4;
            this.buttonDisconnetti.Text = "Disconnetti";
            this.buttonDisconnetti.UseVisualStyleBackColor = true;
            this.buttonDisconnetti.Click += new System.EventHandler(this.buttonDisconnetti_Click);
            // 
            // buttonConnetti
            // 
            this.buttonConnetti.Location = new System.Drawing.Point(175, 29);
            this.buttonConnetti.Name = "buttonConnetti";
            this.buttonConnetti.Size = new System.Drawing.Size(75, 23);
            this.buttonConnetti.TabIndex = 3;
            this.buttonConnetti.Text = "Connetti";
            this.buttonConnetti.UseVisualStyleBackColor = true;
            this.buttonConnetti.Click += new System.EventHandler(this.buttonConnetti_Click);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {
            "COM 1",
            "COM 2 ",
            "COM 3",
            "COM 4",
            "COM 5",
            "COM 6",
            "COM 7",
            "COM 8"});
            this.comboBoxCOM.Location = new System.Drawing.Point(83, 31);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(74, 21);
            this.comboBoxCOM.TabIndex = 2;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(7, 34);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(70, 13);
            this.labelSerial.TabIndex = 1;
            this.labelSerial.Text = "Porta Seriale:";
            // 
            // labelCollegamento
            // 
            this.labelCollegamento.AutoSize = true;
            this.labelCollegamento.Location = new System.Drawing.Point(4, 4);
            this.labelCollegamento.Name = "labelCollegamento";
            this.labelCollegamento.Size = new System.Drawing.Size(131, 13);
            this.labelCollegamento.TabIndex = 0;
            this.labelCollegamento.Text = "Collegamento con Arduino";
            // 
            // buttonInfoInserisci
            // 
            this.buttonInfoInserisci.BackgroundImage = global::ProgettoPlotter.Properties.Resources.help3;
            this.buttonInfoInserisci.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoInserisci.Image")));
            this.buttonInfoInserisci.Location = new System.Drawing.Point(96, 102);
            this.buttonInfoInserisci.Name = "buttonInfoInserisci";
            this.buttonInfoInserisci.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoInserisci.TabIndex = 11;
            this.buttonInfoInserisci.UseVisualStyleBackColor = true;
            this.buttonInfoInserisci.Click += new System.EventHandler(this.buttonInfoInserisci_Click);
            // 
            // buttonInfoStampa
            // 
            this.buttonInfoStampa.BackgroundImage = global::ProgettoPlotter.Properties.Resources.help1;
            this.buttonInfoStampa.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoStampa.Image")));
            this.buttonInfoStampa.Location = new System.Drawing.Point(96, 170);
            this.buttonInfoStampa.Name = "buttonInfoStampa";
            this.buttonInfoStampa.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoStampa.TabIndex = 7;
            this.buttonInfoStampa.UseVisualStyleBackColor = true;
            this.buttonInfoStampa.Click += new System.EventHandler(this.buttonInfoStampa_Click);
            // 
            // buttonInfoAnnulla
            // 
            this.buttonInfoAnnulla.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoAnnulla.Image")));
            this.buttonInfoAnnulla.Location = new System.Drawing.Point(96, 66);
            this.buttonInfoAnnulla.Name = "buttonInfoAnnulla";
            this.buttonInfoAnnulla.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoAnnulla.TabIndex = 6;
            this.buttonInfoAnnulla.UseVisualStyleBackColor = true;
            this.buttonInfoAnnulla.Click += new System.EventHandler(this.buttonInfoAnnulla_Click);
            // 
            // buttonInfoPulisci
            // 
            this.buttonInfoPulisci.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoPulisci.Image")));
            this.buttonInfoPulisci.Location = new System.Drawing.Point(96, 32);
            this.buttonInfoPulisci.Name = "buttonInfoPulisci";
            this.buttonInfoPulisci.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoPulisci.TabIndex = 5;
            this.buttonInfoPulisci.UseVisualStyleBackColor = true;
            this.buttonInfoPulisci.Click += new System.EventHandler(this.buttonInfoPulisci_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(363, 270);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // buttonElimina
            // 
            this.buttonElimina.Location = new System.Drawing.Point(6, 136);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(84, 28);
            this.buttonElimina.TabIndex = 13;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonInfoElimina
            // 
            this.buttonInfoElimina.Image = global::ProgettoPlotter.Properties.Resources.help5;
            this.buttonInfoElimina.Location = new System.Drawing.Point(96, 136);
            this.buttonInfoElimina.Name = "buttonInfoElimina";
            this.buttonInfoElimina.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoElimina.TabIndex = 14;
            this.buttonInfoElimina.UseVisualStyleBackColor = true;
            this.buttonInfoElimina.Click += new System.EventHandler(this.buttonInfoElimina_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonInfoElimina);
            this.panel2.Controls.Add(this.buttonPulisci);
            this.panel2.Controls.Add(this.buttonElimina);
            this.panel2.Controls.Add(this.buttonInfoPulisci);
            this.panel2.Controls.Add(this.buttonAnnulla);
            this.panel2.Controls.Add(this.buttonInfoStampa);
            this.panel2.Controls.Add(this.buttonInfoInserisci);
            this.panel2.Controls.Add(this.buttonStampa);
            this.panel2.Controls.Add(this.buttonInfoAnnulla);
            this.panel2.Controls.Add(this.buttonInserisci);
            this.panel2.Location = new System.Drawing.Point(645, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 270);
            this.panel2.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 402);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxLinee);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "howto_draw_lines";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.ListBox listBoxLinee;
        private System.Windows.Forms.Button buttonAnnulla;
        private System.Windows.Forms.Button buttonPulisci;
        private System.Windows.Forms.Button buttonStampa;
        private System.Windows.Forms.Button buttonInfoPulisci;
        private System.Windows.Forms.Button buttonInfoAnnulla;
        private System.Windows.Forms.Button buttonInfoStampa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInserisci;
        private System.Windows.Forms.Button buttonInfoInserisci;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonInfoElimina;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Label labelCollegamento;
        private System.Windows.Forms.Button buttonDisconnetti;
        private System.Windows.Forms.Button buttonConnetti;
        private System.Windows.Forms.Panel panel2;
    }
}

