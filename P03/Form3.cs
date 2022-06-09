using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonExecute_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                int x = Convert.ToInt32(textBox1.Text);
                int n = Convert.ToInt32(textBox2.Text);
                labelVypsat.Text = string.Format(": {0} prvočíslo", MatematikaUtil.Matika.Prvocislo(x) ? "je" : "není");    
                for (int i = 0; i < n; i++)
                {
                    x++;
                }
                labelMocnina.Text = string.Format("Mocnina:\n{0}^{1} = {2}", x, n, MatematikaUtil.Matika.Mocnina(x, n));
            }
        }
    }
}
