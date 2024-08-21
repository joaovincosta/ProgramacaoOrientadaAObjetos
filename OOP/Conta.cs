using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Conta // É necessário esse modificador "public" para que a classe fique visível
    {
        public double Saldo { get; set; } // "get" indica que o atributo Saldo pode ser acessado, e o "set" indica que o atributo Saldo pode ter algum valor adicionado
        public double Limite { get; set; }
        public int Numero { get; set; }
    }
}
