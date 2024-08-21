// See https://aka.ms/new-console-template for more information
using MetodosEAtributosEstaticos;

Console.WriteLine("Aprendendo OOP!");

Conta conta1 = new Conta(123, 500);
Conta conta2 = new Conta(456, 600);
Conta conta3 = new Conta(789, 700);

Console.WriteLine("Total de contas criadas: " + Conta.TotalContasCriadas);

int total = Conta.ProximoTotalContasCriadas();

Console.WriteLine("Proximo total de contas criadas: " + Conta.ProximoTotalContasCriadas);





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