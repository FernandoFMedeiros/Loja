namespace Loja
{
    partial class FormEditProduto
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
            this.textPreco = new System.Windows.Forms.TextBox();
            this.textDatVen = new System.Windows.Forms.TextBox();
            this.textDatFab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoCadastrarProduto = new System.Windows.Forms.Button();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.botaoExcluirProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboFornecedores
            // 
            this.comboFornecedores.FormattingEnabled = true;
            this.comboFornecedores.Location = new System.Drawing.Point(204, 240);
            this.comboFornecedores.Name = "comboFornecedores";
            this.comboFornecedores.Size = new System.Drawing.Size(201, 21);
            this.comboFornecedores.TabIndex = 25;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(204, 199);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(201, 20);
            this.textPreco.TabIndex = 24;
            // 
            // textDatVen
            // 
            this.textDatVen.Location = new System.Drawing.Point(204, 159);
            this.textDatVen.Name = "textDatVen";
            this.textDatVen.Size = new System.Drawing.Size(201, 20);
            this.textDatVen.TabIndex = 23;
            // 
            // textDatFab
            // 
            this.textDatFab.Location = new System.Drawing.Point(204, 115);
            this.textDatFab.Name = "textDatFab";
            this.textDatFab.Size = new System.Drawing.Size(201, 20);
            this.textDatFab.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Fornecedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Preço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Data de Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Data de Fabricação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nome";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(204, 70);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(201, 20);
            this.textCodigo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Código";
            // 
            // botaoCadastrarProduto
            // 
            this.botaoCadastrarProduto.Location = new System.Drawing.Point(84, 302);
            this.botaoCadastrarProduto.Name = "botaoCadastrarProduto";
            this.botaoCadastrarProduto.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrarProduto.TabIndex = 13;
            this.botaoCadastrarProduto.Text = "Salvar";
            this.botaoCadastrarProduto.UseVisualStyleBackColor = true;
            this.botaoCadastrarProduto.Click += new System.EventHandler(this.botaoCadastrarProduto_Click);
            // 
            // comboProdutos
            // 
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(204, 19);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(201, 21);
            this.comboProdutos.TabIndex = 27;
            this.comboProdutos.SelectedIndexChanged += new System.EventHandler(this.comboProdutos_SelectedIndexChanged);
            // 
            // botaoExcluirProduto
            // 
            this.botaoExcluirProduto.Location = new System.Drawing.Point(222, 302);
            this.botaoExcluirProduto.Name = "botaoExcluirProduto";
            this.botaoExcluirProduto.Size = new System.Drawing.Size(89, 23);
            this.botaoExcluirProduto.TabIndex = 28;
            this.botaoExcluirProduto.Text = "Excluir Produto";
            this.botaoExcluirProduto.UseVisualStyleBackColor = true;
            this.botaoExcluirProduto.Click += new System.EventHandler(this.botaoExcluirProduto_Click);
            // 
            // FormEditProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 350);
            this.Controls.Add(this.botaoExcluirProduto);
            this.Controls.Add(this.comboProdutos);
            this.Controls.Add(this.comboFornecedores);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textDatVen);
            this.Controls.Add(this.textDatFab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoCadastrarProduto);
            this.Name = "FormEditProduto";
            this.Text = "FormEditProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFornecedores;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.TextBox textDatVen;
        private System.Windows.Forms.TextBox textDatFab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoCadastrarProduto;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Button botaoExcluirProduto;
    }
}