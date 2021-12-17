using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_somatorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, soma = 0;

            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);

            if (n1 < n2)
            {
                for(int i = n1 + 1; i < n2; i++)
                {
                    soma = i + soma;
                }
                lblRes.Text = soma.ToString();
            }
            else
            {
                MessageBox.Show("O primeiro valor deve ser menor que o Segundo valor");
            }

        }
    }
}
