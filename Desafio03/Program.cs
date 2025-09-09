using Desafio03;

Paciente paciente = new Paciente("Luiz Costa", 42);
HistoricoMedico historico = new HistoricoMedico("XPT-9987");

Console.WriteLine($"Paciente: {paciente.Nome}, Idade: {paciente.Idade}");
historico.ExibirCodigo();

Console.ReadKey();