using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ladoX, ladoY, ladoZ;
            string triangulo;

            ladoX = double.Parse(lblX.Text);
            ladoY = double.Parse(lblY.Text);
            ladoZ = double.Parse(lblZ.Text);

            if (ladoY + ladoX > ladoZ && ladoY + ladoZ > ladoX && ladoX + ladoZ > ladoY) 
            {
                if (ladoX == ladoY && ladoY == ladoZ && ladoX == ladoZ)
                {
                    triangulo = "Equilátero";
                    MessageBox.Show($"O Triangulo é: {triangulo.ToString()}");
                } else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                {
                    triangulo = "Escaleno";
                    MessageBox.Show($"O Triangulo é: {triangulo.ToString()}");
                }
                else
                {
                    triangulo = "Isósceles";
                    MessageBox.Show($"O Triangulo é: {triangulo.ToString()}");
                }               
            }
            else
            {
                MessageBox.Show("Não forma Triângulo");
            }
        }
    }
}
