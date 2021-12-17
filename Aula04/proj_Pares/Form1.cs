using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_Pares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, value ;

            n1 = int.Parse(txtNum1.Text);
            n2 = int.Parse(txtNum2.Text);
            int cont = n1+1;
            int i = 0;

            if(n1 < n2)
            {

                do
                {
                    if(cont % 2 == 0)
                    {
                        i++;
                    }
                    cont++;
                } while (cont < n2);
                
                txtRes.Text = i.ToString();
            }
            else
            {
                MessageBox.Show("O primeiro Número deve ser Menor que o Segundo");
            }
        }
    }
}
