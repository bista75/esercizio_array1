using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace esercizio_array1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n7_Click(object sender, EventArgs e)
        {
            string[] nomi = {"Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria"};
            for (int i = 0; i < nomi.Length; i++)
            {
                lst_nomi.Items.Add(nomi[i]);
            }
        }

        private void btn_n8_Click(object sender, EventArgs e)
        {
            int[] conti = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria" };
            for (int i = 0; i < nomi.Length; i++)
            {
                lst_nomi.Items.Add(nomi[i]);
            }
        }
    }
}
