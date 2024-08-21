using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEAtributosEstaticos
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
            Conta.TotalContasCriadas ++;
        }

        private double Saldo { get; set; } // o "private" está indicando que o atributo Saldo não é público, e sim privado, e que só a class pode acessa-lo
        public double Limite { get; private set; } // o "private" está indicando que o atributo Saldo não é público para ter algum valor adicionado 
        public int Numero { get; private set; }

        public static int TotalContasCriadas { get; private set; } // o "static" faz com que um método ou atributo faça parte da classe, ao invés de fazer parte da instância do objeto

        public static int ProximoTotalContasCriadas()
        {
            return Conta.TotalContasCriadas + 1;
        }

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
