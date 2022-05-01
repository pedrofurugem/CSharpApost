using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_cap_14
{   //podemos	fazer	com	que	uma	classe	assine	uma	interface	sem	herdar	de	outra	classe

    //O	método CalculaTributos do SeguroDeVida deve	devolver um	valorconstante de 42 reais.

    public class SeguroDeVida : ITributavel
    {
        public double CalculaTributo() 
        {
            return  42.0;
        }
    }
}
