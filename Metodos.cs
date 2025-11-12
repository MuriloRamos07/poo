using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Metodos
    {
        public int Valor1;
        public int Valor2;
        public int Valor3;

        public int num1;
        public int num2;
        public int num3;

        public void SomarValores(int valor1, int valor2, int valor3)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;
            this.Valor3 = valor3;

            int resultado = valor1 + valor2 + valor3;
            Console.WriteLine("O resultado da soma é: " + resultado);
        }


        public int Multiplicar(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            return Valor1 * Valor2;

        }

        public string Dividir()
        {
            int resultadoDiv = Multiplicar(Valor1, Valor2);

            if (resultadoDiv % 2 == 0)
            {
                // Se o resto for 0, o número é par
                return "Valor é par";
            }
            else
            {
                // Se o resto for diferente de 0, o número é ímpar
                return "Valor é ímpar";
            }
        }

        public double SalarioAumento(double salario)
        {
            if (salario >= 2000)
            {
                return salario * 1.2754;
            }
            else
            {
                return salario * 1.1523;
            }
        }

        public int Somar(int valor1, int valor2)
        {
            this.Valor1 = valor1;
            this.Valor2 = valor2;

            return Valor1 + Valor2;

        }

        public void Subtrair(int num3)
        {
            int soma = Somar(Valor1, Valor2);


            if (num3 > soma)
            {
                Console.WriteLine("O valor da subtração é maior!");
            }
            else
            {
                Console.WriteLine("O valor da soma é maior!");
            }
        }

    }
}


     