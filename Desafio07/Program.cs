using Desafio07;

Agenda agenda = new Agenda("Marina Souza");

agenda.AdicionarContato(new Contato("Carlos", "11998887777"));
agenda.AdicionarContato(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContato(new Contato("Julia", "21988776655"));

agenda.ListarContatos();

Console.ReadKey();