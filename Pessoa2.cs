using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AulaClasse
{
    public class Pessoa2 : Pessoa
    {
        // PÚBLICO
        public string nome;
        public int idade;
        public string cor;
        public double altura;
        public int ra;
        public double nif;

        // PRIVADO 
        private string rg;
        private string cpf;
        private string cidade;
        private string estado;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public void DadosPessoa()
        {
            Console.WriteLine("Informações da Pessoa");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"Cor: {cor}");
            Console.WriteLine($"Altura: {altura} m");
            Console.WriteLine($"RG: {Rg}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Cidade: {Cidade}");
            Console.WriteLine($"Estado: {Estado}");
            Console.WriteLine("------------------------------");
        }
    }
}
