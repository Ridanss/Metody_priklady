using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonExecuteAll_Click(object sender, EventArgs e)
        {
            labelModified.Text = "úprava: ";
            labelDisolved.Text = "rozklad na provčísla 1. čísla: ";
            label4NsnNsd.Text = "NSN NSD: ";
            string chain = textBox1.Text;
            Vymyšlené_metody.Metody.vymaz_vsech_pismen_A(ref chain);
            labelModified.Text += chain;
            if (textBox2.Text != string.Empty && textBox3.Text != string.Empty)
            {
                int a = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);
                bool first = true;
                foreach(int value in Vymyšlené_metody.Metody.rozklad_na_prvocislo(a))
                {
                    if (!first) labelDisolved.Text += ", ";
                    labelDisolved.Text += value;
                    first = false;
                }
                label4NsnNsd.Text += "\nNSD: " + Vymyšlené_metody.Metody.nejvetsi_spolecny_delitel_nejmensi_spolecny_nasobek(a, b, out int nsn) + "\nNSN: " + nsn;
            }
        }
    }
}
