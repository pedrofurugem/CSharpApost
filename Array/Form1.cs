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
    public partial class Form1 : Form
    {
        private Conta[] contas;
        //guarda o número de contas	que	já foram cadastradas
        private int numeroDeContas;
        private object formPrincipal;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             contas = new Conta[10];

             this.contas[0] = new Conta();
             this.contas[0].Titular = new Cliente("Pedro");
             this.contas[0].Numero = 1;  
             this.numeroDeContas++;

            /* 
               Conta c1	= new Conta();
               c1.Titular =	new	Cliente("victor")
               c1.Numero = 1;
               this.AdicionaConta(c1);
            */


             this.contas[1] = new ContaPoupança();
             this.contas[1].Titular = new Cliente("Paulo Rogerio");
             this.contas[1].Numero = 2;
             this.numeroDeContas++;

            /*	
              Conta c2 = new ContaPoupanca();
			  c2.Titular = new Cliente("mauricio");
			  c2.Numero = 2;
			  this.AdicionaConta(c2);
            */

             this.contas[2] = new ContaCorrente();
             this.contas[2].Titular = new Cliente("Vinny");
             this.contas[2].Numero = 3;
             this.numeroDeContas++;

            /*
              Conta c3 = new ContaCorrente();
		      c3.Titular = new Cliente("osni");
			  c3.Numero =	3;
			  this.AdicionaConta(c3);
             */

            ///REFAZER O APP, pois não indentificamos o problema

            /*
              comboContas.Items.Add(contas[0].Titular.Nome);
              comboContas.Items.Add(contas[1].Titular.Nome);
              comboContas.Items.Add(contas[2].Titular.Nome);
            */

            foreach (Conta conta in contas)
            {
               comboContas.Items.Add("titular: " + conta.Titular.Nome);
            }
        }

        /* private void botaoBusca_Click(object sender, EventArgs e)
         {
             int indice = Convert.ToInt32(textoIndice.Text);
             Conta selecionada = this.contas[indice];
             textoTitular.Text = selecionada.Titular.Nome;
             textoNumero.Text = Convert.ToString(selecionada.Numero);
             textoSaldo.Text = Convert.ToString(selecionada.Saldo);

         }*/

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);       
        }

        private void botaoDeposito_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Depositar(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("valor depositado");
        }

        private void botaoSaque_Click(object sender, EventArgs e)
        {
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Sacar(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("valor sacado");
        }

        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            //Além	de	colocar	a conta no	array, precisamos	também	registrar a	conta no comboContas	.
            comboContas.Items.Add("Titular: " + conta.Titular.Nome);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            //	this representa	a instância	de Form1 que está sendo	utilizada pelo
            //	Windows	Form
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }
    }
}



/*int[] numeros = new int[5];
            numeros[0] = 1;
            numeros[1] = 600;
            numeros[2] = 257;
            numeros[3] = 12;
            numeros[4] = 42;
            MessageBox.Show("número	=	" + numeros[3]);*/

/*Conta[] contas = new Conta[5];
contas[0] = new Conta();
contas[1] = new ContaPoupança();*/

//imprimir todas as contas
/*for (int i = 0; i < contas.Length; i++)
{
    MessageBox.Show("saldo	=	" + contas[i].Saldo); //imprimi os saldos
}*/

/*foreach(Conta c in contas)
{
    MessageBox.Show("saldo	=	" + c.Saldo);
}*/
//escrevendo na mesma linha
/*int[] umAoCinco = new int[] { 1, 2, 3, 4, 5 };

MessageBox.Show("lista = " + umAoCinco[3]);*/


/*
 Convert.ToInt32 é utilizado para converter outros tipos de objeto 
(object, bool, string, etc) em um int, internamente ele utiliza int.
Parse, porem adicionando a feature de retornar zero se o valor 
convertido for null, no mais é igual ao int.
 */