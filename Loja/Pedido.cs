using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Pedido
    {
        public double valor { get; set; }
        private Itens itens = new Itens();
        public int quantidade { get; set; }
        public bool solicitado { get; set; }

        public void adicionarProduto(Produto produto)
        {
            quantidade += itens.quantidade;
            valor += itens.valor;
        }

        public void removerProduto(Produto produto)
        {
            quantidade -= itens.quantidade;
            valor -= itens.valor;
        }

        public void realizaPedido()
        {
            solicitado = true;
        }

        public void cancelarPedido()
        {
            quantidade = 0;
            valor = 0;
            solicitado = false;
        }
    }
}
