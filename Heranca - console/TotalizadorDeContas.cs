using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___console
{
    public class TotalizadorDeContas
    {
        public double valorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            valorTotal += conta.Saldo;
            //conta.CalculaRendimento();
        }
    }
}
