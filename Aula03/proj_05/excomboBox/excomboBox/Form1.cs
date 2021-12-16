using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excomboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            switch (cmbEscolha.SelectedIndex) //índice selecionado da lista
            {
                case 0:
                    MessageBox.Show("Você selecionou a Equipe Ferrari.");
                    break;
                case 1:
                    MessageBox.Show("Você selecionou a Equipe Mercedes.");
                    break;
                case 2:
                    MessageBox.Show("Você selecionou a Equipe RedBull.");
                    break;
                case 3:
                    MessageBox.Show("Você selecionou a Equipe McLaren.");
                    break;
                default:
                    MessageBox.Show("Selecione uma equipe:");
                    break;
            }
        }
    }
}
