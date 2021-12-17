using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fatorial, multi = 0, i, value;

            fatorial = int.Parse(txtBox.Text);
            value = fatorial;
            i = fatorial;

            while(i > 1)
            {
                i--;
                multi = value * i;
                value = multi;
            }

            lblRes.Text = multi.ToString();
        }
    }
}
