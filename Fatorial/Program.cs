using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            Console.WriteLine("Entre com o número que será fatorado:");
            number = int.Parse(Console.ReadLine());

            int fatorial;

            fatorial = number;
            for (int i = number - 1; i > 1; i--)
            {
                fatorial *= i;
            }

            Console.WriteLine("Valor de "+number +"! é: " + fatorial);

            Console.Read();
        }

    }
}

