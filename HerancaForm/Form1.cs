using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerancaForm
{
    public partial class Form1 : Form
    {
        //pra ser utiliza no form
        private Conta conta;
        private ContaPoupança contaP;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ContaPoupança contaP = new ContaPoupança();
            this.contaP = new ContaPoupança();
            contaP.Numero = 096;

            Cliente cliente = new Cliente("Pedro");
            contaP.Titular = cliente;

            textoTitular.Text = contaP.Titular.Nome;
            textoNumero.Text = Convert.ToString(contaP.Numero);
            textoSaldo.Text = Convert.ToString(contaP.Saldo);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorD = Convert.ToDouble(valorDigitado);
            this.contaP.Depositar(valorD);
            textoSaldo.Text = Convert.ToString(this.contaP.Saldo);
            MessageBox.Show("valor de deposito: R$ " + this.contaP.Saldo);
        }

        private void botaoSacar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorS = Convert.ToDouble(valorDigitado);
            this.contaP.Sacar(valorS);
            textoSaldo.Text = Convert.ToString(this.contaP.Saldo);
            MessageBox.Show("valor do Saque: R$ " + valorS);
            MessageBox.Show("Seu saldo atual é de: R$ " + this.contaP.Saldo);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
