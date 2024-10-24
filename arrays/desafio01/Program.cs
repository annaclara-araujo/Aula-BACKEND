// Faça um programa que carregue 1 array tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números pares.


int [] num = new int[6];

int numPar = 0;
int numImpar = 0;

for (int i = 0; i < num.Length; i++)
{
    Console.WriteLine($"Digite um numero:");
    num [i] = int.Parse(Console.ReadLine());


    if (num[i] %2 == 0)
    {
  
     numPar++;
     
    } else
    {
        numImpar++;
    }
}

Console.WriteLine($"Numeros pares: {numPar}");
Console.WriteLine($"Numeros impares: {numImpar}");