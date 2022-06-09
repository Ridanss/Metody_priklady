using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        static public bool jeDokonale(int value, out int nejmensiD, out int nejvetsiD)
        {
            nejmensiD = 1;
            nejvetsiD = 1;
            int dokonale = 1;
            for (int del = 2; del < value; del++)
            {
                if (value % del == 0)
                {
                    dokonale += del;
                    if (nejmensiD == 1) nejmensiD = del;
                    if (del != value) nejvetsiD = del;  
                }
            }
            if (value == dokonale) return true;
            else return false;
        }

        static public void Vymena(int[] pole)
        {
            int sudI = -1;
            int druhyNejvetsiI = -1;
            int max = int.MinValue;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    druhyNejvetsiI = Array.IndexOf(pole, max);
                    max = pole[i];
                }
                if (pole[i] % 2 == 0 && sudI < 0) sudI = i;
            }
            (pole[druhyNejvetsiI], pole[sudI]) = (pole[sudI], pole[druhyNejvetsiI]);
        }

        static public void Vypis(ListBox ctrl, int[] pole)
        {
            foreach(int value in pole)
            {
                ctrl.Items.Add(value);
            }
        }

        static public bool Obsahuje(char[] znaky, string chain)
        {
            string[] newchain = chain.Split(' ');
            foreach(string value in newchain)
            {
                if (value.Contains(znaky[0]) && value.Contains(znaky[1]) && value.Contains(znaky[2]))
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBoxN.Text);
            int[] pole = PoleUtil.Pole.Generace(n, 5, 126);
            Vypis(listBox1, pole);
            foreach(int value in pole)
            {
                jeDokonale(value, out int mensi, out int vetsi);    
            }
        }
    }
}
