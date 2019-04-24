using System;
using System.Windows.Forms;

namespace Loja
{
    public partial class FormNovoCliente : Form
    {
        private Form1 formPrincipal;

        public FormNovoCliente(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        //cadastra novo cliente na lista de clientes
        private void botaoCadastrarCliente_Click(object sender, EventArgs e)
        {
            Cliente novoCliente = new Cliente();

            novoCliente.codigo = Convert.ToInt32(textoCodigo.Text);
            novoCliente.nome = textoNome.Text;
            novoCliente.telefone = Convert.ToInt32(textoTelefone.Text);
            novoCliente.filiacao = textoFiliacao.Text;
            novoCliente.limiteDeCredito = Convert.ToInt32(textoLimite.Text);

            novoCliente.endereco.cep = Convert.ToInt32(textoCEP.Text);
            novoCliente.endereco.rua = textoRua.Text;
            novoCliente.endereco.numero = Convert.ToInt32(textoNumero.Text);
            novoCliente.endereco.sala = Convert.ToInt32(textoSala.Text);
            novoCliente.endereco.cidade = textoCidade.Text;
            novoCliente.endereco.uf = textoCEP.Text;

            this.formPrincipal.AdicionaCliente(novoCliente);

            MessageBox.Show("Cadastro Efetuado");
        }

    }
}
