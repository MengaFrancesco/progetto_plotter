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

        private void buttonAnnulla_Click(object sender, EventArgs e)
        {
            this.Close(); //Chiude la finestra
        }

        private void buttonInserisci_Click(object sender, EventArgs e)
        {
            this.SetVisibleCore(false);
        }
    }
}
