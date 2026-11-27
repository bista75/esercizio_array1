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

       

        private void btn_n8_Click(object sender, EventArgs e)
        {

            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria" };
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            for (int i = 0; i < conti.Length; i++)
            {
                lst_conti.Items.Add(conti[i]);
                lst_nomi.Items.Add(nomi[i]);
                lst_saldi.Items.Add(saldi[i]);
            }
            btn_n8.Enabled = false; 
        }

       

        private void btn_n1_Click(object sender, EventArgs e)
        {

            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria" };
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            //lst_risultati.Items.Clear();
            string contoCercato = txt_n1.Text.Trim();
            bool trovato = false;

            for (int i = 0; i < conti.Length; i++)
            {
                if (conti[i] == contoCercato)
                {
                    if (!lst_risultati.Items.Contains($"{nomi[i]}, {saldi[i]}"))
                    {
                        lst_risultati.Items.Add($"{nomi[i]}, {saldi[i]}");
                        trovato = true;
                    }
                    
                    
                }
                txt_n1.Clear();
                if (!trovato)
                {
                    MessageBox.Show("Attenzione! Non esiste un cliente con questo nome");
                    txt_n1.Clear();
                    return;

                }
                btn_n8.Enabled = false;

            }
           

        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria" };
            string[] conti = { "11264", "99780", "00342", "03419", "34562", "09887", "02341" };
            //lst_risultati.Items.Clear();
            string nomeCercato = txt_n2.Text.Trim();
            bool trovato = false;

            for (int i = 0; i < nomi.Length; i++)
            {
                if (nomi[i] == nomeCercato)
                {
                    if (!lst_risultati.Items.Contains($"{conti[i]}, {saldi[i]}"))
                    {
                        lst_risultati.Items.Add($"{conti[i]}, {saldi[i]}");
                        trovato = true;
                    }
                }

            }
            txt_n2.Clear();
            if (!trovato)
            {
                MessageBox.Show("Attenzione! Non esiste un cliente con questo nome");
                txt_n1.Clear();
                return;

            }
            btn_n8.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria" };

            for (int i = 0; i < nomi.Length; i++)
            {
                if (saldi[i] < 0)
                {
                    lst_risultati.Items.Add(nomi[i]);
                }

            }



        }

        private void btn_n4_Click(object sender, EventArgs e)
        {
            int[] saldi = { 11534, -2345, 3451, 127, 45673, -13, 3452 };
            double max = saldi[0];
            int indicemax = 0;
            string[] nomi = { "Rossi Mario", "Bianchi Luigi", "Belli Giulia", "Dotti Fabio", "Merli Gianni", "Zeri Giulio", "Botti Maria" };


            for (int i = 0; i < saldi.Length; i++)
            { 
                if (saldi[i] > max)
                {
                    max = saldi[i];
                    indicemax = i;
                   
                }

            }

            lst_risultati.Items.Add(nomi[indicemax]);


        }

        private void btn_n5_Click(object sender, EventArgs e)
        {

        }
    }
}
