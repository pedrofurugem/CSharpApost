namespace Array
{
    partial class FormCadastroConta
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
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(148, 56);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 22);
            this.textoNumero.TabIndex = 0;
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(148, 105);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 22);
            this.textoTitular.TabIndex = 1;
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.Location = new System.Drawing.Point(107, 75);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(0, 16);
            this.Numero.TabIndex = 2;
            // 
            // Num
            // 
            this.Num.AutoSize = true;
            this.Num.Location = new System.Drawing.Point(52, 59);
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(55, 16);
            this.Num.TabIndex = 3;
            this.Num.Text = "Numero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Titular";
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(133, 154);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(115, 23);
            this.botaoCadastro.TabIndex = 5;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 221);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.textoNumero);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.Label Num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoCadastro;
    }
}