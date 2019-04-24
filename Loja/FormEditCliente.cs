using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Loja
{
    public partial class FormEditCliente : Form
    {
        private Form1 formPrincipal;
        private List<Cliente> clientes;

        //importa lista de clietes cadastrados
        public FormEditCliente(Form1 formPrincipal, List<Cliente> clientesRecebidos)
        {
            this.formPrincipal = formPrincipal;
            clientes = clientesRecebidos;
            InitializeComponent();
            foreach (Cliente cliente in clientes)
            {
                comboClientes.Items.Add(cliente.nome);
            }
        }

        //seleciona cliente para edição
        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dados do cliente
            int indice = comboClientes.SelectedIndex;
            Cliente selecionado = this.clientes[indice];
            textCodigo.Text = Convert.ToString(selecionado.codigo);
            textLimite.Text = Convert.ToString(selecionado.limiteDeCredito);
            textTelefone.Text = Convert.ToString(selecionado.telefone);
            textFiliacao.Text = selecionado.filiacao;

            //dados do endereco do cliente
            textCEP.Text = Convert.ToString(selecionado.endereco.cep);
            textRua.Text = selecionado.endereco.rua;
            textNumero.Text = Convert.ToString(selecionado.endereco.numero);
            textSala.Text = Convert.ToString(selecionado.endereco.sala);
            textCidade.Text = selecionado.endereco.cidade;
            textUF.Text = selecionado.endereco.uf;

        }

        //atualizar novos dados do cliente
        private void salvarCliente_Click(object sender, EventArgs e)
        {
            int indice = comboClientes.SelectedIndex;
            Cliente selecionado = this.clientes[indice];
            selecionado.codigo = Convert.ToInt32(textCodigo.Text);
            selecionado.telefone = Convert.ToInt32(textTelefone.Text);
            selecionado.filiacao = textFiliacao.Text;
            selecionado.limiteDeCredito = Convert.ToInt32(textLimite.Text);

            selecionado.endereco.cep = Convert.ToInt32(textCEP.Text);
            selecionado.endereco.rua = textRua.Text;
            selecionado.endereco.numero = Convert.ToInt32(textNumero.Text);
            selecionado.endereco.sala = Convert.ToInt32(textSala.Text);
            selecionado.endereco.cidade = textCidade.Text;
            selecionado.endereco.uf = textCEP.Text;

            this.formPrincipal.AtualizaCliente(selecionado, indice);

            MessageBox.Show("Alterações Salvas");
        }

        private void botaoExcluirCliente_Click(object sender, EventArgs e)
        {
            int indice = comboClientes.SelectedIndex;
            clientes.RemoveAt(indice);
            formPrincipal.atualizaClientes(clientes);
            MessageBox.Show("Cliente Removido");
            comboClientes.Items.RemoveAt(indice);

            //limpando campos apos exclusao
            textCodigo.Text = "";
            textLimite.Text = "";
            textTelefone.Text = "";
            textFiliacao.Text = "";
            textCEP.Text = "";
            textRua.Text = "";
            textNumero.Text = "";
            textSala.Text = "";
            textCidade.Text = "";
            textUF.Text = "";
        }
    }

}
