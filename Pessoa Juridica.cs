using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa_Juridica : Pessoa
    {
        public string Cnpj;
        public string Empresa;
        public double QntFuncionarios;
        public string Email;
        public double PmentoMedio;

        public void Reuniao() 
        {
            Console.WriteLine("A Pessoa Jurídica está em Reunião! ");
        }

        public void Compromisso()
        {
            Console.WriteLine("A Pessoa Jurídica está em um Compromisso! ");
        }

        public void Viagem()
        {
            Console.WriteLine("A Pessoa Jurídica está em uma Viagem de Negócios! ");
        }
    }
}
