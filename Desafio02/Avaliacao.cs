using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    public class Avaliacao
    {
        public string Aluno { get; private set; }

        // Nota só pode ser lida fora da classe
        public double Nota { get; private set; }

        public Avaliacao(string aluno)
        {
            Aluno = aluno;
        }

        public void AtribuirNota(double nota)
        {
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("Erro: A nota deve estar entre 0 e 10.");
            }
            else
            {
                Nota = nota;
            }
        }

        public void ExibirResultado()
        {
            Console.WriteLine($"Aluno: {Aluno}");
            Console.WriteLine($"Nota atribuída: {Nota}");
        }
    }
}
