using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Empregado
    {
        public int idade;
        public string nome;
        public string setor;

        private string cpf;
        private double salario;
        private string departamento;

        private string rg;

        public string Rg
        {
            get
            {
                return rg;
            }
            set
            {
                rg = value;
            }
        }
        public string Cpf
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }


        public string Departamento
        {
            get
            {
                return departamento;
            }
            set
            {
                departamento = value;
            }
        }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }
        public double CalcularSalario(double salario)
        {
            if (salario > 3500)
            {
                double aumentoSalario = salario * 1.08;

                Console.WriteLine("O novo valor do salário com aumento de 8% é de:" + aumentoSalario);

                return aumentoSalario;
            }
            else if (salario > 2500)
            {
                double aumentoDe10 = salario * 1.10;

                Console.WriteLine("O novo valor do salário com aumento de 10% é de:" + aumentoDe10);

                return aumentoDe10;
            }
            else
            {
                double aumentoDe12 = salario * 1.12;

                Console.WriteLine("O novo valor do salário com aumento de 12% é de:" + aumentoDe12);

                return aumentoDe12;
            }

        }
        public void CalcularAlimentacao()
        {
            Console.WriteLine("Digite o valor do seu vale alimentação:");
            double valeAlimentacao = Convert.ToDouble(Console.ReadLine());

            if (valeAlimentacao > 250)
            {
                double descontoDe5 = valeAlimentacao * 0.95;
                Console.WriteLine("O valor atual do vale alimentação com um desconto de 5% é de: " + descontoDe5);
            }
            else if (valeAlimentacao > 100)
            {
                double descontoDe2 = valeAlimentacao * 0.98;
                Console.WriteLine("O valor atual do vale alimentação com um desconto de 2% é de: " + descontoDe2);
            }
            else
            {
                double descontoDe1 = valeAlimentacao * 0.99;
                Console.WriteLine("O valor atual do vale alimentação com um desconto de 1% é de: " + descontoDe1);
            }
        }
    }
}
