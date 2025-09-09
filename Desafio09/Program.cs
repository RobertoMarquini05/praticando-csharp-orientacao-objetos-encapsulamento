using Desafio09;

Curso curso = new Curso("Lógica de Programação", 2);

curso.Matricular(new Estudante("Rafaela"));
curso.Matricular(new Estudante("João"));
curso.Matricular(new Estudante("Mirela")); // excede o limite

curso.ListarMatriculados();

Console.ReadKey();