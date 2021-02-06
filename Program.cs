using System;

namespace ConversaoMoeda
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? ");
            double dolares = double.Parse(Console.ReadLine());

            double valorIOF = dolares - (dolares * 0.06);
            double valorPago = valorIOF * cotacao;
            Console.WriteLine("Valor a ser pago em reais = " + valorPago.ToString("F2"));
        }
    }
}
