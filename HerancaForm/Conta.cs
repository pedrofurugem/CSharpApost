using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    public class Conta
    {
        public int Numero { set; get; }

        public double Saldo { set; get; } //protected

        public Cliente Titular { set; get; }

        public virtual void Depositar(double valorD)
        {
            this.Saldo += valorD;
        }

        public virtual void Sacar(double valorS)
        {
            this.Saldo -= valorS;
        }

    }
}