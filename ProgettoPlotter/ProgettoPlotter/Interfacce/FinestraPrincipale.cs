using ProgettoPlotter.Interfacce;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoPlotter
{





    public partial class FinestraPrincipale : Form
    {

        private CLinea temp;        //Linea temporanea
        private CVettore segmenti;  //Vettore di linee
        private int numLinee;       //Numero di linee attuali
        private SerialPort COM;     //Porta seriale
        private string portaCOM;    //Porta com

        

        private List<Segment> Segments = new List<Segment>(); //Vettore di segmenti
        private Segment NewSegment = null;                    //Ultimo segmento disegnato


        public FinestraPrincipale() //Costruttore 
        {
            InitializeComponent();
            CenterToScreen(); //Imposta la finestra al centro

            comboBoxCOM.SelectedIndex = 0; //Imposta il primo elemento della combobox di default
            

            CheckForIllegalCrossThreadCalls = false;

            temp = new CLinea();
            segmenti = new CVettore(); //Inizializza vettore di linee

            //COM.DataReceived += new
            //SerialDataReceivedEventHandler(COM_DataReceived);

            try
            {
                COM = new SerialPort("COM1", 9600); //Prova a inizializzare sulla porta 1
                COM.Open();

            }
            catch (Exception) { } //Eccezione

            portaCOM = "COM1"; //Inizializza la porta com

        } 
        

        //TAVOLETTA GRAFICA
        private void picCanvas_MouseDown(object sender, MouseEventArgs e) // Inizia a disegnare un nuovo segmento.
        {

            NewSegment = new Segment(Pens.Blue, e.Location, e.Location);
            picCanvas.Refresh();


            temp.setP1(NewSegment.Point1); //Imposta il punto di partenza
        } 
        private void picCanvas_MouseMove(object sender, MouseEventArgs e) // Continua a disegnare il segmento.
        {
            if (NewSegment == null) return;

            NewSegment.Point2 = e.Location;
            picCanvas.Refresh();
        } 
        private void picCanvas_MouseUp(object sender, MouseEventArgs e)  // Finisce di disegnare i segmenti
        {
            if (NewSegment == null) return;

            NewSegment.Pen = Pens.Black;
            Segments.Add(NewSegment);

            temp.setP2(NewSegment.Point2); //Imposta il punto di arrivo

            NewSegment = null;
            picCanvas.Refresh();


            checkLines();

            segmenti.push(temp); //Inserisce linea nel vettore
            numLinee++;         //Incrementa numero linee

            visualizzaLista();  //Aggiorna la lista

            temp = new CLinea(); //Inizializza prossima linea
        }
        private void picCanvas_Paint(object sender, PaintEventArgs e) // Disegna i segmenti
        {
            e.Graphics.Clear(picCanvas.BackColor);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Disegna i segmenti esistenti
            foreach (Segment segment in Segments)
                segment.Draw(e.Graphics);

            //Se c'è un nuovo segmento lo disegna
            if (NewSegment != null)
                NewSegment.Draw(e.Graphics);
        }


        //BOTTONI DI MODIFICA   
        private void buttonPulisci_Click(object sender, EventArgs e)    //Bottone PULISCI
        {
            pulisci(); //Richiama metodo che pulisce la tavoletta grafica
        }      
        private void button1_Click(object sender, EventArgs e)          //Bottone ANNULLA
        {
            annulla(); //Richiama metodo annulla
        }            
        private void buttonElimina_Click(object sender, EventArgs e)    //Bottone ELIMINA
        {
            elimina(); //Richiama metodo che elimina linea selezionata
        }      
        private void buttonInserisci_Click(object sender, EventArgs e)  //Bottone INSERISCI (da finire)
        {
            inserisci(); //Richiama metodo per inserire una linea
        }
        private void buttonStampa_Click(object sender, EventArgs e)     //Bottone STAMPA 
        {
            stampa(); //Richiama metodo per la stampa
        }
        
        
        //METODI PER MODIFICA TAVOLETTA GRAFICA
        private void pulisci()
        {
            Segments.Clear();                                                   //Rimuove tutti i semgenti creati
            picCanvas.Refresh();                                                //Aggiorna la tavoletta di disegno

            listBoxLinee.Items.Clear();                                         //Pulisce la lista
            segmenti = new CVettore();                                           //Reset Vettore

            numLinee = 0;                                                       //Reimposta numero linee

            MessageBox.Show("L'area di disegno è stata pulita con successo.",   //Visualizza messaggio
                "Esito pulizia",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

           
        }
        private void annulla()
        {
            if (numLinee > 0) //Se c'è almeno una linea
            {
                

                Segments.RemoveAt(Segments.IndexOf(Segments.Last()));           //Elimina ultimo segmento disegnato
                picCanvas.Refresh();                                            //Aggiorna la tavoletta grafica
                segmenti.pop();                                                  //Rimuove ultima linea
                numLinee--;                                                     //Decrementa numero linee
                visualizzaLista();

                //Aggiorna la lista

                
                

            }
            else                                                                //Altrimenti messaggio di errore
            {
                MessageBox.Show("Nessuna sono ancora state disegnate linee.",
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void elimina()
        {
            String s = listBoxLinee.SelectedIndex.ToString();       //Calcola elemento selezionato
            int elemento = int.Parse(s);                            //Converte in intero

            if (elemento != -1)                                     //Controla se una linea è selezionata
            {
               

                segmenti.shiftSx(elemento);                          //Rimuove linea dalla lista
                numLinee--;                                         //Decrementa linee della lista
                visualizzaLista();                                  //Aggiorna lista di linee

                Segments.RemoveAt(elemento);                        //Rimuove segmento
                picCanvas.Refresh();                                //Aggiorna tavoletta grafica
            }
            else                                                    //Altrimenti nessuna linea selezionata
            {
                MessageBox.Show("Nessuna linea selezionata.",       //Crea e visualizza pop up di errore
                    "ATTENZIONE!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
        private void inserisci()
        {
            //Apre un pop up

            //Richiede parametri dal pop up

            //Aggiunge linea manualmente


            Input input = new Input();

            input.Visible = true;
        }
        private void stampa() 
        {
            if (COM.IsOpen) //Se è collegato alla seriale
            {
                FinestraStampa f1 = new FinestraStampa();
                f1.Visible = true;

                int count = 0;

                foreach (Segment segment in Segments) //Per ogni linea da disegnare (foreach=per ogni)
                {
                    String spostati = "G0 X" + segment.Point1.X + " Y" + segment.Point1.Y; //G0 X1 Y1
                    COM.Write(spostati); //Scrive sulla serial

                    String disegna = "G1 X" + segment.Point2.X + " Y" + segment.Point2.Y;  //G1 X2 Y2
                    COM.Write(disegna); //Scrive sulla serial  

                    f1.inserisciElemento("Linea "+ (count+1) + ":  " + segmenti.toString(count), (100 / numLinee) * (count + 1));

                    count++;

                    
                }

                f1.impostaValoreBarra(100);
            }
            else
                visualizzaMessaggioInfo("Non sei collegato a nessuna porta seriale");
        }


        //METODI CONNESSIONE CON ARDUINO
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            portaCOM = comboBoxCOM.SelectedItem.ToString();
        }
        private void buttonConnetti_Click(object sender, EventArgs e)    //Bottone CONNETTI (da finire)
        {
            try //Prova a connettersi alla porta COM
            {
                if (COM.IsOpen)
                {
                    COM.Close();
                }
                COM = new SerialPort(portaCOM, 9600, Parity.None, 8, StopBits.One);
                COM.Open();
                visualizzaMessaggioInfo("Connessione a " + comboBoxCOM.SelectedItem.ToString() + " riuscita");
            }
            catch (Exception)
            {

                visualizzaMessaggioInfo("Nessun dispositivo collegato alla porta " + portaCOM); 
            }
           

            

        }     
        

        //BOTTONI INFO
        private void buttonInfoPulisci_Click(object sender, EventArgs e)   //Visualizza pop up contenente info sul bottone PULISCI
        {
            infoPulisci(); //Richiama metodo che visualizza le info
        }
        private void buttonInfoAnnulla_Click(object sender, EventArgs e)   //Visualizza pop up contenente info sul bottone ANNULLA
        {
            infoAnnulla();
        }
        private void buttonInfoStampa_Click(object sender, EventArgs e)    //Visualizza pop up contenente info sul bottone STAMPA
        {
            infoStampa();
        }
        private void buttonInfoInserisci_Click(object sender, EventArgs e) //Visualizza pop up contenente info sul bottone INSERISCI
        {
            infoInserisci();
        }
        private void buttonInfoElimina_Click(object sender, EventArgs e)   //Visualizza pop up contenente info sul bottone ELIMINA
        {
            infoElimina();
        }


        //METODI PER VISUALIZZARE INFO
        private void infoPulisci()
        {
            String info = "Il bottone \"pulisci\" elimina tutte le linee che sono state disegnate, infine pulisce l'area di disegno.";
            visualizzaMessaggioInfo(info); //Visualizza popup
        }
        private void infoAnnulla()
        {
            String info = "Il bottone \"elimina\" l'ultima linea disegnata e la rimuove dall'area di disegno.";
            visualizzaMessaggioInfo(info); //Visualizza popup
        }
        private void infoStampa()
        {
            String info = "Il bottone \"elimina\" l'ultima linea disegnata e la rimuove dall'area di disegno.";
            visualizzaMessaggioInfo(info); //Visualizza popup
        }
        private void infoInserisci()
        {
            String info = "Il bottone \"inserisci\" apre una finestra per impostare e inserire una nuova linea.";
            visualizzaMessaggioInfo(info); //Visualizza popup
        }
        private void infoElimina()
        {
            String info = "Il bottone \"elimina\" rimuove dalla lista dall'area di disegno la linea selezionata.";
            visualizzaMessaggioInfo(info); //Visualizza popup
        }
        private void visualizzaMessaggioInfo(String info) //Riceve un testo e visualizza il pop up
        {
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }


        //METODI LISTA LINEE
        private void visualizzaLista() //Aggiorna la lista di linee
        {
            //Visualizza ogni linea nella lista
            listBoxLinee.Items.Clear(); //Pulisce la lista

            for (int i = 0; i < numLinee; i++)
                listBoxLinee.Items.Add("Linea " + (i + 1) + ":  " + segmenti.toString(i)); //Aggiunge informazioni alla lista

            int visibleItems = listBoxLinee.ClientSize.Height / listBoxLinee.ItemHeight;
            listBoxLinee.TopIndex = Math.Max(listBoxLinee.Items.Count - visibleItems + 1, 0);
            listBoxLinee.TopIndex = listBoxLinee.Items.Count - 1;
        }
        private void checkLines() //Controlla se le linee escono dalla tavoletta grafica
        {

            if (temp.getX2() > picCanvas.Size.Width) temp.setX2(picCanvas.Size.Width);
            else if (temp.getX2() < 0) temp.setX2(0);



            if (temp.getY2() > picCanvas.Size.Height) temp.setY2(picCanvas.Size.Height);
            else if (temp.getY2() < 0) temp.setY2(0);

        }


        //MENU':

        //SEZIONE FILE
        

        //SEZIONE MODIFICA
        private void eliminaLineeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pulisci();
        }
        private void eliminaUltimaLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            annulla();
        }
        private void inserisciLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inserisci();
        }
        private void eliminaLineaSelezionataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            elimina();
        }
        private void stampaProgettoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stampa();
        }


        //SEZIONE VISUALIZZA
        private void elencoLineeToolStripMenuItem_Click(object sender, EventArgs e) //Crea stringa con formattazione delle linee e visualizza
        {
            String s = segmenti.toString(); //Riceve info dal vettore
            MessageBox.Show(s, "Elenco delle linee", MessageBoxButtons.OK, MessageBoxIcon.Information); //Visualizza pop up
        }


        //SEZIONE HELP

        //Help bottoni: visualizza info sui bottoni
        private void bottonePulisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoPulisci(); //Visualizza pop up
        }
        private void bottoneAnnullaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoAnnulla(); //Visualizza pop up
        }
        private void bottoneInserisciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoInserisci(); //Visualizza pop up
        }
        private void bottoneEliminaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoElimina(); //Visualizza pop up
        }
        private void bottoneStampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoStampa(); //Visualizza pop up
        }
        
        //Informazioni aggiuntive
        private void informazioniSulProgrammaToolStripMenuItem_Click(object sender, EventArgs e) //Visualizza informazioni sul programma
        {
            //Visualizza messaggio con le informazioni sugli autori
            String info = "Programma creato da:\nMenga Francesco e Delogu Gabriele\nIl programma è coperto da Copyright secondo gli articoli 11 e 13";
            MessageBox.Show(info, "Informazioni creatori", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
        private void helpCollegamentoStampanteToolStripMenuItem_Click(object sender, EventArgs e) //Visualizza info sul collegamento COM
        {
            String info = "Per connettersi alla stampante selezionare dalla lista \"COM\" la porta seriale corretta e premere \"CONNETTI\"";
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        



        //ToDo : finire il menù
        //ToDo : aggiungere finestra che visualizza la stampa
    }
}

