using System;

namespace Loja
{
    public class Cliente
    {
        public  int codigo { get; set; }
        public  String nome { get; set; }
        public  Endereco endereco = new Endereco();
        public  long telefone { get; set; }
        public  String filiacao { get; set; }
        public enum status { bom, medio, ruim };
        public  double limiteDeCredito { get; set; }
        public  Pedido pedido;

        public void iniciarPedido()
        {
            pedido = new Pedido();
        }

        public void confirmarPedido()
        {
            if (pedido.solicitado == true)
            {
                if (pedido.valor > limiteDeCredito)
                {
                    //pedido invalido
                }
                else
                {
                    limiteDeCredito -= pedido.valor;
                }
            }
        }

        public void excluiCadastro() { }

        public void editarCadastro() { }
    }
}

