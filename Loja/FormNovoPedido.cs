using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Loja
{
    public partial class FormNovoPedido : Form
    {
        private Form1 formPrincipal;
        private List<Cliente> clientes;
        private List<Produto> produtos;
        private List<Itens> carrinho = new List<Itens>();
        private double valorTotal = 0;

        //importa lista de produtos e clientes para elaboração de pedido
        public FormNovoPedido(Form1 formPrincipal, List<Produto> produtosRecebidos, List<Cliente> clientesRecebidos)
        {
            this.formPrincipal = formPrincipal;
            clientes = clientesRecebidos;
            produtos = produtosRecebidos;
            InitializeComponent();
            foreach (Cliente cliente in clientes)
            {
                comboClientes.Items.Add(cliente.nome);
            }
            foreach (Produto produto in produtos)
            {
                comboProdutos.Items.Add(produto.nome);
            }
        }

        //exibe janela de controle do carrinho de compras
        private void botaoCarrinho_Click(object sender, EventArgs e)
        {
            FormCarrinho formularioCarrinho = new FormCarrinho(this, produtos, carrinho);
            formularioCarrinho.ShowDialog();
        }

        //seleciona o produto a ser comprado
        private void comboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboProdutos.SelectedIndex;
            Produto selecionado = this.produtos[indice];
            numericQuant.Minimum = 1;
            textValAtual.Text = Convert.ToString(selecionado.preco * Convert.ToInt32(numericQuant.Value));
        }

        //seleciona o cliente a realizar compras
        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboClientes.SelectedIndex;
            Cliente selecionado = this.clientes[indice];
            textCredito.Text = Convert.ToString(selecionado.limiteDeCredito);
        }

        //seleciona a quantidade de cada produto a ser comprado
        private void numericQuant_ValueChanged(object sender, EventArgs e)
        {
            int indice = comboProdutos.SelectedIndex;
            Produto selecionado = this.produtos[indice];
            numericQuant.Minimum = 1;
            textValAtual.Text = Convert.ToString(selecionado.preco * Convert.ToInt32(numericQuant.Value));
        }

        //coloca um item selecionado na lista carrinho de compras
        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            int indice = comboProdutos.SelectedIndex;
            Produto produtoSel = this.produtos[indice];
            Itens item = new Itens();
            item.produto = produtoSel;
            item.quantidade = Convert.ToInt32(numericQuant.Value);
            item.valor = Convert.ToDouble(textValAtual.Text);
            carrinho.Add(item);
            valorTotal += Convert.ToDouble(textValAtual.Text);
            textValTotal.Text = Convert.ToString(valorTotal);
        }

        //verifica se transaçao é possivel e desconta o valor da compra do credito do cliente
        private void botaoFinalizar_Click(object sender, EventArgs e)
        {
            int indice = comboClientes.SelectedIndex;
            Cliente cliente = this.clientes[indice];
            if (cliente.limiteDeCredito >= valorTotal)
            {
                cliente.limiteDeCredito -= valorTotal;
                textCredito.Text = Convert.ToString(cliente.limiteDeCredito);
                MessageBox.Show("Compra efetuada com sucesso");
            }else
                MessageBox.Show("Crédito insuficiente");
        }

        //atualiza carrinho quando ocorre alguma remoçao de item
        public void atualizaCarrinho(List<Itens> novoCarrinho)
        {
            carrinho = novoCarrinho;
            double valorTotalAtt = 0;
            if (carrinho.Count == 0)
                textValTotal.Text = "0";
            foreach (Itens itens in carrinho)
            {
                valorTotalAtt += itens.valor;
            }
            textValTotal.Text = Convert.ToString(valorTotalAtt);
            valorTotal = valorTotalAtt;
        }
    }
}
