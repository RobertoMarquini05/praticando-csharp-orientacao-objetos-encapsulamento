﻿using Desafio05;

Projeto projeto = new Projeto("Sistema de Inventário");

projeto.AdicionarTarefa("Criar tela de login");
projeto.AdicionarTarefa("Implementar banco de dados");

projeto.ExibirTarefas();

Console.ReadKey();