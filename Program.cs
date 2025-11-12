using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime;
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

            //Pessoa pessoa = new Pessoa();
            //pessoa.Tamanho = 1.75;
            //pessoa.Idade = 20;
            //pessoa.Peso = 74.7;
            //pessoa.Nome = "Murilo Ramos";
            //pessoa.Sexo = "Masculino";



            //Pessoa_Juridica pessoa_J = new Pessoa_Juridica();
            //pessoa_J.Email = "murilo882@gmail.com";
            //pessoa_J.Cnpj = "55.888.333/0000-01";
            //pessoa_J.QntFuncionarios = 600;
            //pessoa_J.PmentoMedio = 2000;
            //pessoa_J.Empresa = "R4";

            //Pessoa_Fisica pessoa_F = new Pessoa_Fisica();
            //pessoa_F.Cpf = "222.444.888-99";
            //pessoa_F.Rg = "66.444.999-00";
            //pessoa_F.Endereco = "China, 478";
            //pessoa_F.Cidade = "Bauru";
            //pessoa_F.Estado = "São Paulo";


            // Estagiário
            //Estagiario estagiario = new Estagiario();
            //Console.WriteLine("Digite o valor do seu Salário: ");
            //double salario = Convert.ToDouble(Console.ReadLine());

            //estagiario.CalcularValeAlimentacao(salario);
            //estagiario.CalcularImposto(salario);



            // Gerente 
            //Gerente gerente = new Gerente();
            //Console.WriteLine("Digite o valor do seu Salário: ");
            //double salarioGrnt = Convert.ToDouble(Console.ReadLine());

            //gerente.CalcularValeAlimentacao(salario);
            //gerente.CalcularImposto(salario);



            // ATIVIDADE 01
            //Pessoa2 pessoa2 = new Pessoa2();
            //Console.WriteLine("Digite seu Nome: ");
            //pessoa2.nome = Console.ReadLine();
            //Console.WriteLine("Digite sua idade: ");
            //pessoa2.idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite seu Cor: ");
            //pessoa2.cor = Console.ReadLine();
            //Console.WriteLine("Digite sua Altura: ");
            //pessoa2.altura = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite seu RG: ");
            //pessoa2.Rg = Console.ReadLine();
            //Console.WriteLine("Digite seu Cpf: ");
            //pessoa2.Cpf = Console.ReadLine();
            //Console.WriteLine("Digite sua Cidade:");
            //pessoa2.Cidade = Console.ReadLine();
            //Console.WriteLine("Digite seu Estado: ");
            //pessoa2.Estado = Console.ReadLine();

            //pessoa2.DadosPessoa();



            // ATIVIDADE 02
            //Aluno3 al3 = new Aluno3();
            //Console.WriteLine("Digite seu Nome: ");
            //al3.nome = Console.ReadLine();
            //Console.WriteLine("Digite sua idade: ");
            //al3.idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite seu Cor: ");
            //al3.cor = Console.ReadLine();
            //Console.WriteLine("Digite sua Altura: ");
            //al3.altura = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite seu RA: ");
            //al3.ra = Convert.ToInt32(Console.ReadLine());

            //al3.DadosAluno();



            // ATIVIDADE 03
            //Professor prof = new Professor();
            //Console.WriteLine("Digite seu Nome: ");
            //prof.nome = Console.ReadLine();
            //Console.WriteLine("Digite sua idade: ");
            //prof.idade = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Digite seu Cor: ");
            //prof.cor = Console.ReadLine();
            //Console.WriteLine("Digite sua Altura: ");
            //prof.altura = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite seu RA: ");
            //prof.nif = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Digite seu Cpf: ");
            //prof.Cpf = Console.ReadLine();

            //prof.DadosProfessor();



            // ATIVIDADE 04
            //Empregado empregado = new Empregado();
            //Console.WriteLine("Digite o valor do seu salário:");
            //double salario = Convert.ToDouble(Console.ReadLine());
            //double novoSalario = empregado.CalcularSalario(salario);

            //empregado.CalcularAlimentacao();

            //empregado.nome = "Bianca";
            //empregado.idade = 21;
            //empregado.setor = "Comercial";
            //empregado.Cpf = "889.004.223-12";
            //empregado.Rg = "08.421.579-6";
            //empregado.Departamento = "Vendas";

            //Console.WriteLine("Nome: " + empregado.nome);
            //Console.WriteLine("Idade: " + empregado.idade);
            //Console.WriteLine("RG: " + empregado.Rg);
            //Console.WriteLine("CPF: " + empregado.Cpf);
            //Console.WriteLine("Setor: " + empregado.setor);


            ////Gerente
            //Gerente2 gerente2 = new Gerente2();
            //gerente2.nome = "Carla";
            //gerente2.idade = 25;
            //gerente2.setor = "Recursos Humanos";
            //gerente2.Cpf = "232.076.322-56";
            //gerente2.Rg = "12.326.812-5";
            //gerente2.Departamento = "Recursos Humanos";
            //gerente2.Salario = 6000.00;
            //gerente2.Area = "Recursos Humanos";

            //Console.WriteLine("Nome: " + gerente2.nome);
            //Console.WriteLine("Idade: " + gerente2.idade);
            //Console.WriteLine("RG: " + gerente2.Rg);
            //Console.WriteLine("CPF: " + gerente2.Cpf);
            //Console.WriteLine("Setor: " + gerente2.setor);
            //Console.WriteLine("Departamento: " + gerente2.Departamento);
            //Console.WriteLine("Área: " + gerente2.Area);
            //Console.WriteLine("Salario: " + gerente2.Salario);

            //gerente2.CalcularSalario(gerente2.Salario);
            //gerente2.CalcularAlimentacao();



            // ATIVIDA 1
            //double salarioBase = 5000.00;

            //Professor2 professor2 = new Professor2();
            //Coordenador coordenador = new Coordenador();
            //Diretor diretor = new Diretor();

            //double salarioProf = professor2.CalcularSalarioLiquidoTotal(salarioBase);
            //double salarioCoord = coordenador.CalcularSalarioLiquidoTotal(salarioBase);
            //double salarioDir = diretor.CalcularSalarioLiquidoTotal(salarioBase);

            //Console.WriteLine($"Salário Bruto Base: {salarioBase:C2}");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine($"Salário Líquido Professor (INSS 18% + IRRF 2%): {salarioProf:C2}");
            //Console.WriteLine($"Salário Líquido Coordenador (INSS 11% + IRRF 2%): {salarioCoord:C2}");
            //Console.WriteLine($"Salário Líquido Diretor (INSS 23% + IRRF 2%): {salarioDir:C2}");



            // ATIVIDADE 2
            //Poupanca contaPoupanca = new Poupanca("0001", "12345-6", "Murilo Ramos");
            //Corrente contaCorrente = new Corrente("0001", "65432-1", "Bianca Ferreira");

            //double Saque = 7000.0;

            //double valorP = contaPoupanca.CalcularImposto(Saque);
            //Console.WriteLine($"Saque de R${Saque:C2} na Poupança (Titular: {contaPoupanca.NomeTitular})");
            //Console.WriteLine($"Valor líquido após imposto de 6%: R${valorP:C2}\n");

            //double valorC = contaCorrente.CalcularImposto(Saque);
            //Console.WriteLine($"Saque de R${Saque:C2} na Corrente (Titular: {contaCorrente.NomeTitular})");
            //Console.WriteLine($"Valor líquido após imposto de 15%: R${valorC:C2}");



            // ATIVIDADE 3
            Veiculo meuCarro = new Veiculo("Nissan R34", "MRS-1808");
            meuCarro.CalcularValorCombustivel();
            meuCarro.CalcularTotal();

            Console.WriteLine("\n------------------------------------------------\n");

            Moto minhaMoto = new Moto("BMW 1200", "BFL-0818");
            minhaMoto.CalcularValorCombustivel();
            minhaMoto.CalcularTotal();
        }
    }
}