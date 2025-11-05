using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Aluno2
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;
        public double nota5;

        public double SomarNota(double nota1, double nota2, double nota3, double nota4, double nota5)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;
            this.nota5 = nota5;

            double result = nota1 + nota2 + nota3 + nota4 + nota5;
            return result;
        }
        public string CalcularMedia(double SomarNota)
        {
            double Media = SomarNota / 5;
            Console.WriteLine("A Média da Nota é: " + Media);

            if (Media >= 7)
            {
                return "O Aluno foi Aprovado!";
            }
            else if (Media >= 5)
            {
                return "O Aluno em Recuperação";
            }
            else
            {
                return "Aluno foi Reprovado";
            }
        }
    }
}
