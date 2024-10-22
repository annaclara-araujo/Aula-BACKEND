//variaveis e tipos de dados
//estruturas condicionais 
// lacos de repeticao
// arrays
//clw


/*Console.WriteLine($"Olá, seja bem-vindo");
Console.WriteLine($"Iremos iniciar seu cadastro!\n"); */

Console.WriteLine(@"
 +................................................+
 .              Seja Bem-Vindo                    .
 +................................................+
 .         Iremos iniciar seu cadastro            .
 .................................................."
);

Console.WriteLine($"Digite seu nome:");
string nome = Console.ReadLine()!;
Console.WriteLine($"{nome}, digite seu sobrenome:");
string sobrenome = Console.ReadLine()!;

Console.WriteLine($"Digite o ano em que nasceu:");
int anoNascimento = int.Parse(Console.ReadLine()!);
int anoAtual = DateTime.Now.Year;
int idade = anoAtual - anoNascimento;
 
Console.WriteLine($"Digite seu e-mail:");
string email =  Console.ReadLine()!;


Console.WriteLine($" Digite seu telefone:");
int telefone = int.Parse (Console.ReadLine()!);


Console.WriteLine($" Digite seu cpf:");
string cpf = Console.ReadLine()!;


Console.WriteLine($"Digite seu endereço:");
string endereço =  Console.ReadLine()!;

Console.WriteLine($"Qual seu estado civil?");
string casado =  Console.ReadLine()!; 


Console.Clear();


Console.WriteLine($"Exibir Dados:\n");


Console.WriteLine($"{idade} \n");
Console.WriteLine($"{email}\n");
Console.WriteLine($"{telefone}\n");
Console.WriteLine($"{cpf}\n");
Console.WriteLine($"{endereço}\n");
Console.WriteLine($"{casado}\n");
Console.WriteLine($"Obrigada: {nome} {sobrenome}, cadastro concluido\n");

