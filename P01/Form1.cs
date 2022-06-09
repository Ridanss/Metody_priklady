using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelVysledky1.Text = "Výsledky:\n";
            labelVysledky2.Text = "Slova:\n";
            labelVysledky1.Text = string.Format("String {0} číslice,\nPočet číslic: {1}\nSoučet lichých číslic: {2}", RetezecUtil.Retezec.Obsahuje(textBox1.Text, out int pocet_cislic, out int soucet_lichych) ? "obsahuje" : "neobsahuje", pocet_cislic, soucet_lichych);
            labelVysledky2.Text = string.Format("String {0} slova\nNejdelší slovo: {1}\nNejkratší slovo: {2}", RetezecUtil.Retezec.ObsahujeSlovo(textBox1.Text, out string nejdelsi, out string nejkratsi) ? "obsahuje" : "neobsahuje", nejdelsi, nejkratsi);
            bool alfanum = RetezecUtil.Retezec.JeAlfanum(textBox1.Text, out int male_pismena, out int cifer, out int jinych);
            labelVysledky3.Text = string.Format("String {0} alfanumerický\nPočet malých písmen: {1}\nPočet cifer: {2}\n", alfanum ? "je" : "není", male_pismena, cifer);
            if (!alfanum) labelVysledky3.Text += string.Format("Počet jiných znaků: {0}", jinych);
            RetezecUtil.Retezec.Zobraz(listBox1, RetezecUtil.Retezec.Smaz(textBox1.Text));
        }
    }
}
