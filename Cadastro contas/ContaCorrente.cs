using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_contas
{
    public class ContaCorrente : Conta
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
