using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// AIVIDADE 01
            //MetodosSenai metodos = new MetodosSenai();
            //Console.Write("Digite o seu Nome: ");
            //metodos.nome = Console.ReadLine();
            //Console.Write("Digite o seu Sobrenome: ");
            //metodos.sobrenome = Console.ReadLine();
            //Console.Write("Digite o seu Endereço: ");
            //metodos.endereco = Console.ReadLine();
            //Console.Write("Digite a sua Cidade: ");
            //metodos.cidade = Console.ReadLine();
            //Console.Write("Digite o seu Estado: ");
            //metodos.estado = Console.ReadLine();
            //Console.Write("Digite o seu País: ");
            //metodos.pais = Console.ReadLine();
            //metodos.Cadastro();



            /// ATIVIDADE 02
            //Console.Write("Nome do Produto: ");
            //metodos.nomeProduto = Console.ReadLine();
            //Console.Write("Marca do Produto: ");
            //metodos.marcaProduto = Console.ReadLine();
            //Console.Write("Código do Produto: ");
            //metodos.codigoProduto = Console.ReadLine();
            //metodos.Produtos();



            /// ATIVIDADE 03
            //Console.Write("Nome do Estudante: ");
            //metodos.nome = Console.ReadLine();
            //Console.Write("Idade do Estudante: ");
            //metodos.idade = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Escola do Estudante: ");
            //metodos.escola = Console.ReadLine();           
            //metodos.Estudar();



            /// ATIVIDADE 04
            //Console.WriteLine("Digite o tamanho do Lado do Retângulo: ");
            //metodos.lado = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite o tamanho da Altura do Retângulo: ");
            //metodos.altura = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite o primeiro Lado do Quadrado: ");
            //metodos.lado = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite o segundo Lado do Quadrado: ");
            //metodos.lado = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Digite o valor do Raio do Circulo: ");
            //metodos.raio = Convert.ToDouble(Console.ReadLine());
            //metodos.retangulo();
            //metodos.quadrado();
            //metodos.circulo();



            /// ATIVIDADE 05
            //Console.Write("Nome do Professor: ");
            //metodos.nome = Console.ReadLine();
            //Console.Write("Idade do Professor: ");
            //metodos.idade = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Matéria em que da aula: ");
            //metodos.materia = Console.ReadLine();
            //Console.Write("Cidade do Professor: ");
            //metodos.cidade = Console.ReadLine();
            //Console.Write("Nome da escola em que trabalha: ");
            //metodos.escola = Console.ReadLine();

            //Console.WriteLine("Digite o nome do aluno: ");
            //metodos.nomeAluno = Console.ReadLine();
            //metodos.Professor();
            //metodos.NotaAluno(7, 8, 5, 3);



            /// AIVIDADE 06
            //Console.Write("Nome do Colaborador: ");
            //metodos.nome = Console.ReadLine();
            //Console.Write("Idade do Colaborado: ");
            //metodos.idade = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Escolaridade do Colaborado: ");
            //metodos.escola = Console.ReadLine();
            //Console.Write("Cpf do Colaborado: ");
            //metodos.cpf = Console.ReadLine();
            //Console.Write("Rg do Colaborador: ");
            //metodos.rg = Console.ReadLine();

            //metodos.Colaborador();
            //metodos.SalarioColaborador(3000);



            /// ATIVIDADE 07
            //Moeda metodos = new Moeda();
            //metodos.Dolar(2000);
            //metodos.Real(7000);
            //metodos.Euro(2000);



            /// ATIVIDADE 08
            //Console.Write("Digite o nome do titular da conta: ");
            //string nomeTitular = Console.ReadLine();
            //Console.Write("Digite o saldo inicial da conta: R$ ");
            //if (!double.TryParse(Console.ReadLine(), out double saldoInicial))
            //{
                //Console.WriteLine("Valor inválido. Usando saldo inicial de R$ 0.00.");
                //saldoInicial = 0.0;
            //}
            //ContaBancaria minhaConta = new ContaBancaria(nomeTitular, saldoInicial);
            //minhaConta.ExibirInformacoes();    
            //Console.Write("Digite o valor para depósito: R$ ");
            //if (double.TryParse(Console.ReadLine(), out double valorDeposito))
                // ***TryParse serve para converter uma String para um número,
                // ele retorna o numero se Der Certo,
                // e falha para não
            //{
                //minhaConta.Depositar(valorDeposito);
            //}
            //else
            //{
                //Console.WriteLine("Valor de depósito inválido! ");
            //}
            //Console.Write("Digite o valor para saque: R$ ");
            //if (double.TryParse(Console.ReadLine(), out double valorSaque))
            //{
                //minhaConta.Sacar(valorSaque);
            //}
            //else
            //{
                //Console.WriteLine("Valor de saque inválido! ");
            //}
            //minhaConta.ExibirInformacoes();



            /// ATIVIDADE09
            //Aluno2 Aluno2 = new Aluno2();
            //string nome = "Murilo Ramos";
            //double not1 = 9.5;
            //double not2 = 10;
            //double not3 = 7.8;               
            //double not4 = 8.4;    
            //double not5 = 9.0;

            //Console.WriteLine(nome);

            //double somatotal = Aluno2.SomarNota(not1, not2, not2, not3, not4, not5);
            //Console.WriteLine($"A soma total das notas: {somatotal:F2}");

            //string mediaF = Aluno2.CalcularMedia(somatotal);
            //Console.WriteLine($"Status: {mediaF}");
        }
    }
}