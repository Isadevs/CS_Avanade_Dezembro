using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace matrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[4, 4];
            int sumLinha = 0;
            int linhaLoc = 0;
            double media = 0;
            double sumMedia = 0;
            double multi = 0;


            //Percorrendo o vetor;
            for (int linha = 0; linha < 4; linha++)
            {  
                for(int coluna = 0; coluna < 4; coluna++)
                {
                    linhaLoc = linha + 1;
                    matriz[linha, coluna] = int.Parse(Interaction.InputBox("Digite um valor para a "+ linhaLoc.ToString()));
                }           
            }

            //somar o vetor
            for (int linha = 0; linha < 1; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    sumLinha = matriz[linha, coluna] + sumLinha;
                }
                ltlBox.Items.Add("A Soma da Linha 1 = " + sumLinha.ToString());
            }

            //media do vetor
            for(int linha = 1; linha <= 1; linha++)
            {
                for(int coluna = 0; coluna < 4; coluna++)
                {
                    sumMedia = (double) matriz[linha,coluna] + sumMedia;
                    media = sumMedia / 4;
                }
               ltlBox.Items.Add("A média da Linha 2 = " + media.ToString("F2"));
            }

            //multiplicação linha 3 com o da mesma coluna linha 4
            for (int linha = 2; linha <=2; linha++)
            {
                for (int coluna = 0; coluna < 4; coluna++)
                {
                    int LocLinha = coluna + 1;
                    multi = matriz[linha, coluna] * matriz[3, coluna];
                    ltlBox.Items.Add($"Multiplicação da {LocLinha}ª Coluna: {multi.ToString()}");
                    multi = 0;
                }          
            }

        }
    }
}
