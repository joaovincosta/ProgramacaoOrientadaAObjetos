// See https://aka.ms/new-console-template for more information

using ClassesAbstratasEPolimorfismo;

Console.WriteLine("Aprendendo OOP!");

AnalistaDeTI analistaDeTI = new AnalistaDeTI();
Gerente gerente = new Gerente();
GerenteDeAgencia gerenteDeAgencia = new GerenteDeAgencia();
GerenteDeTI gerenteDeTI = new GerenteDeTI();

analistaDeTI.Nome = "João Vinícius";
analistaDeTI.Salario = 3000;

Console.WriteLine("Salario do Analista de TI é de: " + analistaDeTI.Salario);

analistaDeTI.Reajustar();

Console.WriteLine("Salario do Analista de TI reajustado é de: " + analistaDeTI.Salario);

Console.WriteLine("-----------------------------------------------------------");

gerente.Nome = "Amanda Waller";
gerente.Salario = 8000;

Console.WriteLine("Salario do Gerente é de: " + gerente.Salario);

gerente.Reajustar();

Console.WriteLine("Salario do Gerente reajustado é de: " + gerente.Salario);

Console.WriteLine("-----------------------------------------------------------");

gerenteDeAgencia.Nome = "Jim Hoper";
gerenteDeAgencia.Salario = 10000;

Console.WriteLine("Salario do Gerente de Agencia é de: " + gerenteDeAgencia.Salario);

gerenteDeAgencia.Reajustar();

Console.WriteLine("Salario do Gerente de Agencia reajustado é de: " + gerenteDeAgencia.Salario);

Console.WriteLine("-----------------------------------------------------------");

gerenteDeTI.Nome = "Chloe Sullivan";
gerenteDeTI.Salario = 8000;

Console.WriteLine("Salario do Gerente de TI é de: " + gerenteDeTI.Salario);

gerenteDeTI.Reajustar();

Console.WriteLine("Salario do Gerente de TI reajustado é de: " + gerenteDeTI.Salario);




/* ContaPoupanca contaPoupanca = new ContaPoupanca(112, 0);

contaPoupanca.Deposita(100);
contaPoupanca.Saca(10);

double saldo = contaPoupanca.ConsultaSaldoDisponivel();

contaPoupanca.MostrarNumeroDaConta();

Console.WriteLine("Saldo da conta poupanca é: " + saldo);

Conta conta = new Conta(113, 100);

conta.Deposita(500);
conta.Saca(140);

double saldoContaCorrente = conta.ConsultaSaldoDisponivel();
Console.WriteLine("Saldo da conta corrente é: " + saldoContaCorrente); */





/* Conta conta1 = new Conta(123, 500);
Conta conta2 = new Conta(456, 600);
Conta conta3 = new Conta(789, 700);

Console.WriteLine("Total de contas criadas: " + Conta.TotalContasCriadas);

int total = Conta.ProximoTotalContasCriadas();

Console.WriteLine("Proximo total de contas criadas: " + Conta.ProximoTotalContasCriadas); */





/* // Criando um objeto de cada classe

CartaoDeCredito cdc = new CartaoDeCredito();
Cliente c = new Cliente();

// Adicionando nome do cliente
c.Nome = "João Vini. Costa";

// Adicionando número e data de validade do cartão

cdc.Numero = "122436";
cdc.DataDeValidade = "03/2027";
cdc.Cliente = c;

Console.WriteLine("O nome do cliente è: " + c.Nome);
Console.WriteLine("O número do cartão è: " + cdc.Numero);
Console.WriteLine("A data de validade do cartão è: " + cdc.DataDeValidade);
Console.WriteLine("O nome do cliente do agregado è: " + cdc.Cliente.Nome); */





/* Conta conta = new Conta(123, 300);

// conta.AdicionarLimite(1500);

conta.Deposita(1500);
conta.Deposita(2500);
conta.Deposita(4500);

bool saca = conta.Saca(7000);

if (saca)
{
    double saldo = conta.ConsultaSaldoDisponivel();

    Console.WriteLine("Seu saldo é de: " + saldo);
    Console.WriteLine("Seu limite é de: " + conta.Limite);
    Console.WriteLine("O número da sua conta é: " + conta.Numero);
} */