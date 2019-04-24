using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Loja
{
    public partial class FormNovoProduto : Form
    {
        private Form1 formPrincipal;
        private List<Fornecedor> fornecedores;

        //importa lista de fornecedores para cadastro de produto
        public FormNovoProduto(Form1 formPrincipal, List<Fornecedor> fornecedoresRecebidos)
        {
            this.formPrincipal = formPrincipal;
            fornecedores = fornecedoresRecebidos;
            InitializeComponent();
            foreach (Fornecedor fornecedor in fornecedores)
            {
                comboFornecedores.Items.Add(fornecedor.nome);
            }
        }

        //cadastra novo produto na lista de produtos
        private void botaoCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto();

            int indice = comboFornecedores.SelectedIndex;
            Fornecedor selecionado = this.fornecedores[indice];

            novoProduto.codigo = Convert.ToInt32(textCodigo.Text);
            novoProduto.nome = textNome.Text;
            novoProduto.dataFabricacao = DateTime.Parse(textDatFab.Text);
            novoProduto.dataVencimento = DateTime.Parse(textDatVen.Text);
            novoProduto.preco = Convert.ToDouble(textPreco.Text);
            novoProduto.fornecedor = selecionado;

            this.formPrincipal.AdicionaProduto(novoProduto);

            MessageBox.Show("Cadastro Efetuado");
        }

    }
}
