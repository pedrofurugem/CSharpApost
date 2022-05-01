using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    //os	construtores da classe  pai não são herdados
    public class ContaPoupança : Conta
    {
        public override void Sacar(double valorP)
        {
            this.Saldo -= (valorP + 0.10); //para sacar se cobram 10 centavos
        }

        public override void Depositar(double valorD)
        {
            this.Saldo += valorD;
        }
    }
}

//a classe pai deve ter construtor  TESTAR A BASE DEPOIS
/*
public class ContaPoupanca : Conta
{
    //	nesse	código	o	c#	chamará	o	construtor	sem	argumentos	da	classe	Conta.
    public ContaPoupanca(int numero)
    {
        this.Numero = numero;
    }
}*/