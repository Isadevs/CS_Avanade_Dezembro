using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exProposto03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verSaldo;
            double deposito = 0;
            double saque = 0;
            double saldo = 0;

            switch (txtBox.SelectedIndex)
            {
                case 0:
                    deposito = double.Parse(txtBox1.Text);
                    MessageBox.Show($" Seu saldo é de R${deposito}");
                    break;
                case 1:
                    deposito = double.Parse(txtBox1.Text);
                    saque = deposito - saque;
                    saldo = saque;
                    MessageBox.Show($"Seu saque R${saque} saldo é de R${saldo}");
                    break;
                case 2:
                    verSaldo = saldo + saque;
                    MessageBox.Show($"Seu saldo é de R${verSaldo}");
                    break;
                default:
                    MessageBox.Show("Opção Inválida");
                    break;
            }
        }
    }
}
