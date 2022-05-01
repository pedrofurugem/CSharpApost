using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_cap_14
{           //   classe filha : classe pai, Interface
    public class contaPoupança : Conta, ITributavel
    {
        public override void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            this.Saldo -= (valor - 0.10);
        }

        //método que sou obrigado a implementar
        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }
    }
}
