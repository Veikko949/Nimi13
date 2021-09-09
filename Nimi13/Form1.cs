using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Nimi13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void takista_button_Click(object sender, EventArgs e)
        {
            vastaus_label.Text = "";
            vastaus_label.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\veikko.pihlajamaa\\source\\repos\\nimet\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\veikko.pihlajamaa\\source\\repos\\nimet\\tytot.txt");
            string nimi = nimi_textBox.Text;
            int laskripo = 1, laskurity = 1;
            foreach(string poju in pojat)
            {
                if(nimi == poju)
                {
                    vastaus_label.Text = "Nimesi on " + laskripo + ". suisituin poikien nimi vuonna 2020";
                    vastaus_label.Visible = true;
                }
                laskripo++;
            }
            foreach (string tyt in tytot)
            {
                if(nimi == tyt)
                {
                    vastaus_label.Text = "Nimesi on " + laskurity + ". suisituin poikien nimi vuonna 2020";
                    vastaus_label.Visible = true;
                }
                laskurity++;
            }
            if (vastaus_label.Visible == false)
            {
                vastaus_label.Text = "Nimesi ei löytynyt suisituimpien nimien joukosta!";
                vastaus_label.Visible = true;
            }

        }
    }
}
