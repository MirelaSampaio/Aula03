namespace Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            string usuario;
            string senha;

            usuario = txtUsuario.Text;
            senha= txtSenha.Text;

            if (usuario == "Misa" && senha == "123") 
            {
                MessageBox.Show($"Seja bem vinda {usuario}!");
                panelSaldo.Visible = true;
                //panelSaldo.Show();

                //panelSaldo.Hide(); (( Para esconder. ))
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos.");
            }

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}