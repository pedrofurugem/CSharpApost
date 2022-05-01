using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_abstrata_cap_13
{
    public partial class FormCadastroConta : Form
    {
        /*Precisamos acessar a instância	 de	 	Form1 
          a partir	 de	FormCadastroConta.	 Queremos
         garantir	que,	na	construção	do	FormCadastroConta	,	
         teremos	a	instância	de		Form1, portanto	vamos
         modificar	o	construtor	da	classe	para	receber	o	formulário	principal.
        */

        private Form1 formPrincipal;
        public FormCadastroConta(Form1 formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }


        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta = new contaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);

            this.formPrincipal.AdicionaConta(novaConta);
        }

        
    }
}
