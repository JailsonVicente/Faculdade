using System.Globalization;
using CalcMediaCs.Classes;
namespace CalcMediaCs
{
    public class Program
    {
        public static void Main()
        {
            //ConversorDeMoeda inputs

            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDolar = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double valorDolar = double.Parse(Console.ReadLine());

            Console.Write("Qual é a cotação do euro? ");
            double cotacaoEuro = double.Parse(Console.ReadLine());

            Console.Write("Quantos euros você vai comprar? ");
            double valorEuro = double.Parse(Console.ReadLine());

            //ConversorDeMoeda chamada

            ConversorDeMoeda conversor = new ConversorDeMoeda(cotacaoDolar, cotacaoEuro);

            // Convertendo dólares para reais
            double valorReaisDolar = conversor.ConverterDolarParaReais(valorDolar, cotacaoDolar);
            double valorDolarFormat = valorReaisDolar / 100 - 0.01;
            Console.WriteLine($"Valor a ser pago em reais = R$ {valorDolarFormat:F2}");

            // Convertendo euros para reais
            double valorReaisEuro = conversor.ConverterEuroParaReais(valorEuro, cotacaoEuro);
            double valorEuroFormat = valorReaisEuro / 100 - 0.01;
            Console.WriteLine($"Valor a ser pago em reais = R$ {valorEuroFormat:F2}");
        }
    }
}
