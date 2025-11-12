using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Conta
    {
        public string Agencia { get; set; }
        public string ContaNumero { get; set; }
        public string NomeTitular { get; set; }

        public Conta(string agencia, string contaNumero, string nomeTitular)
        {
            Agencia = agencia;
            ContaNumero = contaNumero;
            NomeTitular = nomeTitular;
        }
        public virtual double CalcularImposto(double valor)
        {
            double imposto = valor * 0.04;
            return valor - imposto;
        }
    }
}
