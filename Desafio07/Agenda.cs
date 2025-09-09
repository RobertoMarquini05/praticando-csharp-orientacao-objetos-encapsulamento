using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    public class Agenda
    {
        public string Proprietario { get; private set; }

        private readonly List<Contato> contatos;

        public int QuantidadeContatos
        {
            get { return contatos.Count; }
        }

        public Agenda(string proprietario)
        {
            Proprietario = proprietario;
            contatos = new List<Contato>();
        }

        public bool AdicionarContato(Contato contato)
        {
            // Verifica se já existe contato com o mesmo nome
            if (contatos.Any(c => c.Nome == contato.Nome))
            {
                Console.WriteLine("Contato com esse nome já está na agenda.");
                return false;
            }

            contatos.Add(contato);
            return true;
        }

        public void ListarContatos()
        {
            Console.WriteLine($"Agenda de: {Proprietario}");
            Console.WriteLine("Contatos:");

            foreach (var c in contatos)
            {
                Console.WriteLine($"- {c.Nome} | {c.Telefone}");
            }

            Console.WriteLine($"Total de contatos: {QuantidadeContatos}");
        }
    }
}
