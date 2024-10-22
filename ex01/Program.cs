
Console.WriteLine(@$"

------------------------------
|    Bem vindo ao programa   |
|        orçamento           |
------------------------------
");




Console.WriteLine($"Digite seu salario");
float salario = float.Parse (Console.ReadLine()!);

Console.WriteLine($"Digite quanto gastou este mes");
float gasto = float.Parse (Console.ReadLine()!)

if (gasto > salario)
{
    Console.WriteLine($"Limite alcançado, orçamento estourado");
    
}else {
    Console.WriteLine($"Limite dentro do orçamento");
}


