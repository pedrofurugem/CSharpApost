using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrandoNovasContas
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        private int numeroDeContas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //mudar o numero de contas do array
            this.contas = new Conta[10];

            //vamos	inicializar	algumas	instâncias	de	Conta.
            /*
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Pedro Roberto");
            this.contas[0].Numero = 1;
            this.numeroDeContas++;

            this.contas[1] = new contaPoupança();
            this.contas[1].Titular = new Cliente("Paulo Roger");
            this.contas[1].Numero = 2;
            this.numeroDeContas++;

            this.contas[2] = new contaCorrente();
            this.contas[2].Titular = new Cliente("Vinny Honda");
            this.contas[2].Numero = 3;
            this.numeroDeContas++;
            */

            //	vamos	inicializar	algumas	instâncias	de	Conta.
            Conta c1 = new Conta();
            c1.Titular = new Cliente("Pedro Roberto");
            c1.Numero = 1;
            this.AdicionaConta(c1);

            Conta c2 = new contaPoupança();
            c2.Titular = new Cliente("Paulo Roger");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new contaCorrente();
            c3.Titular = new Cliente("Vinny Honda");
            c3.Numero = 3;
            this.AdicionaConta(c3);


            /* comboContas.Items.Add(contas[0].Titular.Nome);
             comboContas.Items.Add(contas[1].Titular.Nome);
             comboContas.Items.Add(contas[2].Titular.Nome);*/

            /*foreach (Conta conta in contas)
            {
                comboContas.Items.Add("titular: " + conta.Titular.Nome);
            }*/
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            //	primeiro	precisamos	recuperar	o	índice	da	conta	selecionada
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            //	e	depois	precisamos	ler	a	posição	correta	do	array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Depositar(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            //	primeiro	precisamos	recuperar	o	índice	da	conta	selecionada
            int indice = Convert.ToInt32(comboContas.SelectedIndex);
            //	e	depois	precisamos	ler	a	posição	correta	do	array.
            Conta selecionada = this.contas[indice];
            double valor = Convert.ToDouble(textoValor.Text);
            selecionada.Sacar(valor);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        //atributo que representa o numero de contas cadastradas
        public void AdicionaConta(Conta conta)
        {
            this.contas[this.numeroDeContas] = conta;
            this.numeroDeContas++;
            
            //registrar	a conta no comboContas
            comboContas.Items.Add("titular: " + conta.Titular.Nome);
        }

        private void botaoNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroConta formularioDeCadastro = new FormCadastroConta(this);
            formularioDeCadastro.ShowDialog();
        }
    }
}
