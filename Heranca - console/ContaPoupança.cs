using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___console
{
    public class ContaPoupança : Conta
    {
        public override void Sacar(double valor)
        {
            //this.Saldo -= (valor + 0.10);
            base.Sacar(valor + 0.10);
        }

        public void CalculaRendimento()
        {
            
        }


    }
}
