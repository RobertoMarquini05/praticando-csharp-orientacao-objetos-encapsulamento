using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio09
{
    public class Estudante
    {
        public string Nome { get; private set; }

        public Estudante(string nome)
        {
            Nome = nome;
        }
    }
}
