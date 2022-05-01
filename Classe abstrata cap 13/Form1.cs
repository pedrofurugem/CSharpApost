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
            this.contas = new Conta[10];

            /*Conta c1 = new Conta();
            c1.Titular = new Cliente("Pedro Roberto");
            c1.Numero = 1;
            this.AdicionaConta(c1);*/

            Conta c2 = new contaPoupança();
            c2.Titular = new Cliente("Paulo Roger");
            c2.Numero = 2;
            this.AdicionaConta(c2);

            Conta c3 = new contaCorrente();
            c3.Titular = new Cliente("Vinny Honda");
            c3.Numero = 3;
            this.AdicionaConta(c3);

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

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = contas[indice];
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            textoNumero.Text = Convert.ToString(selecionada.Numero);
        }

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
