namespace Loja
{
    partial class Form1
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
            this.botaoNovoCliente = new System.Windows.Forms.Button();
            this.novoPedido = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.EditCliente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botaoEditProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoNovoCliente
            // 
            this.botaoNovoCliente.Location = new System.Drawing.Point(35, 54);
            this.botaoNovoCliente.Name = "botaoNovoCliente";
            this.botaoNovoCliente.Size = new System.Drawing.Size(116, 23);
            this.botaoNovoCliente.TabIndex = 0;
            this.botaoNovoCliente.Text = "Novo Cliente";
            this.botaoNovoCliente.UseVisualStyleBackColor = true;
            this.botaoNovoCliente.Click += new System.EventHandler(this.botaoNovoCliente_Click);
            // 
            // novoPedido
            // 
            this.novoPedido.Location = new System.Drawing.Point(322, 54);
            this.novoPedido.Name = "novoPedido";
            this.novoPedido.Size = new System.Drawing.Size(108, 23);
            this.novoPedido.TabIndex = 1;
            this.novoPedido.Text = "Novo Pedido";
            this.novoPedido.UseVisualStyleBackColor = true;
            this.novoPedido.Click += new System.EventHandler(this.botaoNovoPedido_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Novo Fornecedor";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.botaoNovoFornecedor_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Novo Produto";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.botaoNovoProduto_Click);
            // 
            // EditCliente
            // 
            this.EditCliente.Location = new System.Drawing.Point(35, 83);
            this.EditCliente.Name = "EditCliente";
            this.EditCliente.Size = new System.Drawing.Size(116, 23);
            this.EditCliente.TabIndex = 4;
            this.EditCliente.Text = "Editar Cliente";
            this.EditCliente.UseVisualStyleBackColor = true;
            this.EditCliente.Click += new System.EventHandler(this.botaoEditCliente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(352, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produtos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fornecedores";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(322, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar Fornecedor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.botaoEditFornecedor_Click);
            // 
            // botaoEditProduto
            // 
            this.botaoEditProduto.Location = new System.Drawing.Point(35, 207);
            this.botaoEditProduto.Name = "botaoEditProduto";
            this.botaoEditProduto.Size = new System.Drawing.Size(116, 23);
            this.botaoEditProduto.TabIndex = 10;
            this.botaoEditProduto.Text = "Editar Produto";
            this.botaoEditProduto.UseVisualStyleBackColor = true;
            this.botaoEditProduto.Click += new System.EventHandler(this.botaoEditProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 265);
            this.Controls.Add(this.botaoEditProduto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditCliente);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.novoPedido);
            this.Controls.Add(this.botaoNovoCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoNovoCliente;
        private System.Windows.Forms.Button novoPedido;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button EditCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botaoEditProduto;
    }
}

