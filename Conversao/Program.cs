using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor;

            Console.Write("Digite o valor em real para conversão: R$");
            valor = Convert.ToDouble(Console.ReadLine());

            double conversaoDollar;
            conversaoDollar = valor / 5;

            double conversaoEuro;
            conversaoEuro = valor / 6;

            Console.WriteLine("Conversao de Real para Dollar: " + conversaoDollar);
            Console.WriteLine("Conversao de Real para Euro: " + conversaoEuro);

            Console.ReadLine();

           


        }
    }
}
