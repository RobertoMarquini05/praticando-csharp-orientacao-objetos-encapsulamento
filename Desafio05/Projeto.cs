using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    public class Projeto
    {
        public string Nome { get; private set; }

        private List<string> tarefas;

        // Propriedade somente leitura
        public int QuantidadeTarefas
        {
            get { return tarefas.Count; }
        }

        public Projeto(string nome)
        {
            Nome = nome;
            tarefas = new List<string>();
        }

        public void AdicionarTarefa(string tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void ExibirTarefas()
        {
            Console.WriteLine($"Projeto: {Nome}");
            Console.WriteLine("Tarefas:");

            foreach (var tarefa in tarefas)
            {
                Console.WriteLine($"- {tarefa}");
            }

            Console.WriteLine($"Total: {QuantidadeTarefas} tarefas");
        }
    }
}
