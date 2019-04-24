using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Loja
{
    public partial class FormEditFornecedor : Form
    {
        private Form1 formPrincipal;
        private List<Fornecedor> fornecedores;

        //importa lista de fornecedores cadastrados
        public FormEditFornecedor(Form1 formPrincipal, List<Fornecedor> fornecedoresRecebidos)
        {
            this.formPrincipal = formPrincipal;
            fornecedores = fornecedoresRecebidos;
            InitializeComponent();
            foreach (Fornecedor fornecedor in fornecedores)
            {
                comboFornecedores.Items.Add(fornecedor.nome);
            }
        }

        //atualiza novos dados do fonecedor
        private void salvarFornecedor_Click(object sender, EventArgs e)
        {
            int indice = comboFornecedores.SelectedIndex;
            Fornecedor selecionado = this.fornecedores[indice];
            selecionado.codigo = Convert.ToInt32(textCodigo.Text);
            selecionado.telefone = Convert.ToInt32(textTelefone.Text);
            selecionado.cnpj = Convert.ToInt32(textCNPJ.Text);

            selecionado.endereco.cep = Convert.ToInt32(textCEP.Text);
            selecionado.endereco.rua = textRua.Text;
            selecionado.endereco.numero = Convert.ToInt32(textNumero.Text);
            selecionado.endereco.sala = Convert.ToInt32(textSala.Text);
            selecionado.endereco.cidade = textCidade.Text;
            selecionado.endereco.uf = textCEP.Text;

            this.formPrincipal.AtualizaFornecedor(selecionado, indice);

            MessageBox.Show("Alterações Salvas");
        }

        //seleciona fornecedor para edição
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dados do fornecedor
            int indice = comboFornecedores.SelectedIndex;
            Fornecedor selecionado = this.fornecedores[indice];
            textCodigo.Text = Convert.ToString(selecionado.codigo);
            textCNPJ.Text = Convert.ToString(selecionado.cnpj);
            textTelefone.Text = Convert.ToString(selecionado.telefone);

            //dados do endereco do fornecedor
            textCEP.Text = Convert.ToString(selecionado.endereco.cep);
            textRua.Text = selecionado.endereco.rua;
            textNumero.Text = Convert.ToString(selecionado.endereco.numero);
            textSala.Text = Convert.ToString(selecionado.endereco.sala);
            textCidade.Text = selecionado.endereco.cidade;
            textUF.Text = selecionado.endereco.uf;
        }

        private void botaoExcluirFornecedor_Click(object sender, EventArgs e)
        {
            int indice = comboFornecedores.SelectedIndex;
            fornecedores.RemoveAt(indice);
            formPrincipal.atualizaFornecedores(fornecedores);
            MessageBox.Show("Fornecedor Removido");
            comboFornecedores.Items.RemoveAt(indice);

            //limpando campos apos exclusao
            textCodigo.Text = "";
            textCNPJ.Text = "";
            textTelefone.Text = "";
            textCEP.Text = "";
            textRua.Text = "";
            textNumero.Text = "";
            textSala.Text = "";
            textCidade.Text = "";
            textUF.Text = "";
        }
    }
}
