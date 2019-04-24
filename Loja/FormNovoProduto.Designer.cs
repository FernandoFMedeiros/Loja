namespace Loja
{
    partial class FormNovoProduto
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
            this.botaoCadastrarProduto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textDatFab = new System.Windows.Forms.TextBox();
            this.textDatVen = new System.Windows.Forms.TextBox();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.comboFornecedores = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // botaoCadastrarProduto
            // 
            this.botaoCadastrarProduto.Location = new System.Drawing.Point(125, 273);
            this.botaoCadastrarProduto.Name = "botaoCadastrarProduto";
            this.botaoCadastrarProduto.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastrarProduto.TabIndex = 0;
            this.botaoCadastrarProduto.Text = "Cadastrar";
            this.botaoCadastrarProduto.UseVisualStyleBackColor = true;
            this.botaoCadastrarProduto.Click += new System.EventHandler(this.botaoCadastrarProduto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(182, 34);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Data de Fabricação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Vencimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fornecedor";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(182, 79);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(100, 20);
            this.textNome.TabIndex = 8;
            // 
            // textDatFab
            // 
            this.textDatFab.Location = new System.Drawing.Point(182, 116);
            this.textDatFab.Name = "textDatFab";
            this.textDatFab.Size = new System.Drawing.Size(100, 20);
            this.textDatFab.TabIndex = 9;
            // 
            // textDatVen
            // 
            this.textDatVen.Location = new System.Drawing.Point(182, 160);
            this.textDatVen.Name = "textDatVen";
            this.textDatVen.Size = new System.Drawing.Size(100, 20);
            this.textDatVen.TabIndex = 10;
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(182, 200);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(100, 20);
            this.textPreco.TabIndex = 11;
            // 
            // comboFornecedores
            // 
            this.comboFornecedores.FormattingEnabled = true;
            this.comboFornecedores.Location = new System.Drawing.Point(182, 241);
            this.comboFornecedores.Name = "comboFornecedores";
            this.comboFornecedores.Size = new System.Drawing.Size(100, 21);
            this.comboFornecedores.TabIndex = 12;
            // 
            // FormNovoProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 344);
            this.Controls.Add(this.comboFornecedores);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.textDatVen);
            this.Controls.Add(this.textDatFab);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoCadastrarProduto);
            this.Name = "FormNovoProduto";
            this.Text = "FormNovoProduto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastrarProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textDatFab;
        private System.Windows.Forms.TextBox textDatVen;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.ComboBox comboFornecedores;
    }
}