using Desafio10;

Hospede hospede = new Hospede("Juliana Moura");
Quarto quarto = new Quarto(101);
quarto.ValorDiaria = 250;

Reserva reserva = new Reserva(hospede, quarto, 3);

reserva.ExibirReserva();

Console.ReadKey();