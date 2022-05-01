using Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cadastroContas2
{
    public partial class Form1 : Form
    {
        private Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[3];

            //vamos	inicializar	algumas	instâncias	de	Conta.
            this.contas[0] = new Conta();
            this.contas[0].Titular = new Cliente("Pedro Roberto");
            this.contas[0].Numero = 1;

            this.contas[1] = new contaPoupança();
            this.contas[1].Titular = new Cliente("Paulo Roger");
            this.contas[1].Numero = 2;

            this.contas[2] = new contaCorrente();
            this.contas[2].Titular = new Cliente("Vinny Honda");
            this.contas[2].Numero = 3;


           /* comboContas.Items.Add(contas[0].Titular.Nome);
            comboContas.Items.Add(contas[1].Titular.Nome);
            comboContas.Items.Add(contas[2].Titular.Nome);*/

            foreach (Conta conta in contas)
            {
                comboContas.Items.Add("titular: " + conta.Titular.Nome);
            }
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
    }
}
