
using PilaresPOO.Classes.Pilares;
Console.Clear();


ContaCorrente ctEdu = new ContaCorrente();
ctEdu.Titular = "Eduardo Mendes da Costa";
ctEdu.BotaSaldoAi (1000);

Console.WriteLine($"Titular da Conta: {ctEdu.Titular}");
Console.WriteLine($"Saldo da Conta: {ctEdu.getSaldo()}");

float valorSacado = ctEdu.Sacar (120f);

Console.WriteLine($"Novo Saque: {valorSacado}");
Console.WriteLine($"Novo Saldo: R$ {ctEdu.getSaldo()}");
