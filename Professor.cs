using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Professor : Pessoa2
    {
        private string NIF;

        public string Nif
         {
            get
            {
                return Nif;
            }
            set
            {
                Nif = value;
            }
        }

        public void DadosProfessor()
        {
            Console.WriteLine("Informações do Professor");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"NIF: {Nif}");
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
                Console.WriteLine($"Altura: {altura} m");
            }
            else
            {
                Console.WriteLine("**A Altura precisa ser maior que 0**");
            }
            
            if (Rg != " ")
            {
                Console.WriteLine($"{Rg}");
            }
            else
            {
                Console.WriteLine("**O seu RG não pode estar vazio**");
            }
            if (Nif != "")
            {
                Console.WriteLine($"{Nif}");
            }
            else
            {
                Console.WriteLine("**O seu NIF não pode estar vazio**");
            }
        }      
    }
}
