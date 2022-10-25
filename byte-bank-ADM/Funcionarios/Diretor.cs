﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byte_bank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

       

    }
}