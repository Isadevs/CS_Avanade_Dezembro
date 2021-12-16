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

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double media,notaA,notaB,notaC;
            string situacao

            //leitura de dados:
            notaA = double.Parse(lblNotaA.Text);
            notaB = double.Parse(lblNotaB.Text);
            notaC = double.Parse(lblNotaC.Text);

            //Efetuando qualquer calculo:
            media = (notaA + notaB + notaC) / 3;

            if (media < 4)
            {
                situacao = "Reprovado";
            } else if(media >= 7 )
            {
                situacao = "Aprovado";
            }
            else
            {
                situacao = "Em prova final";
            }
                
             MessageBox.Show($"Media: {media.ToString("F2")}\n Situação: {situacao}", 
                 "Média Escolar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        } 
    }
}
