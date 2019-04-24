using System;
using System.Windows.Forms;
using System.Collections.Generic;

//Link da Apostila:
//https://www.caelum.com.br/apostila-csharp-orientacao-objetos/cadastro-de-novas-contas/#utilizando-o-adicionaconta-no-load-do-formulrio

namespace Loja
{
    public partial class Form1 : Form
    {
        public List<Cliente> clientes = new List<Cliente>();
        public List<Produto> produtos = new List<Produto>();
        public List<Fornecedor> fornecedores = new List<Fornecedor>();
        public List<Pedido> pedidos = new List<Pedido>();


        public Form1()
        {
            InitializeComponent();


            //geração de cadastros base
            //cadastro de fornecedores
            Fornecedor fornecedor1 = new Fornecedor();
            fornecedor1.codigo = 1;
            fornecedor1.nome = "Ruan e Melissa Joalheria ME";
            fornecedor1.cnpj = 35990457000175;
            fornecedor1.telefone = 1137789135;
            fornecedor1.endereco.cep = 08562140;
            fornecedor1.endereco.rua = "Avenida Vinte e Seis de Março";
            fornecedor1.endereco.numero = 131;
            fornecedor1.endereco.sala = 0;
            fornecedor1.endereco.cidade = "Poá";
            fornecedor1.endereco.uf = "SP";

            Fornecedor fornecedor2 = new Fornecedor();
            fornecedor2.codigo = 2;
            fornecedor2.nome = "Marlene e Gabriel Mudanças ME";
            fornecedor2.cnpj = 03524541000107;
            fornecedor2.telefone = 1928689129;
            fornecedor2.endereco.cep = 13049479;
            fornecedor2.endereco.rua = "Rua Antonio Vieira de Moura";
            fornecedor2.endereco.numero = 457;
            fornecedor2.endereco.sala = 0;
            fornecedor2.endereco.cidade = "Campinas";
            fornecedor2.endereco.uf = "SP";

            Fornecedor fornecedor3 = new Fornecedor();
            fornecedor3.codigo = 3;
            fornecedor3.nome = "Julio e Daniela Doces & Salgados ME";
            fornecedor3.cnpj = 99451159000190;
            fornecedor3.telefone = 1325848840;
            fornecedor3.endereco.cep = 11707370;
            fornecedor3.endereco.rua = "Rua Visconde de Mauá";
            fornecedor3.endereco.numero = 217;
            fornecedor3.endereco.sala = 0;
            fornecedor3.endereco.cidade = "Praia Grande";
            fornecedor3.endereco.uf = "SP";

            fornecedores.Add(fornecedor1);
            fornecedores.Add(fornecedor2);
            fornecedores.Add(fornecedor3);

            //cadastro de clientes
            Cliente cliente1 = new Cliente();
            cliente1.codigo = 1;
            cliente1.nome = "Heitor Bruno da Rocha";
            cliente1.telefone = 7138981687;
            cliente1.filiacao = "Betina Isadora Jaqueline";
            cliente1.limiteDeCredito = 5000;
            cliente1.endereco.cep = 40391326;
            cliente1.endereco.rua = "Estrada da Formiga";
            cliente1.endereco.numero = 778;
            cliente1.endereco.sala = 0;
            cliente1.endereco.cidade = "Salvador";
            cliente1.endereco.uf = "BA";

            Cliente cliente2 = new Cliente();
            cliente2.codigo = 2;
            cliente2.nome = "Breno Noah Pietro Nunes";
            cliente2.telefone = 5538092682;
            cliente2.filiacao = "Débora Lavínia Renata";
            cliente2.limiteDeCredito = 1000;
            cliente2.endereco.cep = 98805730;
            cliente2.endereco.rua = "Travessa Arabicum";
            cliente2.endereco.numero = 851;
            cliente2.endereco.sala = 0;
            cliente2.endereco.cidade = "Santo Ângelo";
            cliente2.endereco.uf = "RS";

            Cliente cliente3 = new Cliente();
            cliente3.codigo = 3;
            cliente3.nome = "Lúcia Tereza Rezende";
            cliente3.telefone = 8429005942;
            cliente3.filiacao = "Sophia Clarice Emily";
            cliente3.limiteDeCredito = 10000;
            cliente3.endereco.cep = 59609430;
            cliente3.endereco.rua = "Rua Thiago Adolfo Maia Caldas";
            cliente3.endereco.numero = 404;
            cliente3.endereco.sala = 0;
            cliente3.endereco.cidade = "Mossoró";
            cliente3.endereco.uf = "RN";

            clientes.Add(cliente1);
            clientes.Add(cliente2);
            clientes.Add(cliente3);

            //cadastro de produtos
            Produto produto1 = new Produto();
            produto1.codigo = 1;
            produto1.nome = "Cadeira";
            produto1.dataFabricacao = new DateTime(2018, 11, 01); //01 / 11 / 2018
            produto1.dataVencimento = new DateTime(2021, 11, 01); //01 / 11 / 2021
            produto1.preco = 35;
            produto1.fornecedor = fornecedor1;

            Produto produto2 = new Produto();
            produto2.codigo = 2;
            produto2.nome = "Televisão";
            produto2.dataFabricacao = new DateTime(2018, 12, 21); //21 / 12 / 2018
            produto2.dataVencimento = new DateTime(2025, 01, 22); //22 / 01 / 2025
            produto2.preco = 500;
            produto2.fornecedor = fornecedor2;

            Produto produto3 = new Produto();
            produto3.codigo = 3;
            produto3.nome = "Chocolate";
            produto3.dataFabricacao = new DateTime(2019, 01, 01); //01 / 01 / 2019
            produto3.dataVencimento = new DateTime(2019, 04, 15); //15 / 04 / 2019
            produto3.preco = 10;
            produto3.fornecedor = fornecedor3;

            produtos.Add(produto1);
            produtos.Add(produto2);
            produtos.Add(produto3);

        }

