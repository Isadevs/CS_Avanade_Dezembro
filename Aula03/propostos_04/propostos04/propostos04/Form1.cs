using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace propostos04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double aulasDadas, aulasAssistidas,frequencia, media, notaA, notaB;

            aulasDadas = double.Parse(txtAulasDadas.Text);
            aulasAssistidas = double.Parse(txtAulasAssistidas.Text);

            
            notaA = double.Parse(txtNotaA.Text);
            notaB = double.Parse(txtNotaB.Text);

            frequencia = (aulasAssistidas/aulasDadas)*100;

            media = (notaA + notaB)/2;

            if (frequencia >= 75 && media >= 7)
            {
                MessageBox.Show($"A média é {media.ToString("F2")} Você foi Aprovado");
            }
            else
            {
                MessageBox.Show("Você foi Reprovado");
            }
                    
        }
    }
}
