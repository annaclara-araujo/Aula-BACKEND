
// ex 01
// faça um programa que rode 10 vezes e pergunte o sexo das pessoas e ao final informe 

//quantidade de pessoas do sexo feminino
//quantidade de pessoas do sexo masculino 

//criar um laco de 10 repetiçoes
// dentro do laço pergunar os exo da pessoa
// se for homem contar na variavel homem
// se for mulher contar 



Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|         CONTADOR DE PESSOAS          |
+--------------------------------------+
");


int homem = 0;
int mulher = 0;
string sexo;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Qual o seu sexo?");
    sexo = Console.ReadLine();

    if(sexo == "feminino"){
        mulher++;
    }else{
        homem++;
    }
    
}

Console.WriteLine($"Quantidade de homem: {homem}");
Console.WriteLine($"Quantidade de mulher: {mulher}");

