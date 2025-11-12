using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Corrente : Conta
    {
        public Corrente(string agencia, string contaNumero, string nomeTitular) : base(agencia, contaNumero, nomeTitular)
        {

        }

        public override double CalcularImposto(double valor)
        {
            double imposto = valor * 0.15;
            return valor - imposto;
        }
    }
}
