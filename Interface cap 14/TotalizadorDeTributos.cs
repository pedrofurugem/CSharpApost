using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_cap_14
{
    public class TotalizadorDeTributos
    {
        //Precisamos de	uma	classe que acumula o valor de todos os tributos	de todas as	contas do banco

        public double  Total { get; private set; }

        public void Acumula(contaPoupança cp)
        {
            Total = cp.CalculaTributo();
        }

        public void Acumula(contaInvestimento ci)
        {
            Total = ci.CalculaTributo();
        }

        public void Acumula(ITributavel t)
        {
            Total += t.CalculaTributo();
        }
    }
}


/*
 Interfaces	 são bem mais simples do que classes
Pois, Elas não tem atributos e seus métodos não	 tem
implementação. A interface apenas nos garante que o	
método existirá	naquela	classe.	Por	esse motivo,
apesar de C# não suportar herança múltipla	 
(ser filho	 de	mais	 de	 uma	 classe),	
podemos	implementar quantas	interfaces	quisermos.
Basta colocar uma na frente	da outra:

public	class	ContaInvestimento	:	Conta,	ITributavel,	OutraInterfaceQualquer
{
  //	implementa	os	métodos	das	interfaces	Tributavel	e	OutraInterfaceQualquer
}

 */