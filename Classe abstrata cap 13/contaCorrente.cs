using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_abstrata_cap_13
{
    public class contaCorrente : Conta
    {
        public override void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public override void Sacar(double valor)
        {
            this.Saldo -= (valor - 0.5);
        }
    }
}
