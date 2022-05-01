using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_cap_14
{
    public class contaCorrente : Conta, ITributavel
    {
        public override void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            this.Saldo -= (valor - 0.5);
        }

        //a pedido do exercício, pois conta corrente não havia calculo de tributo
        public double CalculaTributo()
        {
            return this.Saldo * 0.05;
        }
    }
}
