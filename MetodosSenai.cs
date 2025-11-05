using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class MetodosSenai
    {
        public string nome;
        public string nomeAluno;
        public string sobrenome;
        public string endereco;
        public string cidade;
        public string estado;
        public string pais;

        public string nomeProduto;
        public string marcaProduto;
        public string codigoProduto;
        public string escola;
        public string cpf;
        public string rg;

        public int idade;
        public double salario;

        public double lado;
        public double altura;
        public double raio;

        public string materia;
        public void Cadastro()
        {
            Console.WriteLine("\n Informações do Usuário");
            Console.WriteLine($"Nome completo: {nome} {sobrenome}");
            Console.WriteLine($"Endereço: {endereco}");
            Console.WriteLine($"Cidade: {cidade}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"País: {pais}");
        }

        public void Produtos()
        {
            int valor1 = 20;
            int valor2 = 25;
            int valor3 = 5;

            Console.WriteLine("\n Informações do Produto; ");
            Console.WriteLine($"Nome do Produto: {nomeProduto}");
            Console.WriteLine($"Marca do Produto: {marcaProduto}");
            Console.WriteLine($"Código do Produto: {codigoProduto}");

            Console.WriteLine("Agora Digite a quantidade de produtos que deseja: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            if ( quantidade <= 10 ) 
            {
                int result = quantidade * valor1;
                Console.WriteLine("O valor dos produtos são de: "+ result);
            }
            else if( quantidade <= 20)
            {
                int result = quantidade * valor2;
                Console.WriteLine("O valor do produto é de: " + result);
            }
            else
            {
                int result = quantidade * valor3;
                Console.WriteLine("O valor do produto é de: " + result);
            }
        }

        public void Estudar()
        {
            Console.WriteLine("\nInformações do Estudante; ");
            Console.WriteLine($"Nome do Estudante: {nome}");
            Console.WriteLine($"Idade do Estudante: {idade}");
            Console.WriteLine($"Nome da Escola: {escola}");

            if (escola == "SENAI")
            {
                Console.WriteLine("Parabéns você está cursando em uma excelente escola!");
            }
            else
            {
                Console.WriteLine("Aluno não pertence ao Senai.");
            }
        }

        public void retangulo()
        {           
            double result = lado * altura;
            Console.WriteLine("A área do retângulo é de: " + result);
        }

        public void quadrado()
        {
            double result = lado * lado;
            Console.WriteLine("A área do quadrado é de: " + result);
        }

        public void circulo() 
        {
            double result = 3.14 * (raio * raio);
            Console.WriteLine("A área do circulo é de: " + result);
        }

        public void Professor()
        {
            Console.WriteLine("\n Informações do Professor");
            Console.WriteLine($"Nome do Professor: {nome}");
            Console.WriteLine($"idade do Professor: {idade}");
            Console.WriteLine($"Matéria em que da aula: {materia}");
            Console.WriteLine($"Cidade do Professor: {cidade}");
            Console.WriteLine($"Nome da escola em que trabalha: {escola}");
            Console.WriteLine($"Digite o nome do aluno: {nomeAluno}");
        }
        public void NotaAluno(int nota1, int nota2, int nota3, int nota4)
        {
            double somaNotas = nota1 + nota2 + nota3 + nota4;          
            double media = somaNotas / 4;

            Console.WriteLine("A nota média do aluno, é de: "+media);
        }

        public void Colaborador()
        {
            Console.WriteLine("\n Informações do Colaborador; ");
            Console.WriteLine($"Nome do colaborador: {nome}");
            Console.WriteLine($"idade do Colaborador: {idade}");
            Console.WriteLine($"Escolaridade do Colaborador: {escola}");
            Console.WriteLine($"Cpf do Colaborador: {cpf}");
            Console.WriteLine($"Rg do Colaborador: {rg}");
        }

        public void SalarioColaborador(double salario)
        {
            if (salario <= 1000)
            {
                double result = salario * 1.25;
                Console.WriteLine("O salário do Colaborador com um aumento de 25%, é dê: " + result);
            }
            else if (salario <= 3000 )
            {
                double result = salario * 1.10;
                Console.WriteLine("O salário do Colaborador com um aumento de 10%, é dê: " + result);
            }
            else
            {
                double result = salario * 1.05;
                Console.WriteLine("O novo salário do Colaborador com um aumento de 5%, é dê: " + result);
            }
        }
    }
}

