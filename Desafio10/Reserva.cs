using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    public class Reserva
    {
        private int diarias;

        public Hospede Hospede { get; private set; }
        public Quarto Quarto { get; private set; }

        public double ValorTotal
        {
            get { return diarias * Quarto.ValorDiaria; }
        }

        public Reserva(Hospede hospede, Quarto quarto, int diarias)
        {
            if (diarias <= 0)
                throw new ArgumentException("A quantidade de diárias deve ser maior que zero.");

            Hospede = hospede;
            Quarto = quarto;
            this.diarias = diarias;
        }

        public void ExibirReserva()
        {
            Console.WriteLine($"Reserva para: {Hospede.Nome}");
            Console.WriteLine($"Quarto: {Quarto.Numero}");
            Console.WriteLine($"Valor total: {ValorTotal.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}
