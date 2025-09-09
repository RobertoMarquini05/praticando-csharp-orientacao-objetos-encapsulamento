using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    public class Quarto
    {
        public int Numero { get; private set; }

        private double valorDiaria;
        public double ValorDiaria
        {
            get { return valorDiaria; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("O valor da diária deve ser maior que zero.");
                valorDiaria = value;
            }
        }

        public Quarto(int numero)
        {
            Numero = numero;
        }
    }
}