        //chama tela Novo Cliente
        private void botaoNovoCliente_Click(object sender, EventArgs e)
        {
            FormNovoCliente formularioNovoCliente = new FormNovoCliente(this);
            formularioNovoCliente.ShowDialog();
        }

        //chama tela Editar Cliente
        private void botaoEditCliente_Click(object sender, EventArgs e)
        {
            FormEditCliente formularioEditCliente = new FormEditCliente(this, clientes);
            formularioEditCliente.ShowDialog();
        }

        //chama tela Novo Fornecedor
        private void botaoNovoFornecedor_Click(object sender, EventArgs e)
        {
            FormNovoFornecedor formularioNovoFornecedor = new FormNovoFornecedor(this);
            formularioNovoFornecedor.ShowDialog();
        }

        //chama tela Editar Fornecedor
        private void botaoEditFornecedor_Click(object sender, EventArgs e)
        {
            FormEditFornecedor formularioEditFornecedor = new FormEditFornecedor(this, fornecedores);
            formularioEditFornecedor.ShowDialog();
        }

        //chama tela Novo Pedido
        private void botaoNovoPedido_Click(object sender, EventArgs e)
        {
            FormNovoPedido formularioNovoPedido = new FormNovoPedido(this, produtos, clientes);
            formularioNovoPedido.ShowDialog();
        }

        //chama tela Novo Produto
        private void botaoNovoProduto_Click(object sender, EventArgs e)
        {
            FormNovoProduto formularioNovoProduto = new FormNovoProduto(this, fornecedores);
            formularioNovoProduto.ShowDialog();
        }

        //chama tela Editar Produto
        private void botaoEditProduto_Click(object sender, EventArgs e)
        {
            FormEditProduto formularioEditProduto = new FormEditProduto(this, produtos, fornecedores);
            formularioEditProduto.ShowDialog();
        }

        //adiciona novo cliente cadastrado na lista
        public void AdicionaCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }

        //salva alterações de feitas em um cliente ja cadastrado
        public void AtualizaCliente(Cliente cliente, int indice)
        {
            clientes[indice] = cliente;
        }

        //adiciona um novo fornecedor cadastrado na lista
        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            fornecedores.Add(fornecedor);
        }

        //salva alterações feitas em um fornecedor ja cadastrado
        public void AtualizaFornecedor(Fornecedor fornecedor, int indice)
        {
            fornecedores[indice] = fornecedor;
        }

        //adiciona um novo produto cadastrado na lista
        public void AdicionaProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        //salva alterações feitas em um produto ja cadastrado
        public void AtualizaProduto(Produto produto, int indice)
        {
            produtos[indice] = produto;
        }

        //atualiza lista de clientes quando ocorre alguma remoçao de cliente
        public void atualizaClientes(List<Cliente> novoClientes)
        {
            clientes = novoClientes;
        }

        //atualiza lista de fornecedores quando ocorre alguma remoçao de fornecedor
        public void atualizaFornecedores(List<Fornecedor> novoFornecedores)
        {
            fornecedores = novoFornecedores;
        }

        //atualiza lista de produtos quando ocorre alguma remoçao de produto
        public void atualizaProdutos(List<Produto> novoProdutos)
        {
            produtos = novoProdutos;
        }
    }
}
