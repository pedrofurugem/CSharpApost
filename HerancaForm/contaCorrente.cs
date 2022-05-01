using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    public class contaCorrente : Conta
    {
        public override void Sacar(double valorS)
        {
            this.Saldo -= (valorS + 0.05);
        }

        public override void Depositar(double valorD)
        {
            this.Saldo += valorD;
        }
    }
}
