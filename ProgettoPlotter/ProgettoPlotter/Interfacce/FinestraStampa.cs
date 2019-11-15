using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPlotter.Interfacce
{
    public partial class FinestraStampa : Form
    {
        

        public FinestraStampa()
        {
            InitializeComponent();
            Visible = true;
            CenterToScreen(); //Imposta la finestra al centro

            listBox1.Items.Clear();
            
        }

      
        //Inserisce elemento e aggiorna progress bar
        public void inserisciElemento(String elemento, int valoreBarra)
        {
            
            impostaValoreBarra(valoreBarra);
            listBox1.Items.Add(elemento);

            scrollDown();
        }

        //Imposta valore della progress bar
        public void impostaValoreBarra(int valore)
        {
            progressBar1.Value = valore;
        }

        public void scrollDown()
        {
            //Esegue scroll verso il basso
            int visibleItems = listBox1.ClientSize.Height / listBox1.ItemHeight;
            listBox1.TopIndex = Math.Max(listBox1.Items.Count - visibleItems + 1, 0);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }
    }
}
