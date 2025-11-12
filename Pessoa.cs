using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public double Peso;
        public double Tamanho;
        public string Sexo;

       public void Lazer()
        {
            Console.WriteLine("A pessoa está em um momento de Lazer! ");
        }

        public void Conversar()
        {
            Console.WriteLine("A pessoa está Conversando! ");
        }

        public void Descansar()
        {
            Console.WriteLine("A pessoa está Descasando");
        }
    }
}
