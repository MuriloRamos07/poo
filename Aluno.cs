using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Aluno
    {
        public int idade;
        public double peso;
        public double altura;
        public string responsável;
        public string telefone;
        public string nome;
        public string rm;
        public string email;
        public string cpf;
        public string serie;
        public string cor;
        public string sexo;

        public void Estudar()
        {
            Console.WriteLine("O aluno está estudando!");
        }

        public void Escrever()
        {
            Console.WriteLine("O aluno está escrevendo!");
        }

        public void Ler()
        {
            Console.WriteLine("O aluno está lendo!");
        }

        public void Falar()
        {
            Console.WriteLine("O aluno está falando!");
        }

        public void Andar()
        {
            Console.WriteLine("O aluno está andando!");
        }

        public void Aprender()
        {
            Console.WriteLine("O aluno está aprendendo!");
        }
    }
}
