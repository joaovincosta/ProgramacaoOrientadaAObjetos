using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasEPolimorfismo
{
    public class ContaPoupanca : Conta // Os dois pontos indicam que vai herdar alguma coisa, e depois se diz o que quer herdar 
    {
        public ContaPoupanca(int numero, double limite) : base(numero, limite)
        {
            this.Saldo = 0;
        }

        public void MostrarNumeroDaConta()
        {
            Console.WriteLine("A conta poupança é: " + this.Numero);
        }
    }
}
