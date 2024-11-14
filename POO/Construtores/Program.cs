using Construtores.Classes;


// Construtores
Aluno2 annaAraujo = new Aluno2 ("Anna Clara Araujo");
annaAraujo.cpf = 4321;

Aluno2 ferMarques = new Aluno2 ("Fernanda Marques ");
ferMarques.cpf = 1234;

Aluno2 eduCosta = new Aluno2 ();




Console.WriteLine(annaAraujo.name);
Console.WriteLine(annaAraujo.cpf);

Console.WriteLine(ferMarques.name);
Console.WriteLine(ferMarques.cpf);

Console.WriteLine(eduCosta.name);
Console.WriteLine(eduCosta.cpf);


















// Veiculo carro1 = new Veiculo("Ford", "Ka", 2000, "Vermelho");
// Veiculo carro2 = new Veiculo("Ford", "Mustang", 1997, "Azul");
// carro1.ExibirDados ();
// carro2.ExibirDados ();



// Aluno aluno= new Aluno("Anna",17,"Realizada"); 
// aluno.ExibirDados ();

// do
// {
//     Console.WriteLine($"*** Bem vindo ao Programa Jogos ***");
//     Console.WriteLine(
//         @$"Menu de Opções:
//     1) Cadastrar Jogo
//     2) Listar Jogos
//     0) sair ");

//     Console.WriteLine($"Escolha a opção que deseja");
//     int opção = int.Parse(Console.ReadLine()!);

//     if (opção == 1)
//         Console.WriteLine($"Qual o nome do jogo?");
//     string nome = Console.ReadLine()!;
//     Console.WriteLine($"Qual a data de lancamento do jogo?");
//     string Lançamento = Console.ReadLine()!;
//     Console.WriteLine($"Qual o genero do jogo?");
//     string Genero = Console.ReadLine()!;
//     Console.WriteLine($"Qual o valor do jogo?");
//     int Valor = int.Parse(Console.ReadLine()!);

// else if (opção == 2)
//     {

//     }








// }




















// List<Jogo> jogoList = new List<Jogo>();

// Jogo jogo1 = new Jogo("GTA","20/10/26",52.00f,"Ação");
// jogo1.ExibirDados ();
// Jogo jogo2 = new Jogo("SpiderMan","30/05/28",70.00f,"Ação");
// jogo2.ExibirDados ();
// Jogo jogo3 = new Jogo("Barbie","31/05/28",90.00f,"Moda");
// jogo3.ExibirDados ();
// Jogo jogo4 = new Jogo("Monkey","24/06/29",35.00f,"Ação");
// jogo4.ExibirDados ();

// //cadastrar o nome de cada jogo cadastrado 
// jogoList.Add (jogo1);
// jogoList.Add (jogo2);
// jogoList.Add (jogo3);
// jogoList.Add (jogo4);



// foreach (Jogo jogo in jogoList)
// {
//     //  Console.WriteLine($"Jogo: {jogo.Nome}");
//     //  Console.WriteLine($"");
//     //  Console.WriteLine($"Lançamento: {jogo.Lançamento}");
//     // Console.WriteLine($"");
//     // Console.WriteLine($"Valor: {jogo.Valor}");

//     jogo1.ExibirDados ();
//     jogo2.ExibirDados ();
//     jogo3.ExibirDados ();
//     jogo4.ExibirDados ();

// }