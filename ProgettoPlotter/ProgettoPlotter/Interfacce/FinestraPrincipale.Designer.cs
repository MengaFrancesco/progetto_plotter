namespace ProgettoPlotter
{
    partial class FinestraPrincipale
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinestraPrincipale));
            this.listBoxLinee = new System.Windows.Forms.ListBox();
            this.buttonAnnulla = new System.Windows.Forms.Button();
            this.buttonStampa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInserisci = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonConnetti = new System.Windows.Forms.Button();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.labelSerial = new System.Windows.Forms.Label();
            this.labelCollegamento = new System.Windows.Forms.Label();
            this.buttonElimina = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonInfoElimina = new System.Windows.Forms.Button();
            this.buttonPulisci = new System.Windows.Forms.Button();
            this.buttonInfoPulisci = new System.Windows.Forms.Button();
            this.buttonInfoStampa = new System.Windows.Forms.Button();
            this.buttonInfoInserisci = new System.Windows.Forms.Button();
            this.buttonInfoAnnulla = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaLineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaUltimaLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserisciLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminaLineaSelezionataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stampaProgettoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elencoLineeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpDisegnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottonePulisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottoneAnnullaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottoneInserisciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottoneEliminaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottoneStampaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpComandiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpCollegamentoStampanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informazioniSulProgrammaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxLinee
            // 
            this.listBoxLinee.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxLinee.FormattingEnabled = true;
            this.listBoxLinee.Location = new System.Drawing.Point(6, 16);
            this.listBoxLinee.Name = "listBoxLinee";
            this.listBoxLinee.Size = new System.Drawing.Size(257, 251);
            this.listBoxLinee.TabIndex = 1;
            // 
            // buttonAnnulla
            // 
            this.buttonAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonAnnulla.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnnulla.Location = new System.Drawing.Point(275, 69);
            this.buttonAnnulla.Name = "buttonAnnulla";
            this.buttonAnnulla.Size = new System.Drawing.Size(79, 28);
            this.buttonAnnulla.TabIndex = 2;
            this.buttonAnnulla.Text = "Annulla";
            this.buttonAnnulla.UseVisualStyleBackColor = true;
            this.buttonAnnulla.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStampa
            // 
            this.buttonStampa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStampa.Location = new System.Drawing.Point(275, 173);
            this.buttonStampa.Name = "buttonStampa";
            this.buttonStampa.Size = new System.Drawing.Size(79, 28);
            this.buttonStampa.TabIndex = 4;
            this.buttonStampa.Text = "Stampa";
            this.buttonStampa.UseVisualStyleBackColor = true;
            this.buttonStampa.Click += new System.EventHandler(this.buttonStampa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Elenco delle linee:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Operazioni:";
            // 
            // buttonInserisci
            // 
            this.buttonInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInserisci.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonInserisci.Location = new System.Drawing.Point(275, 105);
            this.buttonInserisci.Name = "buttonInserisci";
            this.buttonInserisci.Size = new System.Drawing.Size(79, 28);
            this.buttonInserisci.TabIndex = 10;
            this.buttonInserisci.Text = "Inserisci";
            this.buttonInserisci.UseVisualStyleBackColor = true;
            this.buttonInserisci.Click += new System.EventHandler(this.buttonInserisci_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.buttonConnetti);
            this.panel1.Controls.Add(this.comboBoxCOM);
            this.panel1.Controls.Add(this.labelSerial);
            this.panel1.Controls.Add(this.labelCollegamento);
            this.panel1.Location = new System.Drawing.Point(417, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 75);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Image = global::ProgettoPlotter.Properties.Resources._681px_Arduino_uno_perspective_transparent;
            this.button2.Location = new System.Drawing.Point(275, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 64);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
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
            "COM1",
            "COM2 ",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
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
            // buttonElimina
            // 
            this.buttonElimina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonElimina.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonElimina.Location = new System.Drawing.Point(275, 139);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(79, 28);
            this.buttonElimina.TabIndex = 13;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonInfoElimina);
            this.panel2.Controls.Add(this.listBoxLinee);
            this.panel2.Controls.Add(this.buttonPulisci);
            this.panel2.Controls.Add(this.buttonElimina);
            this.panel2.Controls.Add(this.buttonInfoPulisci);
            this.panel2.Controls.Add(this.buttonAnnulla);
            this.panel2.Controls.Add(this.buttonInfoStampa);
            this.panel2.Controls.Add(this.buttonInfoInserisci);
            this.panel2.Controls.Add(this.buttonStampa);
            this.panel2.Controls.Add(this.buttonInfoAnnulla);
            this.panel2.Controls.Add(this.buttonInserisci);
            this.panel2.Location = new System.Drawing.Point(417, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(395, 282);
            this.panel2.TabIndex = 15;
            // 
            // buttonInfoElimina
            // 
            this.buttonInfoElimina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInfoElimina.Image = global::ProgettoPlotter.Properties.Resources.help5;
            this.buttonInfoElimina.Location = new System.Drawing.Point(360, 139);
            this.buttonInfoElimina.Name = "buttonInfoElimina";
            this.buttonInfoElimina.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoElimina.TabIndex = 14;
            this.buttonInfoElimina.UseVisualStyleBackColor = true;
            this.buttonInfoElimina.Click += new System.EventHandler(this.buttonInfoElimina_Click);
            // 
            // buttonPulisci
            // 
            this.buttonPulisci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonPulisci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPulisci.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonPulisci.Location = new System.Drawing.Point(275, 35);
            this.buttonPulisci.Name = "buttonPulisci";
            this.buttonPulisci.Size = new System.Drawing.Size(79, 28);
            this.buttonPulisci.TabIndex = 3;
            this.buttonPulisci.Text = "Pulisci";
            this.buttonPulisci.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPulisci.UseVisualStyleBackColor = true;
            this.buttonPulisci.Click += new System.EventHandler(this.buttonPulisci_Click);
            // 
            // buttonInfoPulisci
            // 
            this.buttonInfoPulisci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInfoPulisci.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoPulisci.Image")));
            this.buttonInfoPulisci.Location = new System.Drawing.Point(360, 35);
            this.buttonInfoPulisci.Name = "buttonInfoPulisci";
            this.buttonInfoPulisci.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoPulisci.TabIndex = 5;
            this.buttonInfoPulisci.UseVisualStyleBackColor = true;
            this.buttonInfoPulisci.Click += new System.EventHandler(this.buttonInfoPulisci_Click);
            // 
            // buttonInfoStampa
            // 
            this.buttonInfoStampa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInfoStampa.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoStampa.Image")));
            this.buttonInfoStampa.Location = new System.Drawing.Point(360, 173);
            this.buttonInfoStampa.Name = "buttonInfoStampa";
            this.buttonInfoStampa.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoStampa.TabIndex = 7;
            this.buttonInfoStampa.UseVisualStyleBackColor = true;
            this.buttonInfoStampa.Click += new System.EventHandler(this.buttonInfoStampa_Click);
            // 
            // buttonInfoInserisci
            // 
            this.buttonInfoInserisci.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInfoInserisci.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoInserisci.Image")));
            this.buttonInfoInserisci.Location = new System.Drawing.Point(360, 105);
            this.buttonInfoInserisci.Name = "buttonInfoInserisci";
            this.buttonInfoInserisci.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoInserisci.TabIndex = 11;
            this.buttonInfoInserisci.UseVisualStyleBackColor = true;
            this.buttonInfoInserisci.Click += new System.EventHandler(this.buttonInfoInserisci_Click);
            // 
            // buttonInfoAnnulla
            // 
            this.buttonInfoAnnulla.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonInfoAnnulla.Image = ((System.Drawing.Image)(resources.GetObject("buttonInfoAnnulla.Image")));
            this.buttonInfoAnnulla.Location = new System.Drawing.Point(360, 69);
            this.buttonInfoAnnulla.Name = "buttonInfoAnnulla";
            this.buttonInfoAnnulla.Size = new System.Drawing.Size(28, 28);
            this.buttonInfoAnnulla.TabIndex = 6;
            this.buttonInfoAnnulla.UseVisualStyleBackColor = true;
            this.buttonInfoAnnulla.Click += new System.EventHandler(this.buttonInfoAnnulla_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.modificaToolStripMenuItem,
            this.visualizzaToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // apriToolStripMenuItem
            // 
            this.apriToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.apriToolStripMenuItem.Name = "apriToolStripMenuItem";
            this.apriToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.apriToolStripMenuItem.Text = "Nuovo progetto..";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem2.Text = "Apri file..";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(165, 22);
            this.toolStripMenuItem3.Text = "Salva file..";
            // 
            // modificaToolStripMenuItem
            // 
            this.modificaToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.modificaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminaLineeToolStripMenuItem,
            this.eliminaUltimaLineaToolStripMenuItem,
            this.inserisciLineaToolStripMenuItem,
            this.eliminaLineaSelezionataToolStripMenuItem,
            this.stampaProgettoToolStripMenuItem});
            this.modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            this.modificaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.modificaToolStripMenuItem.Text = "Modifica";
            // 
            // eliminaLineeToolStripMenuItem
            // 
            this.eliminaLineeToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eliminaLineeToolStripMenuItem.Name = "eliminaLineeToolStripMenuItem";
            this.eliminaLineeToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.eliminaLineeToolStripMenuItem.Text = "Elimina linee";
            this.eliminaLineeToolStripMenuItem.Click += new System.EventHandler(this.eliminaLineeToolStripMenuItem_Click);
            // 
            // eliminaUltimaLineaToolStripMenuItem
            // 
            this.eliminaUltimaLineaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eliminaUltimaLineaToolStripMenuItem.Name = "eliminaUltimaLineaToolStripMenuItem";
            this.eliminaUltimaLineaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.eliminaUltimaLineaToolStripMenuItem.Text = "Elimina ultima linea";
            this.eliminaUltimaLineaToolStripMenuItem.Click += new System.EventHandler(this.eliminaUltimaLineaToolStripMenuItem_Click);
            // 
            // inserisciLineaToolStripMenuItem
            // 
            this.inserisciLineaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.inserisciLineaToolStripMenuItem.Name = "inserisciLineaToolStripMenuItem";
            this.inserisciLineaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.inserisciLineaToolStripMenuItem.Text = "Inserisci linea";
            this.inserisciLineaToolStripMenuItem.Click += new System.EventHandler(this.inserisciLineaToolStripMenuItem_Click);
            // 
            // eliminaLineaSelezionataToolStripMenuItem
            // 
            this.eliminaLineaSelezionataToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.eliminaLineaSelezionataToolStripMenuItem.Name = "eliminaLineaSelezionataToolStripMenuItem";
            this.eliminaLineaSelezionataToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.eliminaLineaSelezionataToolStripMenuItem.Text = "Elimina linea selezionata";
            this.eliminaLineaSelezionataToolStripMenuItem.Click += new System.EventHandler(this.eliminaLineaSelezionataToolStripMenuItem_Click);
            // 
            // stampaProgettoToolStripMenuItem
            // 
            this.stampaProgettoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.stampaProgettoToolStripMenuItem.Name = "stampaProgettoToolStripMenuItem";
            this.stampaProgettoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.stampaProgettoToolStripMenuItem.Text = "Stampa progetto";
            this.stampaProgettoToolStripMenuItem.Click += new System.EventHandler(this.stampaProgettoToolStripMenuItem_Click);
            // 
            // visualizzaToolStripMenuItem
            // 
            this.visualizzaToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.visualizzaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elencoLineeToolStripMenuItem});
            this.visualizzaToolStripMenuItem.Name = "visualizzaToolStripMenuItem";
            this.visualizzaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.visualizzaToolStripMenuItem.Text = "Visualizza";
            // 
            // elencoLineeToolStripMenuItem
            // 
            this.elencoLineeToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.elencoLineeToolStripMenuItem.Name = "elencoLineeToolStripMenuItem";
            this.elencoLineeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.elencoLineeToolStripMenuItem.Text = "Elenco linee";
            this.elencoLineeToolStripMenuItem.Click += new System.EventHandler(this.elencoLineeToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpDisegnoToolStripMenuItem,
            this.helpComandiToolStripMenuItem,
            this.helpCollegamentoStampanteToolStripMenuItem,
            this.informazioniSulProgrammaToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpDisegnoToolStripMenuItem
            // 
            this.helpDisegnoToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpDisegnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bottonePulisciToolStripMenuItem,
            this.bottoneAnnullaToolStripMenuItem,
            this.bottoneInserisciToolStripMenuItem,
            this.bottoneEliminaToolStripMenuItem,
            this.bottoneStampaToolStripMenuItem});
            this.helpDisegnoToolStripMenuItem.Name = "helpDisegnoToolStripMenuItem";
            this.helpDisegnoToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.helpDisegnoToolStripMenuItem.Text = "Help bottoni";
            // 
            // bottonePulisciToolStripMenuItem
            // 
            this.bottonePulisciToolStripMenuItem.Name = "bottonePulisciToolStripMenuItem";
            this.bottonePulisciToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bottonePulisciToolStripMenuItem.Text = "Bottone pulisci";
            this.bottonePulisciToolStripMenuItem.Click += new System.EventHandler(this.bottonePulisciToolStripMenuItem_Click);
            // 
            // bottoneAnnullaToolStripMenuItem
            // 
            this.bottoneAnnullaToolStripMenuItem.Name = "bottoneAnnullaToolStripMenuItem";
            this.bottoneAnnullaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bottoneAnnullaToolStripMenuItem.Text = "Bottone annulla";
            this.bottoneAnnullaToolStripMenuItem.Click += new System.EventHandler(this.bottoneAnnullaToolStripMenuItem_Click);
            // 
            // bottoneInserisciToolStripMenuItem
            // 
            this.bottoneInserisciToolStripMenuItem.Name = "bottoneInserisciToolStripMenuItem";
            this.bottoneInserisciToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bottoneInserisciToolStripMenuItem.Text = "Bottone inserisci";
            this.bottoneInserisciToolStripMenuItem.Click += new System.EventHandler(this.bottoneInserisciToolStripMenuItem_Click);
            // 
            // bottoneEliminaToolStripMenuItem
            // 
            this.bottoneEliminaToolStripMenuItem.Name = "bottoneEliminaToolStripMenuItem";
            this.bottoneEliminaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bottoneEliminaToolStripMenuItem.Text = "Bottone elimina";
            this.bottoneEliminaToolStripMenuItem.Click += new System.EventHandler(this.bottoneEliminaToolStripMenuItem_Click);
            // 
            // bottoneStampaToolStripMenuItem
            // 
            this.bottoneStampaToolStripMenuItem.Name = "bottoneStampaToolStripMenuItem";
            this.bottoneStampaToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.bottoneStampaToolStripMenuItem.Text = "Bottone stampa";
            this.bottoneStampaToolStripMenuItem.Click += new System.EventHandler(this.bottoneStampaToolStripMenuItem_Click);
            // 
            // helpComandiToolStripMenuItem
            // 
            this.helpComandiToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpComandiToolStripMenuItem.Name = "helpComandiToolStripMenuItem";
            this.helpComandiToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.helpComandiToolStripMenuItem.Text = "Help disegno";
            // 
            // helpCollegamentoStampanteToolStripMenuItem
            // 
            this.helpCollegamentoStampanteToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.helpCollegamentoStampanteToolStripMenuItem.Name = "helpCollegamentoStampanteToolStripMenuItem";
            this.helpCollegamentoStampanteToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.helpCollegamentoStampanteToolStripMenuItem.Text = "Help collegamento stampante";
            this.helpCollegamentoStampanteToolStripMenuItem.Click += new System.EventHandler(this.helpCollegamentoStampanteToolStripMenuItem_Click);
            // 
            // informazioniSulProgrammaToolStripMenuItem
            // 
            this.informazioniSulProgrammaToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.informazioniSulProgrammaToolStripMenuItem.Name = "informazioniSulProgrammaToolStripMenuItem";
            this.informazioniSulProgrammaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.informazioniSulProgrammaToolStripMenuItem.Text = "Informazioni ";
            this.informazioniSulProgrammaToolStripMenuItem.Click += new System.EventHandler(this.informazioniSulProgrammaToolStripMenuItem_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCanvas.Location = new System.Drawing.Point(5, 27);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(406, 363);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.picCanvas_Paint);
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // FinestraPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FinestraPrincipale";
            this.Text = "Arduino Plotter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
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
        private System.Windows.Forms.Button buttonConnetti;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem apriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaLineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaUltimaLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserisciLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminaLineaSelezionataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stampaProgettoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elencoLineeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpDisegnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpComandiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpCollegamentoStampanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informazioniSulProgrammaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottonePulisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottoneAnnullaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottoneInserisciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottoneEliminaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottoneStampaToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

