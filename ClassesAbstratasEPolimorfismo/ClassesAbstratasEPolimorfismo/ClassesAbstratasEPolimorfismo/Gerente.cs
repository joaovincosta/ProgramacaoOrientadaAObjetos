﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAbstratasEPolimorfismo
{
    public class Gerente : Funcionario
    {
        public override void Reajustar()
        {
            this.Salario += 1000;
        }
    }
}
