//Importando as classes de dentro da pasta Classes
/*using System.Net.Http.Headers;*/
using ClasseObjeto.Classes;

//cria o objeto/variavel animal
Animal cachorro = new Animal();

cachorro.nome = "Spaik";
cachorro.raca = "Golden";
cachorro.cor = "caramelo";
cachorro.idade = 5;


Console.Clear();
Console.WriteLine($"Bem-Vindo ao programa ZooSharp **");
Console.WriteLine($"");
Console.WriteLine($"Nome do cachorro: {cachorro.nome}");
Console.WriteLine($"Raca do {cachorro.nome}: {cachorro.raca}");
Console.WriteLine($"Cor do {cachorro.nome}: {cachorro.cor}");
Console.WriteLine($"Idade do {cachorro.nome}: {cachorro.idade}");

Console.WriteLine($"");
Console.WriteLine($"");



Animal pato =  new Animal();

pato.nome = "Duck";
pato.raca = "Crested";
pato.cor = "Branco";
pato.idade = 2;

Console.WriteLine($"Nome do pato: {pato.nome}");
Console.WriteLine($"Raca do {pato.nome}: {pato.raca} ");
Console.WriteLine($"Cor do {pato.nome}: {pato.cor}");
Console.WriteLine($"Idade do {pato.nome}: {pato.idade}");
 
Console.WriteLine($"");

pato.Envelhecer ();
Console.WriteLine($"A nova idade do {pato.nome} é: {pato.idade}");
cachorro.Envelhecer ();
Console.WriteLine($"A nova idade do {cachorro.nome} é: {cachorro.idade}");

Console.WriteLine($"");

pato.FazerBarulho ("Quak-Quak"); 
cachorro.FazerBarulho("Au au");

