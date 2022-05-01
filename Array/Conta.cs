using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Conta
    {
        public int Numero { get; set; }

        public double Saldo { get; set; }

        public Cliente Titular;

        public virtual void Depositar(double valor)
        {
            this.Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            this.Saldo -= valor;
        }

       /* public bool Transferir(double valor, Conta contaDestino)
        {
             
        }*/
    }
}
