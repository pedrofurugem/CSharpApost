using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    public class ContaPoupanca : Conta
    {
        public override void Sacar(double valor)
        {
            this.Saldo -= (valor += 0.10);
        }
    }
}
