using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gerente : Colaborador
    {
        // OVERRIDE ATRIBUTO PUBLICO 
        public override void CalcularValeAlimentacao(double salario)
        {
            double vale = salario * 1.10;

            Console.WriteLine("O valor do seu vale é de: " + salario);
        }
        public override void CalcularImposto(double salario)
        {
            double salarioliquido = salario - (salario * 0.25);
            Console.WriteLine("O valor do Salário Líquido é de: " + salarioliquido);
        }
    }
}
