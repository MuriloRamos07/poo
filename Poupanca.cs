using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Poupanca : Conta
    {
        public Poupanca(string agencia, string contaNumero, string nomeTitular) : base(agencia, contaNumero, nomeTitular)
        {

        }

        public override double CalcularImposto(double valor)
        {
            double imposto = valor * 0.06;
            return valor - imposto;
        }
    }
}
