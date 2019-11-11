using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace ProgettoPlotter
{





    public partial class Form1 : Form
    {
        
        private CLinea temp;        //Linea temporanea
        private CVettore vettore;   //Vettore di linee
        private int numLinee;       //Numero di linee attuali
        private String COM;         //Porta seriale

        //Costruttore
        public Form1() 
        {
            InitializeComponent();
            CenterToScreen(); //Imposta la finestra al centro

            comboBoxCOM.SelectedIndex = 0; //Imposta il primo elemento della combobox di default
            buttonDisconnetti.Enabled = false; //Bottone inizialmente disabilitato

            COM = "COM1"; //Porta seriale di default: COM1

            temp = new CLinea();
            vettore = new CVettore(); //Inizializza vettore di linee
        }

        //Inizializza lista di segmenti e il nuovo segmento
        private List<Segment> Segments = new List<Segment>();
        private Segment NewSegment = null;

        

        // Inizia a disegnare un nuovo segmento.
        private void picCanvas_MouseDown(object sender, MouseEventArgs e)
        {

            NewSegment = new Segment(Pens.Blue, e.Location, e.Location);
            picCanvas.Refresh();

            
            temp.setP1(NewSegment.Point1); //Imposta il punto di partenza
        }

        // Continua a disegnare il segmento.
        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (NewSegment == null) return;

            NewSegment.Point2 = e.Location;
            picCanvas.Refresh();
        }

        // Finisce di disegnare i segmenti
        private void picCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (NewSegment == null) return;

            NewSegment.Pen = Pens.Black;
            Segments.Add(NewSegment);
            
            temp.setP2(NewSegment.Point2); //Imposta il punto di arrivo

            NewSegment = null;
            picCanvas.Refresh();


            //Controlla se la x2 esce dall'area di disegno
            if (temp.getX2() > 363) temp.setX2(363);
            else if (temp.getX2()<0) temp.setX2(0);
            /* Altrimenti valore corretto */

            //Controlla se la y2 esce dall'area di disegno
            if (temp.getY2() > 270) temp.setY2(270);
            else if (temp.getY2() < 0) temp.setY2(0);
            /* Altrimenti valore corretto */


            vettore.push(temp); //Inserisce linea nel vettore
            numLinee++;         //Incrementa numero linee

            visualizzaLista();  //Aggiorna la lista

            temp = new CLinea(); //Inizializza prossima linea
        }

        // Disegna i segmenti
        private void picCanvas_Paint(object sender, PaintEventArgs e)
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


        //OPERAZIONI DA ESEGUIRE CON I BOTTONI

        //Bottone PULISCI
        private void buttonPulisci_Click(object sender, EventArgs e)
        {

            
            Segments.Clear(); //Rimuove tutti i semgenti creati
            picCanvas.Refresh(); //Aggiorna la tavoletta di disegno

            listBoxLinee.Items.Clear(); //Pulisce la lista
            vettore = new CVettore(); //Reset Vettore

            numLinee = 0; //Reimposta numero linee

            MessageBox.Show("L'area di disegno è stata pulita con successo.", "Esito pulizia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Bottone ANNULLA
        private void button1_Click(object sender, EventArgs e)
        {
            if (numLinee>0) //Se c'è almeno una linea
            {
                //Elimina ultimo segmento
                Segments.RemoveAt(Segments.IndexOf(Segments.Last()));

                picCanvas.Refresh();
                vettore.pop();
                numLinee--;
                visualizzaLista();
            }
            else //Altrimenti messaggio di errore
            {
                MessageBox.Show("Nessuna sono ancora state disegnate linee.", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //Bottone ELIMINA
        private void buttonElimina_Click(object sender, EventArgs e)
        {
            //Calcola qual'è l'elemento selezionato
            String s = listBoxLinee.SelectedIndex.ToString();
            int elemento = int.Parse(s); //Converte in intero

            if (elemento!=-1) //Se linea selezionata
            {
                vettore.shiftSx(elemento); //Elimina linea dal vettore
                numLinee--;                //Decrementa numero linee
                visualizzaLista();         //Aggiorna lista

                Segments.RemoveAt(elemento); //Rimuove segmento
                picCanvas.Refresh();         //Aggiorna tavoletta grafica
            }
            else //Altrimenti nessuna linea selezionata
            {
                MessageBox.Show("Nessuna linea selezionata.", "ATTENZIONE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        //Bottone INSERISCI (da finire)
        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            //Apre un pop up

            //Richiede parametri dal pop up

            //Aggiunge linea manualmente


            Input input = new Input();
            
            input.Visible = true;
            
        }

        //Bottone CONNETTI (da finire)
        private void buttonConnetti_Click(object sender, EventArgs e)
        {
            buttonConnetti.Enabled = false; //Disabilita bottone connetti
            buttonDisconnetti.Enabled = true; //Abilita bottone disconnetti
        }

        //Bottone DISCONNETTI (da finire)
        private void buttonDisconnetti_Click(object sender, EventArgs e)
        {
            buttonConnetti.Enabled = true; //Abilita bottone connetti
            buttonDisconnetti.Enabled = false; //Disabilita bottone disconnetti
        }




        //BOTTONI HELP:

        //Visualizza pop up contenente info sul bottone pulisci
        private void buttonInfoPulisci_Click(object sender, EventArgs e)
        {
            //Creazione stringa da visualizzare
            String info = "Il bottone \"pulisci\" elimina tutte le linee che sono state disegnate, infine pulisce l'area di disegno.";
            //Visualizza pop up
            MessageBox.Show(info, "Help", MessageBoxButtons.OK , MessageBoxIcon.Question);
        }

        //Visualizza pop up contenente info sul bottone annulla
        private void buttonInfoAnnulla_Click(object sender, EventArgs e)
        {
            //Creazione stringa da visualizzare
            String info = "Il bottone \"elimina\" l'ultima linea disegnata e la rimuove dall'area di disegno.";
            //Visualizza pop up
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //Visualizza pop up contenente info sul bottone stampa
        private void buttonInfoStampa_Click(object sender, EventArgs e)
        {
            //Creazione stringa da visualizzare
            String info = "Il bottone \"stampa\" invia il disegno al plotter, per eseguire la stampa.";
            
            //Visualizza pop up
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        //Visualizza pop up contenente info sul bottone inserisci
        private void buttonInfoInserisci_Click(object sender, EventArgs e)
        {
            //Creazione stringa da visualizzare
            String info = "Il bottone \"inserisci\" apre una finestra per impostare e inserire una nuova linea.";

            //Visualizza pop up
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }

        //Visualizza pop up contenente info sul bottone elimina
        private void buttonInfoElimina_Click(object sender, EventArgs e)
        {
            //Creazione stringa da visualizzare
            String info = "Il bottone \"elimina\" rimuove dalla lista dall'area di disegno la linea selezionata.";

            //Visualizza pop up
            MessageBox.Show(info, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }



        //COMBO BOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            COM = "COM" + comboBoxCOM.SelectedIndex + 1; //Imposta COM = COM + nPorta
        }



        //METODI EXTRA

        //Metodo locale che aggiorna la lista
        private void visualizzaLista()
        {
            //Visualizza ogni linea nella lista
            listBoxLinee.Items.Clear(); //Pulisce la lista

            for (int i = 0; i < numLinee; i++)
            {
                listBoxLinee.Items.Add("Linea " + (i + 1) + ":  " + vettore.toString(i)); //Aggiunge informazioni alla lista
            }
        }


        //TO DO : controlli sul range della linea che non deve uscire dall'area di disegno
    }
}

