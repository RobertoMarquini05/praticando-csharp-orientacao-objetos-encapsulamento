using Desafio04;

Funcionario f = new Funcionario("Fernanda Lima", 4000);

f.ReajustarSalario(3500); // Inválido
f.ReajustarSalario(4200); // Válido

f.ExibirDados();

Console.ReadKey();