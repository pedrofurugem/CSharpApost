using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //	chama	o	comportamento	escrito	no	pai
            //	O	Saldo	termina	em	100.0	depois	dessa	linha

            Conta c = new Conta();
            //ContaPoupança c = new ContaPoupança();
            c.Depositar(100.0);
            Console.WriteLine("valor depositado: " + c.Saldo);

            //	chama	o	comportamento	escrito	na	ContaPoupanca
            //	O	Saldo	termina	com	o	valor	49.90
            c.Sacar(50);
            Console.WriteLine("valor sacado: " + c.Saldo);

            Conta c1 = new Conta();
            Conta c2 = new Conta();
            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Soma(c1);
            t.Soma(c2);

            Console.ReadLine();
        }
    }
}
