using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Weedeg;

namespace P05
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            /*int x = Convert.ToInt32(textBox1.Text);
            int zaokr;
            if (textBox2.Text != string.Empty)
            {
                int rad = Convert.ToInt32(textBox2.Text);
                zaokr = weedeg.Zaokrouhleni(x, rad);
            }
            else zaokr = weedeg.Zaokrouhleni(x);
            label1.Text = string.Format("Zaokrouhlení\n{0} ≐ {1}", x, zaokr);*/
            int size = Convert.ToInt32(textBox1.Text);
            double proportion = Convert.ToDouble(textBox2.Text);
            label1.Text = string.Format("" + Weedeg.MarginOfErrorProportion(size, proportion));
        }
    }
}
