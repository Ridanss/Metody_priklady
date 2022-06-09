using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            labelVysl1.Text = "Výsledky:\n";
            int N = Convert.ToInt32(textBoxN.Text);
            if (textBoxN.Text != string.Empty)
            {
                int[] pole;
                if (checkBoxDefault.Checked)
                {
                    pole = PoleUtil.Pole.Generovani(N);
                    labelVysl1.Text += string.Format("Pole {0} rostoucí\n", PoleUtil.Pole.Roustouci(pole) ? "je" : "není");
                    labelVysl1.Text += string.Format("Součet sudých čísel: {0}\nPočet lichých čísel: {1}\n", PoleUtil.Pole.SoucetAPocet(out int lichych, pole), lichych);
                    PoleUtil.Pole.Zobrazit(listBox1, pole);
                    PoleUtil.Pole.Vymena(pole);
                    int[] polenew = PoleUtil.Pole.VynulovaniAMocnina(pole, 2);
                    PoleUtil.Pole.Zobrazit(listBox2, polenew);
                }
                else
                {
                    if (textBoxMax.Text != string.Empty && textBoxMin.Text != string.Empty)
                    {
                        int max = Convert.ToInt32(textBoxMax.Text);
                        int min = Convert.ToInt32(textBoxMin.Text);
                        pole = PoleUtil.Pole.Generovani(N, min, max);
                        labelVysl1.Text += string.Format("Pole {0} rostoucí\n", PoleUtil.Pole.Roustouci(pole) ? "je" : "není");
                        labelVysl1.Text += string.Format("Součet sudých čísel: {0}\nPočet lichých čísel: {1}\n", PoleUtil.Pole.SoucetAPocet(out int lichych, pole), lichych);
                        PoleUtil.Pole.Zobrazit(listBox1, pole);
                        PoleUtil.Pole.Vymena(pole);
                        int[] polenew = PoleUtil.Pole.VynulovaniAMocnina(pole, 2);
                        PoleUtil.Pole.Zobrazit(listBox2, polenew);
                    }
                    else labelVysl1.Text = "Nevyplněné proměné!";
                }
            }
            else labelVysl1.Text = "Nevyplněné proměné!";   
        }
    }
}
