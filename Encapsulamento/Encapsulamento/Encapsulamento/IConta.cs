﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public interface IConta
    {
        void Deposita(double valor);
        bool Saca(double valor);
        void AdicionarLimite(double valor);
        double ConsultaSaldoDisponivel();
    }
}
