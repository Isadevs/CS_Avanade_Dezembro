using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exProp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConversor_Click(object sender, EventArgs e)
        {
            //declarando variaveis
            double doacaoDolar, res;
            
            //entrada de dados
            doacaoDolar = Convert.ToDouble(txtValDolar.Text);

            //efetuando o calculo
            res = doacaoDolar * 5.62;

            //exibindo resultado convertido em string
            lblRes.Text = "USD $ " + res.ToString("F2");
        }

        private void txtValDolar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
