using System;
using System.Windows.Forms;

namespace Loja
{
    public partial class FormNovoFornecedor : Form
    {
        private Form1 formPrincipal;
        public FormNovoFornecedor(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        //cadastra novo fornecedor na lista
        private void botaoCadastrarFonecedor_Click(object sender, EventArgs e)
        {
            Fornecedor novoFornecedor = new Fornecedor();

            novoFornecedor.codigo = Convert.ToInt32(textCodigo.Text);
            novoFornecedor.nome = textNome.Text;
            novoFornecedor.telefone = Convert.ToInt32(textTelefone.Text);
            novoFornecedor.cnpj = Convert.ToInt32(textCNPJ.Text);

            novoFornecedor.endereco.cep = Convert.ToInt32(textCEP.Text);
            novoFornecedor.endereco.rua = textRua.Text;
            novoFornecedor.endereco.numero = Convert.ToInt32(textNumero.Text);
            novoFornecedor.endereco.sala = Convert.ToInt32(textSala.Text);
            novoFornecedor.endereco.cidade = textCidade.Text;
            novoFornecedor.endereco.uf = textCEP.Text;

            this.formPrincipal.AdicionaFornecedor(novoFornecedor);

            MessageBox.Show("Cadastro Efetuado");
        }
    }
}
