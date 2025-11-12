using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Moto : Veiculo
    {
        public Moto(string modelo, string placa) : base(modelo, placa)
        {

        }
        public override void CalcularValorCombustivel()
        {
            Console.WriteLine("\n--- Calculando Valor do Combustível para " + Modelo + " ---");
            Console.WriteLine("Qual combustível deseja abastecer ?");
            Console.WriteLine("1 -> Álcool (R$ 4,99 por litro)");
            Console.WriteLine("2 -> Gasolina (R$ 4,99 por litro)");

            int opcaoCombustivel;
            if (!int.TryParse(Console.ReadLine(), out opcaoCombustivel))
            {
                Console.WriteLine("Opção inválida! ");
                return;
            }
            Console.Write("Digite a quantidade de litros: ");
            if (!double.TryParse(Console.ReadLine(), out double litros))
            {
                Console.WriteLine("Quantidade inválida! ");
                return;
            }
            double valorLitro = 4.99;
            string tipoCombustivel;
            switch (opcaoCombustivel)
            {
                case 1:
                    tipoCombustivel = "Álcool";
                    break;
                case 2:
                    tipoCombustivel = "Gasolina";
                    break;
                default:
                    Console.WriteLine("Opção de combustível inválida para moto! **Apenas Álcool ou Gasolina!**");
                    return;
            }
            double valorTotal = litros * valorLitro;
            Console.WriteLine($"\nValor a pagar por {litros:C2} litros de {tipoCombustivel}: R$ {valorTotal:C2}");
        }
        public override void CalcularTotal()
        {
            Console.WriteLine("\n--- Calculando Total da Viagem para a " + Modelo + " ---");
            Console.Write("Quantidade de km que vai percorrer: ");
            if (!double.TryParse(Console.ReadLine(), out double km))
            {
                Console.WriteLine("Distância inválida! ");
                return;
            }
            double custoKm;

            if (km >= 100 && km < 150)
            {
                custoKm = 20.00;
            }
            else if (km >= 50)
            {
                custoKm = 10.00;
            }
            else
            {
                custoKm = 5.00;
            }
            double valorTotal = km * custoKm;
            Console.WriteLine($"\nValor total para a viagem ({km:C2} km): R$ {valorTotal:C2}");
        }
    }
}