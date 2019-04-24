namespace Loja
{
    partial class FormEditFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboFornecedores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textCNPJ = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textUF = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textSala = new System.Windows.Forms.TextBox();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.textRua = new System.Windows.Forms.TextBox();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.salvarFornecedor = new System.Windows.Forms.Button();
            this.botaoExcluirFornecedor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFornecedores
            // 
            this.comboFornecedores.FormattingEnabled = true;
            this.comboFornecedores.Location = new System.Drawing.Point(139, 55);
            this.comboFornecedores.Name = "comboFornecedores";
            this.comboFornecedores.Size = new System.Drawing.Size(227, 21);
            this.comboFornecedores.TabIndex = 0;
            this.comboFornecedores.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(139, 112);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(178, 20);
            this.textCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código";
            // 
            // textCNPJ
            // 
            this.textCNPJ.Location = new System.Drawing.Point(139, 168);
            this.textCNPJ.Name = "textCNPJ";
            this.textCNPJ.Size = new System.Drawing.Size(178, 20);
            this.textCNPJ.TabIndex = 4;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(139, 222);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(178, 20);
            this.textTelefone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "CEP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Rua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(449, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Número";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sala";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "UF";
            // 
            // textUF
            // 
            this.textUF.Location = new System.Drawing.Point(564, 322);
            this.textUF.Name = "textUF";
            this.textUF.Size = new System.Drawing.Size(121, 20);
            this.textUF.TabIndex = 16;
            // 
            // textCidade
            // 
            this.textCidade.Location = new System.Drawing.Point(564, 265);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(121, 20);
            this.textCidade.TabIndex = 17;
            // 
            // textSala
            // 
            this.textSala.Location = new System.Drawing.Point(564, 213);
            this.textSala.Name = "textSala";
            this.textSala.Size = new System.Drawing.Size(121, 20);
            this.textSala.TabIndex = 18;
            // 
            // textCEP
            // 
            this.textCEP.Location = new System.Drawing.Point(564, 59);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(121, 20);
            this.textCEP.TabIndex = 19;
            // 
            // textRua
            // 
            this.textRua.Location = new System.Drawing.Point(564, 115);
            this.textRua.Name = "textRua";
            this.textRua.Size = new System.Drawing.Size(121, 20);
            this.textRua.TabIndex = 20;
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(564, 164);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(121, 20);
            this.textNumero.TabIndex = 21;
            // 
            // salvarFornecedor
            // 
            this.salvarFornecedor.Location = new System.Drawing.Point(53, 306);
            this.salvarFornecedor.Name = "salvarFornecedor";
            this.salvarFornecedor.Size = new System.Drawing.Size(75, 23);
            this.salvarFornecedor.TabIndex = 22;
            this.salvarFornecedor.Text = "Salvar";
            this.salvarFornecedor.UseVisualStyleBackColor = true;
            this.salvarFornecedor.Click += new System.EventHandler(this.salvarFornecedor_Click);
            // 
            // botaoExcluirFornecedor
            // 
            this.botaoExcluirFornecedor.Location = new System.Drawing.Point(209, 306);
            this.botaoExcluirFornecedor.Name = "botaoExcluirFornecedor";
            this.botaoExcluirFornecedor.Size = new System.Drawing.Size(108, 23);
            this.botaoExcluirFornecedor.TabIndex = 24;
            this.botaoExcluirFornecedor.Text = "Excluir Fornecedor";
            this.botaoExcluirFornecedor.UseVisualStyleBackColor = true;
            this.botaoExcluirFornecedor.Click += new System.EventHandler(this.botaoExcluirFornecedor_Click);
            // 
            // FormEditFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 376);
            this.Controls.Add(this.botaoExcluirFornecedor);
            this.Controls.Add(this.salvarFornecedor);
            this.Controls.Add(this.textNumero);
            this.Controls.Add(this.textRua);
            this.Controls.Add(this.textCEP);
            this.Controls.Add(this.textSala);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.textUF);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textCNPJ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboFornecedores);
            this.Name = "FormEditFornecedor";
            this.Text = "FormEditFornecedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFornecedores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCNPJ;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textUF;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textSala;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.TextBox textRua;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Button salvarFornecedor;
        private System.Windows.Forms.Button botaoExcluirFornecedor;
    }
}