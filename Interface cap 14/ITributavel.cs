using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_cap_14
{
    public interface ITributavel
    {
        double CalculaTributo(); //apenas contaPoupança e contaInvestimento receberão este metodo
    }
}
