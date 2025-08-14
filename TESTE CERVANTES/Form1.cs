using TESTE_CERVANTES.Repositories;

namespace TESTE_CERVANTES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var pessoaRepository = new PessoaRepository();
            BuscarTodasAsPessoas(pessoaRepository);
        }

        private void LimparCampos()
        {
            txtID.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtIdade.Text = string.Empty;
        }

        private void BuscarTodasAsPessoas(PessoaRepository pessoaReposiroty)
        {
            var pessoas = pessoaReposiroty.BuscarTodasPessoas();
            dgPessoa.DataSource = pessoas.ToList();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            int idade;

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("O campo Idade deve conter apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pessoa = new Pessoa(0, txtNome.Text, txtCpf.Text, idade);
            var pessoaRepository = new PessoaRepository();
            pessoaRepository.Insert(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepository);


        }
        /* Metodo para poder selecionar um campo na grid */
        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtID.Text = dgv.CurrentRow.Cells["id"]?.Value?.ToString();
            txtNome.Text = dgv.CurrentRow.Cells["Nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["Cpf"]?.Value?.ToString();
            txtIdade.Text = dgv.CurrentRow.Cells["Idade"]?.Value?.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtIdade.Text))
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("O campo Idade deve conter apenas números.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pessoa = new Pessoa(Convert.ToInt32(txtID.Text), txtNome.Text, txtCpf.Text, Convert.ToInt32(txtIdade.Text));
            var pessoaRepository = new PessoaRepository();
            pessoaRepository.Update(pessoa);
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepository);
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Selecione um registro para excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pessoaRepository = new PessoaRepository();
            pessoaRepository.Delete(Convert.ToInt32(txtID.Text));
            LimparCampos();
            BuscarTodasAsPessoas(pessoaRepository);
        }
    }
}
