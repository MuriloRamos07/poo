using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno3 : Pessoa2
    {
        public string Ra;

        public string RA
        {
            get 
            { 
                return Ra; 
            }
            set 
            { 
                Ra = value;
            }
        }

        public void DadosAluno()
        {
            Console.WriteLine("Informações da Pessoa");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Altura: {altura} m");
            Console.WriteLine($"RG: {Rg}");

            if (idade > 0)
            {
                Console.WriteLine($"Idade: {idade} anos");
            }
            else
            {
                Console.WriteLine("**A Idade precisa ser maior que 0**");
            }

            if (altura > 0)
            {
                Console.WriteLine($"{altura} m");
            }
            else
            {
                Console.WriteLine("**A Altura precisa ser maior que 0**");
            }

            if (RA != " ")
            {
                Console.WriteLine($"{ra}");
            }
            else
            {
                Console.WriteLine("**O seu RA não pode estar vazio**");
            }
        }
    }
}
