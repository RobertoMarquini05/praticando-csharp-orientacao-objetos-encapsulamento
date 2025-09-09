using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    public class Hospede
    {
        public string Nome { get; private set; }

        public Hospede(string nome)
        {
            Nome = nome;
        }
    }
}
