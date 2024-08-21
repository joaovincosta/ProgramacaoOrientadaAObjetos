// See https://aka.ms/new-console-template for more information
using CriandoMetodos;

Console.WriteLine("Aprendendo OOP!");

Conta conta = new Conta();

conta.AdicionarLimite (1500);

conta.Deposita(1500);
conta.Deposita(2500);
conta.Deposita(4500);

bool saca = conta.Saca(7000);

if(saca)
{
    double saldo = conta.ConsultaSaldoDisponivel();

    Console.WriteLine("Seu saldo é de: " + saldo);
    Console.WriteLine("Seu limite é de: " + conta.Limite);
}