Console.WriteLine(@$"

------------------------------
|    Bem vindo ao programa   |
|     calculo de pontos      |
------------------------------
");


Console.WriteLine($"Digite os ponto do time A");
int timeA = int.Parse (Console.ReadLine()!);

Console.WriteLine($"Digite os ponto do time B");
int timeB = int.Parse (Console.ReadLine()!);

if (timeA > timeB)
{
    Console.WriteLine($"Vitória Time A!");

} else if ( timeB > timeA)
{
    Console.WriteLine($"Vitória Time B!");

} else {
    Console.WriteLine($"Empate!");
    
};

