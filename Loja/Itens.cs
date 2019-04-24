using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Itens
    {
        public Produto produto;
        public int quantidade { get; set; }
        public double valor { get; set; }

        public void adicionarItem()
        {
            produto = new Produto();
            //inserir quantidade de produto
            //quantidade = entrada
            valor += (produto.preco * quantidade);
        }

        public void removerItem()
        {
            //inserir quantidade de produtos removidos
            //quantidade = entrada
            valor -= (produto.preco * quantidade);
        }
    }
}
