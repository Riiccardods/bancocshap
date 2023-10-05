﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bancocshap.Models
{
    internal class ContaBancaria
    {
        public Titular Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(Titular titular, double saldoAbertura)
        {
            Titular = titular;
            Saldo = saldoAbertura;
        }



    }
}
