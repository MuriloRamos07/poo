using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Moeda
    {
        public void Dolar(double num)
        {
            double result = num / 0.19;
            Console.WriteLine("O valor em Real convertido para Dólar, é dê: " + result);
        }
        public void Real(double num2)
        {
            double result = num2 * 5.40;
            Console.WriteLine("O valor em Dólar convertido para Real, é dê: " + result);
        }
        public void Euro(double num3)
        {
            double result = num3 / 6.20;
            Console.WriteLine("O valor em Real convertido para Euro, é dê: " + result);
        }
    }
}
