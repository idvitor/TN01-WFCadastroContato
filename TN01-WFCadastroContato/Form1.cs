namespace TN01_WFCadastroContato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string telefone = mkdTelefone.Text;
            string email = txtEmail.Text.ToString();
            string tipoTelefone = "";

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sobrenome) || string.IsNullOrEmpty(telefone) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Preencha todos os campos antes de salvar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rdbPessoal.Checked)
            {
                tipoTelefone = "Pessoal";
            }
            else if (rdbComercial.Checked)
            {
                tipoTelefone = "Comercial";
            }
            else if (rdbRecado.Checked)
            {
                tipoTelefone = "Recado";
            }
            if (string.IsNullOrEmpty(tipoTelefone))
            {
                MessageBox.Show("Selecione um tipo de Telefone!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            MessageBox.Show($"O contato salvo: \nNome: {nome} {sobrenome} \nTelefone: {telefone}\nEmail: {email}\nTipo: {tipoTelefone}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
