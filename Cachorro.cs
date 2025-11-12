using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Cachorro
    {
        public int idade;
        public double peso;
        public double altura;
        public string cor;
        public string raca;
        public string nome;
        public string porte;
        public string tipohabitat;

        public void Latir()
        {
            if (idade <= 3)
            {
                Console.WriteLine("O cachorro não late!");
            }
            else
            {
                Console.WriteLine("O cachorro late!");
            }
        }

        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo!");
        }

        public void Brincar()
        {
            Console.WriteLine("O cachorro está brincando!");
        }

        public void Correr()
        {
            Console.WriteLine("O cachorro está correndo!");
        }

        public void Beber()
        {
            Console.WriteLine("O cachorro está bebendo!");
        }

        public void Morder()
        {
            Console.WriteLine("O cachorro está mordendo!");
        }

        public void Dormir()
        {
            Console.WriteLine("O cachorro está dormindo!");
        }
    }
}
