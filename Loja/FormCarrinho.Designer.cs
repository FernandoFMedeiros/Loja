namespace Loja
{
    partial class FormCarrinho
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboProdutos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textQuant = new System.Windows.Forms.TextBox();
            this.buttonRetirar = new System.Windows.Forms.Button();
            this.textValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantidade";
            // 
            // comboProdutos
            // 
            this.comboProdutos.FormattingEnabled = true;
            this.comboProdutos.Location = new System.Drawing.Point(161, 35);
            this.comboProdutos.Name = "comboProdutos";
            this.comboProdutos.Size = new System.Drawing.Size(121, 21);
            this.comboProdutos.TabIndex = 17;
            this.comboProdutos.SelectedIndexChanged += new System.EventHandler(this.comboProdutos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nome do Produto";
            // 
            // textQuant
            // 
            this.textQuant.Location = new System.Drawing.Point(170, 102);
            this.textQuant.Name = "textQuant";
            this.textQuant.ReadOnly = true;
            this.textQuant.Size = new System.Drawing.Size(100, 20);
            this.textQuant.TabIndex = 19;
            // 
            // buttonRetirar
            // 
            this.buttonRetirar.Location = new System.Drawing.Point(127, 235);
            this.buttonRetirar.Name = "buttonRetirar";
            this.buttonRetirar.Size = new System.Drawing.Size(92, 23);
            this.buttonRetirar.TabIndex = 20;
            this.buttonRetirar.Text = "Retirar Produto";
            this.buttonRetirar.UseVisualStyleBackColor = true;
            this.buttonRetirar.Click += new System.EventHandler(this.buttonRetirar_Click);
            // 
            // textValor
            // 
            this.textValor.Location = new System.Drawing.Point(170, 168);
            this.textValor.Name = "textValor";
            this.textValor.ReadOnly = true;
            this.textValor.Size = new System.Drawing.Size(96, 20);
            this.textValor.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Valor Total do Produto";
            // 
            // FormCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 314);
            this.Controls.Add(this.textValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonRetirar);
            this.Controls.Add(this.textQuant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboProdutos);
            this.Controls.Add(this.label1);
            this.Name = "FormCarrinho";
            this.Text = "FormCarrinho";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboProdutos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textQuant;
        private System.Windows.Forms.Button buttonRetirar;
        private System.Windows.Forms.TextBox textValor;
        private System.Windows.Forms.Label label5;
    }
}