using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    internal class SegurancaConta
    {
        // Autoriza saques de até R$1000
        public bool ValidarSaque(double valor)
        {
            return valor > 0 && valor <= 1000;
        }
    }
}
