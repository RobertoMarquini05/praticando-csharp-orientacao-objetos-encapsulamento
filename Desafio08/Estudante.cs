using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio08
{
    public class Estudante
    {
        public string Nome { get; private set; }

        public double Nota1 { get; set; }
        public double Nota2 { get; set; }

        // Propriedade somente leitura que calcula a média
        public double Media
        {
            get { return (Nota1 + Nota2) / 2; }
        }

        // Propriedade somente leitura que calcula a situação
        public string Situacao
        {
            get { return Media >= 6 ? "Aprovado" : "Reprovado"; }
        }

        public Estudante(string nome)
        {
            Nome = nome;
        }

        public void ExibirBoletim()
        {
            Console.WriteLine($"Estudante: {Nome}");
            Console.WriteLine($"Média: {Media.ToString("N2", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Situação: {Situacao}");
        }
    }
}
