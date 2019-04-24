using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Produto
    {
        public int codigo;
        public String nome;
        public DateTime dataFabricacao;
        public DateTime dataVencimento;
        public double preco;
        public Fornecedor fornecedor;
        public int estoque;
        public bool emFalta;
        public Pedido pedido;
        public Itens itens;
        public int minimo;

        public void solicitarProduto()
        {
            if (emFalta == true)
            {
                fornecedor.produzir();
            }
        }

        public void reduzirEstoque()
        {
            if (pedido.solicitado == true)
                estoque -= itens.quantidade;

            if (estoque <= minimo)
                emFalta = true;
        }
    }
}
