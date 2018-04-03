using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Código para realização da função Fatorial
namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração da variável number
            int number;

            //Inserir número a ser fatorado
            Console.WriteLine("Entre com o número que será fatorado:");
            number = int.Parse(Console.ReadLine());

            //Declaração da variável fatorial
            int fatorial;

            //Resolução do Fatorial
            fatorial = number;
            for (int i = number - 1; i > 1; i--)
            {
                fatorial *= i;
            }

            //Resultado
            Console.WriteLine("Valor de "+number +"! é: " + fatorial);

            Console.Read();
        }

    }
}

