using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_lacoRepeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerTabuada_Click(object sender, EventArgs e)
        {
           ltsTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(lblTabuada.Text);

            while(cont <= 10)
            {
                res = num * cont;
                ltsTabuada.Items.Add(res.ToString());
                cont++;
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            ltsTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(lblTabuada.Text);

            do 
            {
                res = num * cont;
                ltsTabuada.Items.Add(res.ToString());
                cont++;
            }while(cont <= 10);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {

            ltsTabuada.Items.Clear();
            int num, res;
            int cont = 1;

            num = int.Parse(lblTabuada.Text);

            for (cont = 1; cont <= 10; cont++) 
            {
                res = num * cont;
                ltsTabuada.Items.Add(res.ToString());
            }  
        }
    }
}
