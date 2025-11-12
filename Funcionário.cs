using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Funcionário
    {
        public int idade;

        public double altura;
        public double peso;
        public double remuneracao;
        public double telefone;
        public double cargahoraria;

        public string cargo;
        public string nome;
        public string email;
        public string cpf;
        public string endereco;

        public void Trabalhar()
        {
            Console.WriteLine("O funcionário está trabalhando!");
        }

        public void Conversar()
        {
            Console.WriteLine("O funcionário está conversando!");
        }

        public void Lucrar()
        {
            if (remuneracao == 0)
            {
                Console.WriteLine("Você não certificou o a remuneração!");
            }
            else
            {
                double novoSalario = remuneracao * 1.25;
                Console.WriteLine("O salario do funcionário com aumento de 25% é de: " );
            }
        }

        public void Comer()
        {
            Console.WriteLine("O funcionário está comendo!");
        }

        public void Descansar()
        {
            Console.WriteLine("O funcionário está descansando!");
        }
    }
}
