using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Conta
    {
       /* public Conta(int numero)
        {
            this.Numero = numero;
        }

        public Conta()
        {

        } */

        public Conta(int numero, double limite) 
        {
            this.Numero = numero;
            this.Limite = limite;
        }

        private double Saldo { get; set; } // o "private" está indicando que o atributo Saldo não é público, e sim privado, e que só a class pode acessa-lo
        public double Limite { get; private set; } // o "private" está indicando que o atributo Saldo não é público para ter algum valor adicionado 
        public int Numero { get; private set; }


        // Criando um método
        public void Deposita(double valor) // o "void" significa que esse método não vai retornar nada
        {
            this.Saldo += valor; // o "this" serve para pegar todas as informações dentro duma class e manipular esses valores
        }

        public bool Saca(double valor)
        {
            double SaldoDisponivel = this.ConsultaSaldoDisponivel();

            if (valor < SaldoDisponivel)
            {
                Console.WriteLine("Saque e saldo indisponìvel");
                return false;
            }

            this.Saldo -= valor;
            return true;
        }

        public void AdicionarLimite(double valor)
        {
            this.Limite = valor;
        }

        public double ConsultaSaldoDisponivel()
        {
            return this.Saldo + this.Limite;
        }
    }
}
