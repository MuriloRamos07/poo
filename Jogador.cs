using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Jogador // Classe
    {
        // Atributos
        public string Nome;
        public int Idade;
        public double Peso;
        public double Altura;
        public string Time;
        public string Posicao;
        public string Pais;
        public string NumeroCamisa;

        //MétodosCorrer
        public void Correr(int idade, string nome)
        {
            // Propriedade THIS
            this.Idade = idade;
            this.Nome = nome;

            if(idade >= 18)
            {
                Console.WriteLine("Atleta é Adulto");
            }
            else if(idade > 15 || idade < 18)
            {
                Console.WriteLine("Atleta é Júnior");
            }
            else
            {
                Console.WriteLine("Atleta é Infantil");
            }
            Console.WriteLine("O nome do Atleta é: " + nome);
        }

        public void Chutar()
        {

        }

        public void Driblar()
        {

        }

        public void Pular()
        {

        }

        public void Falar()
        {

        }
    }
}
