using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa_Fisica : Pessoa
    {
        public string Cpf;
        public string Rg;
        public string Endereco;
        public string Cidade;
        public string Estado;

        public void Ligacao()
        {
            Console.WriteLine("A Pessoa Física está em Ligação! ");
        }

        public void Trabalhar()
        {
            Console.WriteLine("A Pessoa Física está Trabalhando! ");
        }

        public void Conta()
        {
            Console.WriteLine("A Pessoa Física está pagando as Contas! ");
        }
    }
}
