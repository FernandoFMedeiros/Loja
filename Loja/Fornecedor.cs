using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    public class Fornecedor
    {
        public int codigo;
        public String nome;
        public long cnpj;
        public Endereco endereco = new Endereco();
        public long telefone;
        public Produto[] produto = new Produto[10];
        public int producao { get; set; }

        public void produzir()
        {
            //producao = quantidade de lote;
        }
    }
}
