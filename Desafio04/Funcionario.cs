using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class Funcionario
    {
        public string Nome { get; private set; }

        private double salario;

        // Propriedade só de leitura
        public double Salario
        {
            get { return salario; }
        }

        public Funcionario(string nome, double salarioInicial)
        {
            Nome = nome;
            salario = salarioInicial;
        }

        public void ReajustarSalario(double novoValor)
        {
            if (novoValor <= salario)
            {
                Console.WriteLine("Erro: O novo salário deve ser maior que o atual.");
            }
            else
            {
                salario = novoValor;
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Funcionário: {Nome}");
            Console.WriteLine($"Salário atual: {Salario.ToString("C", new CultureInfo("pt-BR"))}");
        }
    }
}
