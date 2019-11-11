using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPlotter
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
            CenterToScreen(); //Imposta la finestra al centro
           
        }




        //Bottone ANNULLA
        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close(); //Chiude la finestra
        }

        //Bottone INSERISCI
        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }

        
        //Bottone INFO
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
