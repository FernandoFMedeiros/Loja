namespace Loja
{
    partial class FormNovoPedido
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
            this.botaoFinalizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butaoCarrinho = new System.Windows.Forms.Button();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.textValAtual = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textValTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textCredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericQuant = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoFinalizar
            // 
            this.botaoFinalizar.Location = new System.Drawing.Point(104, 366);
            this.botaoFinalizar.Name = "botaoFinalizar";
            this.botaoFinalizar.Size = new System.Drawing.Size(94, 23);
            this.botaoFinalizar.TabIndex = 0;
            this.botaoFinalizar.Text = "Finalizar Pedido";
            this.botaoFinalizar.UseVisualStyleBackColor = true;
            this.botaoFinalizar.Click += new System.EventHandler(this.botaoFinalizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Produto";
            // 
            // comboProdutos
            // 
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(156, 31);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(121, 21);
            this.comboProdutos.TabIndex = 2;
            this.comboProdutos.SelectedIndexChanged += new System.EventHandler(this.comboProdutos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantidade";
            // 
            // butaoCarrinho
            // 
            this.butaoCarrinho.Location = new System.Drawing.Point(175, 311);
            this.butaoCarrinho.Name = "butaoCarrinho";
            this.butaoCarrinho.Size = new System.Drawing.Size(102, 23);
            this.butaoCarrinho.TabIndex = 5;
            this.butaoCarrinho.Text = "Visualizar Carrinho";
            this.butaoCarrinho.UseVisualStyleBackColor = true;
            this.butaoCarrinho.Click += new System.EventHandler(this.botaoCarrinho_Click);
            // 
            // comboClientes
            // 
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(156, 122);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(121, 21);
            this.comboClientes.TabIndex = 7;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Informar Comprador";
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(26, 311);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(122, 23);
            this.botaoAdicionar.TabIndex = 8;
            this.botaoAdicionar.Text = "Adicionar ao Carrinho";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // textValAtual
            // 
            this.textValAtual.Location = new System.Drawing.Point(167, 170);
            this.textValAtual.Name = "textValAtual";
            this.textValAtual.ReadOnly = true;
            this.textValAtual.Size = new System.Drawing.Size(96, 20);
            this.textValAtual.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor a Adicionar";
            // 
            // textValTotal
            // 
            this.textValTotal.Location = new System.Drawing.Point(167, 215);
            this.textValTotal.Name = "textValTotal";
            this.textValTotal.ReadOnly = true;
            this.textValTotal.Size = new System.Drawing.Size(96, 20);
            this.textValTotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor Total";
            // 
            // textCredito
            // 
            this.textCredito.Location = new System.Drawing.Point(167, 256);
            this.textCredito.Name = "textCredito";
            this.textCredito.ReadOnly = true;
            this.textCredito.Size = new System.Drawing.Size(96, 20);
            this.textCredito.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Crédito Total";
            // 
            // numericQuant
            // 
            this.numericQuant.Location = new System.Drawing.Point(157, 75);
            this.numericQuant.Name = "numericQuant";
            this.numericQuant.Size = new System.Drawing.Size(120, 20);
            this.numericQuant.TabIndex = 15;
            this.numericQuant.ValueChanged += new System.EventHandler(this.numericQuant_ValueChanged);
            // 
            // FormNovoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 409);
            this.Controls.Add(this.numericQuant);
            this.Controls.Add(this.textCredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textValTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textValAtual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butaoCarrinho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboProdutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoFinalizar);
            this.Name = "FormNovoPedido";
            this.Text = "FormNovoPedido";
            ((System.ComponentModel.ISupportInitialize)(this.numericQuant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoFinalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butaoCarrinho;
        private System.Windows.Forms.ComboBox comboClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.TextBox textValAtual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textValTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textCredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericQuant;
    }
}