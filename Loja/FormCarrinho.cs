using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Loja
{
    public partial class FormCarrinho : Form
    {
        private FormNovoPedido formNovoPedido;
        private List<Produto> produtos;
        private List<Itens> carrinho;
        public FormCarrinho(FormNovoPedido formNovoPedido, List<Produto> produtosRecebidos, List<Itens> compras)
        {
            this.formNovoPedido = formNovoPedido;
            produtos = produtosRecebidos;
            carrinho = compras;
            InitializeComponent();
            foreach (Itens item in carrinho)
            {
                comboProdutos.Items.Add(item.produto.nome);
            }
        }

        //seleciona produto do carrinho
        private void comboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboProdutos.SelectedIndex;
            Itens selecionado = this.carrinho[indice];
            textQuant.Text = Convert.ToString(selecionado.quantidade);
            textValor.Text = Convert.ToString(selecionado.produto.preco * selecionado.quantidade);
        }

        //retira um item do carrinho
        private void buttonRetirar_Click(object sender, EventArgs e)
        {
            int indice = comboProdutos.SelectedIndex;
            carrinho.RemoveAt(indice);
            formNovoPedido.atualizaCarrinho(carrinho);
            MessageBox.Show("Produto Removido");
            comboProdutos.Items.RemoveAt(indice);
        }

    }
}
