using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifEncadeado01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChecar_Click(object sender, EventArgs e)
        {
            int idade;

            idade = int.Parse(txtIdade.Text);

            if (idade < 16)
            {
                MessageBox.Show("Você não pode votar e nem embarcar! ", "ONG",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if(idade < 18)
            {
                MessageBox.Show("Voto Facultativo. Embarque permitido!", "ONG",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                MessageBox.Show("Voto obrigatorio. Embarque permitido!", "ONG",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
