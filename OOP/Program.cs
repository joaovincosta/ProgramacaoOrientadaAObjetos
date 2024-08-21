// See https://aka.ms/new-console-template for more information
using OOP;

Console.WriteLine("Aprendendo OOP!");

Conta conta1 = new Conta(); // Criando um objeto ao criar uma instância da class Conta

Conta conta2 = new Conta(); // Criando 2º instância da conta

// Atribuindo valores para a conta 1
conta1.Saldo = 1500;
conta1.Limite = 500;
conta1.Numero = 123;

// Atribuindo valores para a conta 2
conta2.Saldo = 2500;
conta2.Limite = 700;
conta2.Numero = 456;

Console.WriteLine("Olá, Beltrano! Seu saldo em conta é de: " + conta1.Saldo + " reais");
Console.WriteLine("Limite de saque: " + conta1.Limite + " reais");
Console.WriteLine("O número de sua conta é: " + conta1.Numero);

Console.WriteLine("________________________________________________________________________");

Console.WriteLine("Olá, Ciclano! Seu saldo em conta é de: " + conta2.Saldo + " reais");
Console.WriteLine("Limite de saque: " + conta2.Limite + " reais");
Console.WriteLine("O número de sua conta é: " + conta2.Numero);