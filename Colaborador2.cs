using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Colaborador2
    {
        public virtual double CalcularSalario(double salario)
        {
            double descontoInss = salario * 0.14;
            return salario - descontoInss;
        }

        public double CalcularIRRF(double salarioDescontoInss)
        {
            double descontoIr = salarioDescontoInss * 0.02;
            return salarioDescontoInss - descontoIr;
        }
        public double CalcularSalarioLiquidoTotal(double salario)
        {
            double salarioAposInss = CalcularSalario(salario);
            double salarioLiquido = CalcularIRRF(salarioAposInss);
            return salarioLiquido;
        }
    }
}
