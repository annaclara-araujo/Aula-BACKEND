﻿// Herança
// Abstração
// Encapsulamento
// Polimorfismo

using PilaresPOO.Classes.Aprendizagem;

// // Pessoa fernanda = new Pessoa();
// // fernanda.nome = "Fernanda";
// // fernanda.idade = 5;

// // Console.WriteLine($"{fernanda.nome} Nasceu com {fernanda.idade} anos.");

// Professor sam = new Professor(123321);
// sam.nome = "Samanta";
// sam.idade = 22;
// sam.curso = "Dev";

// Aluno fefe = new Aluno();
// fefe.matricula = 11111;
// fefe.curso = "Dev";
// fefe.media = 8.5f;



// // exibir dados
// Console.WriteLine($"Curso: {sam.curso}");
// Console.WriteLine($"Professor: {sam.nome}");
// Console.WriteLine($"Identificação do professor:{sam.NIF}");

// Console.WriteLine($"");



// Console.WriteLine($"Aluno: {fefe.nome}");
// Console.WriteLine($"Idade: {fefe.idade}");
// Console.WriteLine($"Matricula: {fefe.matricula}");
// Console.WriteLine($"Curso: {fefe.curso}");
// Console.WriteLine($"Media: {fefe.media}");


Carro carro = new Carro();
carro.marca = "Honda";
carro.modelo = "Honda cit";
carro.cor = "preto";
carro.potencia = 1.8f;
carro.qtdPassageiros = 3;
carro.qtdPortas = 4;


Moto moto = new Moto();
moto.marca = "Yamaha";
moto.modelo = "Mt";
moto.cor = "roxa";
moto.potencia = 849f;
moto.qtdPassageiros = 2;



Aviao aviao = new Aviao();
aviao.marca = "Airbus";
aviao.modelo = "Airbus X";
aviao.cor = "branca";
aviao.potencia = 165f;
aviao.qtdPassageiros = 65;
aviao.qtdPortas = 2;


// exibir dados

Console.WriteLine(@$"
Veiculo: Carro 
Modelo: {carro.modelo}
Cor: {carro.cor}
Potencia: {carro.potencia}
qtd de passageiros: {carro.qtdPassageiros}
qtd de portas: {carro.qtdPortas}
");
Console.WriteLine($"");

Console.WriteLine(@$"
Veiculo: Moto 
Modelo: {moto.modelo}
Cor: {moto.cor}
Potencia: {moto.potencia}
qtd de passageiros: {moto.qtdPassageiros}
");
Console.WriteLine($"");

Console.WriteLine(@$"
Veiculo: Avião
Modelo: {aviao.modelo}
Cor: {aviao.cor}
Potencia: {aviao.potencia}
qtd de passageiros: {aviao.qtdPassageiros}
qtd de portas: {aviao.qtdPassageiros}
");