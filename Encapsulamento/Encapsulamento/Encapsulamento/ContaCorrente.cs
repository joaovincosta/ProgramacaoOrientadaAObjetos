﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, double limite) : base(numero, limite)
        {

        }
    }
}
