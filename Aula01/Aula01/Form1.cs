namespace Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeUsuario; // declara��o variavel tipo string
            nomeUsuario = txtNome.Text;
            MessageBox.Show("Bem vindo ao C#" + nomeUsuario, "Ol�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblMenseger.Text = "Bem vindo ao C#" + nomeUsuario;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}