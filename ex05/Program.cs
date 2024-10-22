
Console.WriteLine(@$"

------------------------------
|    Bem vindo ao programa   |
|          maças             |
------------------------------
");


Console.WriteLine($"Digite a quantidade de maças compradas:");
float macas = float.Parse (Console.ReadLine());
float resultado;

if (macas < 12)
{
    resultado = macas * 0.30f;
    Console.WriteLine($"O valor total e de: {resultado}");
}else {
    resultado = macas * 0.25f;
    Console.WriteLine($"O valor total e de: {resultado}");
    
}