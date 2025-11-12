using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Veiculo
    {
        public string Modelo { get; set; }
        public string Placa { get; set; }

        public Veiculo(string modelo, string placa)
        {
            Modelo = modelo;
            Placa = placa;
        }
        public virtual void CalcularValorCombustivel()
        {
            Console.WriteLine("\n--- Calculando Valor do Combustível para " + Modelo + " ---");
            Console.WriteLine("Qual combustível deseja abastecer?");
            Console.WriteLine("1 -> Álcool (R$ 3,99 por litro)");
            Console.WriteLine("2 -> Gasolina (R$ 5,99 por litro)");
            Console.WriteLine("3 -> Diesel (R$ 6,99 por litro)");

            int opcaoCombustivel;
            if (!int.TryParse(Console.ReadLine(), out opcaoCombustivel))
            {
                Console.WriteLine("Opção inválida! ");
                return;
            }
            Console.Write("Digite a quantidade de litros: ");
            if (!double.TryParse(Console.ReadLine(), out double litros))
            {
                Console.WriteLine("Quantidade inválida");
                return;
            }
            double valorLitro;
            string tipoCombustivel;
            switch (opcaoCombustivel)
            {
                case 1:
                    valorLitro = 3.99;
                    tipoCombustivel = "Álcool";
                    break;
                case 2:
                    valorLitro = 5.99;
                    tipoCombustivel = "Gasolina";
                    break;
                case 3:
                    valorLitro = 6.99;
                    tipoCombustivel = "Diesel";
                    break;
                default:
                    Console.WriteLine("Opção de combustível inválida! ");
                    return;
            }
            double valorTotal = litros * valorLitro;
            Console.WriteLine($"\nValor a pagar por {litros:C2} litros de {tipoCombustivel}: R$ {valorTotal:C2}");
        }
        public virtual void CalcularTotal()
        {
            Console.WriteLine("\n--- Calculando Total da Viagem para " + Modelo + " ---");
            Console.Write("Quantidade de pessoas que vão na viagem: ");
            if (!int.TryParse(Console.ReadLine(), out int pessoas))
            {
                Console.WriteLine("Quantidade de pessoas inválida! ");
                return;
            }
            Console.Write("Quantidade de km que vai percorrer: ");
            if (!double.TryParse(Console.ReadLine(), out double km))
            {
                Console.WriteLine("Distância inválida! ");
                return;
            }
            double custoKm;
            if (pessoas == 2 && km > 50)
            {
                custoKm = 25.00;
            }
            else if (pessoas == 2 && km <= 50)
            {
                custoKm = 18.00;
            }
            else
            {
                custoKm = 15.00;
            }
            double valorTotal = km * custoKm;
            Console.WriteLine($"\nValor total para a viagem ({km:C2} km, {pessoas} pessoas): R$ {valorTotal:C2}");
        }
    }
}