using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class FormCadastroConta : Form
    {   //modificando a instancia da classe para receber o Form principal
        private Form1 formPrincipal;

        public FormCadastroConta(Form1 formPrincipal){
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {

        }

        private void botaoCadastro_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente();
            novaConta.Titular = new Cliente(textoTitular.Text); //mantem texto
            novaConta.Numero = Convert.ToInt32(textoNumero.Text); //converte para inteiro

            //Precisamos utilizar esse novo	método dentro do
            //formulário	de cadastro para cadastrar a nova conta
            this.formPrincipal.AdicionaConta(novaConta);
        }
    }
}
