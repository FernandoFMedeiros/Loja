using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Loja
{
    public partial class FormEditProduto : Form
    {
        private Form1 formPrincipal;
        private List<Fornecedor> fornecedores;
        private List<Produto> produtos;

        //importa lista de produtos cadastrados
        public FormEditProduto(Form1 formPrincipal, List<Produto> produtosRecebidos, List<Fornecedor> fornecedoresRecebidos)
        {
            this.formPrincipal = formPrincipal;
            fornecedores = fornecedoresRecebidos;
            produtos = produtosRecebidos;
            InitializeComponent();
            foreach (Fornecedor fornecedor in fornecedores)
            {
                comboFornecedores.Items.Add(fornecedor.nome);
            }
            foreach (Produto produto in produtos)
            {
                comboProdutos.Items.Add(produto.nome);
            }
        }

        //seleciona produto para edição
        private void comboProdutos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            //dados do produto
            int indiceProduto = comboProdutos.SelectedIndex;
            Produto selecionado = this.produtos[indiceProduto];
            Fornecedor fornecedor = selecionado.fornecedor;
            int indiceFornecedor = comboFornecedores.FindStringExact(selecionado.fornecedor.nome);

            textCodigo.Text = Convert.ToString(selecionado.codigo);
            textDatFab.Text = selecionado.dataFabricacao.ToString("dd/MM/yyyy");
            textDatVen.Text = selecionado.dataVencimento.ToString("dd/MM/yyyy");
            textPreco.Text = Convert.ToString(selecionado.preco);
            comboFornecedores.SelectedIndex = indiceFornecedor;
        }

        //salva novos dados do produto
        private void botaoCadastrarProduto_Click(object sender, EventArgs e)
        {
            int indiceProduto = comboProdutos.SelectedIndex;
            int indiceFornecedor = comboFornecedores.SelectedIndex;
            Produto selecionado = this.produtos[indiceProduto];
            Fornecedor fornecedorSele = this.fornecedores[indiceFornecedor];

            selecionado.codigo = Convert.ToInt32(textCodigo.Text);
            selecionado.dataFabricacao = DateTime.Parse(textDatFab.Text);
            selecionado.dataVencimento = DateTime.Parse(textDatVen.Text);
            selecionado.preco = Convert.ToDouble(textPreco.Text);
            selecionado.fornecedor = fornecedorSele;

            this.formPrincipal.AtualizaProduto(selecionado, indiceProduto);

            MessageBox.Show("Alterações Salvas");
        }

        //exclui um produto da lista de produtos
        private void botaoExcluirProduto_Click(object sender, EventArgs e)
        {
            int indice = comboProdutos.SelectedIndex;
            produtos.RemoveAt(indice);
            formPrincipal.atualizaProdutos(produtos);
            MessageBox.Show("Produto Removido");
            comboProdutos.Items.RemoveAt(indice);

            //limpando campos apos exclusao
            textCodigo.Text = "";
            textDatFab.Text = "";
            textDatVen.Text = "";
            textPreco.Text = "";
            comboFornecedores.SelectedIndex = -1;
        }
    }
}
