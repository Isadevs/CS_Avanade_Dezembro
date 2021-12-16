using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exProposto04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            double saldo, credito;


            saldo = double.Parse(txtSaldoMedio.Text);

            if( saldo <= 200)
            {
                credito = 0;
            }
            else if (saldo <= 400)
            {
                credito = saldo * 0.20;
            }
            else if (saldo <= 600)
            {
                credito = saldo * 0.3;
            }
            else
            {
                credito = saldo * 0.4;
            }

            lblcred.Text = $"Seu credito: R${credito.ToString("F2")}";
        }
    }
}
