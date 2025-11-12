using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Colaborador
    {
        public string nome;
        // VIRUAL ATRIBUTO PRIVADO
        public virtual void CalcularValeAlimentacao(double salario)
        {
            double NovoSalario = salario * 1.25;

            Console.WriteLine("O novo salário é de: " + NovoSalario);
        }
        public virtual void CalcularImposto(double salario)
        {
            double imposto = salario * 0.15;
            double salarioLiquido = salario - imposto;

            Console.WriteLine("O salário é de: " + salarioLiquido);
        }
    }
}
