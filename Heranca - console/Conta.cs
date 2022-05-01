using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___console
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; private set; }  //Atributos/métodos	 marcados	 como	 	
     //private se ela não usa a prop Saldo          //protected		 são	 visíveis
                                                     //apenas para    a própria classe e   para	as	classes filhas
        public Cliente Titular { get; set; }

        public int Tipo { get; set; }

        public virtual void Sacar(double valor)
        {
           this.Saldo -= (valor + 0.10);  
        }

        public void Depositar(double valorOperacao)
        {
            this.Saldo += valorOperacao;
        }
    }
}
