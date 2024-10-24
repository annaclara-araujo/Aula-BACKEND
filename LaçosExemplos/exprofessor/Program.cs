
Console.WriteLine(@"

+--------------------------------------+
|            SEJA BEM-VINDO            |
|             AO PROGRAMA              |
|               ESPORTES               |
+--------------------------------------+
");


int qtdMulher = 0;
int qtdHomem = 0;
int qtdEsporte = 0;
int qtdNaoGosta = 0;

Console.WriteLine($"Quantas pessoas tem na sua mesa");
int Entrevistados = int.Parse (Console.ReadLine()!);


for (int i = 1; i <= Entrevistados; i++)
{
    Console.WriteLine($"Qual o seu sexo? f/m?");
    string sexo = Console.ReadLine ();
    

    if (sexo == "f")
    {
        qtdMulher++;
    }
    else
    {
        qtdHomem++;
    }


Console.WriteLine($"Voce gosta de esporte? s/n?");
    string esporte = Console.ReadLine ();
    
    if (esporte == "s")
    {
        qtdEsporte ++;
    }
    else
    {
        qtdNaoGosta ++;
    }

} // fim do for

float percentual = (100 / Entrevistados) * qtdEsporte;


Console.WriteLine($"Quantidade de Mulheres: {qtdMulher}");
Console.WriteLine($"Quantidade de Homens: {qtdHomem}");
Console.WriteLine($"Quantidade de Entrevistados: {qtdMulher + qtdHomem}");
Console.WriteLine($"Pessoas que gostam de esporte: {qtdEsporte}");
Console.WriteLine($"Pessoas que não gostam de esporte: {qtdNaoGosta}");
Console.WriteLine($"Percentual de pessoas que não gostam: {percentual}%");