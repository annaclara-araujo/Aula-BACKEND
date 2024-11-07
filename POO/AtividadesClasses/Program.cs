using AtividadesClasses.Classes;

Console.WriteLine($"Bem-Vindo ao programa VeiculosSharp ** ");
Console.WriteLine($"");

Veiculo carro1 = new Veiculo();

Console.WriteLine($"Digite a marca do carro:");
carro1.marca = Console.ReadLine();

Console.WriteLine($"Digite o modelo do carro:");
carro1.modelo = Console.ReadLine();

Console.WriteLine($"Digite a cor do carro:");
carro1.cor = Console.ReadLine();

Console.WriteLine($"Digite a potencia do carro:");
carro1.potencia = float.Parse (Console.ReadLine());

Console.WriteLine($"Digite o numero de portas do quarto:");
carro1.qtdPortas = int.Parse (Console.ReadLine());

Console.WriteLine($"{carro1.modelo}acelerando");
carro1.Acelerar();
Console.WriteLine($"");

Console.WriteLine($"{carro1.modelo}freiando");
carro1.Freiar();
Console.WriteLine($"");

Console.WriteLine($"{carro1.modelo}ligando");
carro1.Ligar();
Console.WriteLine($"");

Console.WriteLine($"{carro1.modelo}desligando");
carro1.Desligar();
Console.WriteLine($"");









Console.WriteLine($"");
Console.WriteLine($"");
Console.WriteLine($"{carro1.marca}");
Console.WriteLine($"{carro1.modelo}");
Console.WriteLine($"{carro1.cor}");
Console.WriteLine($"{carro1.potencia}");
Console.WriteLine($"{carro1.qtdPortas}");





 
