﻿namespace Cadastro_contas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoSaque = new System.Windows.Forms.Button();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.textoValor = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.botaoNovaConta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoSaque);
            this.groupBox1.Controls.Add(this.botaoDepositar);
            this.groupBox1.Controls.Add(this.textoValor);
            this.groupBox1.Controls.Add(this.textoSaldo);
            this.groupBox1.Controls.Add(this.textoNumero);
            this.groupBox1.Controls.Add(this.textoTitular);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conta";
            // 
            // botaoSaque
            // 
            this.botaoSaque.Location = new System.Drawing.Point(206, 197);
            this.botaoSaque.Name = "botaoSaque";
            this.botaoSaque.Size = new System.Drawing.Size(100, 23);
            this.botaoSaque.TabIndex = 9;
            this.botaoSaque.Text = "Sacar";
            this.botaoSaque.UseVisualStyleBackColor = true;
            this.botaoSaque.Click += new System.EventHandler(this.botaoSaque_Click);
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(59, 197);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(100, 23);
            this.botaoDepositar.TabIndex = 8;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.botaoDepositar_Click);
            // 
            // textoValor
            // 
            this.textoValor.Location = new System.Drawing.Point(206, 146);
            this.textoValor.Name = "textoValor";
            this.textoValor.Size = new System.Drawing.Size(100, 22);
            this.textoValor.TabIndex = 7;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(206, 105);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 22);
            this.textoSaldo.TabIndex = 6;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(206, 63);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 22);
            this.textoNumero.TabIndex = 5;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(206, 26);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 22);
            this.textoTitular.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titular";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboContas);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(31, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(552, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busca de conta";
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(187, 48);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 24);
            this.comboContas.TabIndex = 1;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Escolha de conta";
            // 
            // botaoNovaConta
            // 
            this.botaoNovaConta.Location = new System.Drawing.Point(74, 454);
            this.botaoNovaConta.Name = "botaoNovaConta";
            this.botaoNovaConta.Size = new System.Drawing.Size(116, 23);
            this.botaoNovaConta.TabIndex = 2;
            this.botaoNovaConta.Text = "Nova Conta";
            this.botaoNovaConta.UseVisualStyleBackColor = true;
            this.botaoNovaConta.Click += new System.EventHandler(this.botaoNovaConta_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 499);
            this.Controls.Add(this.botaoNovaConta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoSaque;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.TextBox textoValor;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button botaoNovaConta;
    }
}

