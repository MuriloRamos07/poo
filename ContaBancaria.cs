using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class ContaBancaria
    {
        public string Titular;
        public double Saldo;

        public ContaBancaria(string titular, double saldoInicial)
        {
            this.Titular = titular;
            this.Saldo = saldoInicial;
            Console.WriteLine($"Conta para {this.Titular} criada com sucesso. Saldo inicial: R$ {this.Saldo:F2}");
            // ***F2*** usado para converter o valor para duas caixas decimais, exemplo: 10,50
        }
        // Método de Depositar o Saldo
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Erro: O valor do depósito deve ser positivo! ");
            }
            else
            {
                this.Saldo += valor;
                // Fazer a Adição do Saldo atual com o Valor a ser Depositado
                Console.WriteLine($"Seu depósito de R$ {valor:F2} foi realizado com sucesso, seu novo saldo é dê: R$ {this.Saldo:F2}");
                // ***F2*** usado para converter o valor para duas caixas decimais, exemplo: 10,50             
            }
        }
        // Método de Sacar o Saldo
        public void Sacar(double valor)
        {
            if (valor > 0 && this.Saldo >= valor)
            {
                this.Saldo -= valor;
                // Fazer a subtração do Saldo atual com o Valor a ser Sacado
                Console.WriteLine($"Seu saque de R$ {valor:F2} foi realizado com sucesso, seu novo saldo é dê: R$ {this.Saldo:F2}");
                // ***F2*** usado para converter o valor para duas caixas decimais, exemplo: 10,50
            }
            else if (valor <= 0)
            {
                Console.WriteLine("Erro: O valor do saque deve ser positivo! ");
            }
            else
            {
                Console.WriteLine("Erro: Saldo insuficiente para realizar o saque! ");
            }
        }

        // Método de mostrar as informações da Conta Bancaria
        public void ExibirInformacoes()
        {
            Console.WriteLine($"\nInformações da Conta Bancaria! ");
            Console.WriteLine($"Titular: {this.Titular}");
            Console.WriteLine($"Saldo Atual: R$ {this.Saldo:F2}");
            // ***F2*** usado para converter o valor para duas caixas decimais, exemplo: 10,50
            Console.WriteLine($"----------------------------\n");
        }
    }
}