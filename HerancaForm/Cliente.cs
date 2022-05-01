using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaForm
{
    public class Cliente
    {
        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }    
    }
}
