using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Programa para dizer se um número é par ou ímpar.

namespace MathAdvancedCalculator
{
    class ImPar
    {
        static void Main(string[] args)
        {
            //inserir um número para saber se é par ou ímpar
            Console.WriteLine("Digite um número: ");
            double VarA = Convert.ToDouble(Console.ReadLine());


            //Realiza a operação de divisão
            if (VarA % 2 == 0)
            {
                //Se o módulo for 0 o número é par
                Console.WriteLine("O número é par");

            }

            else
            {
                //Se o módulo for 1 o número é ímpar
                Console.WriteLine("O número é ímpar");

            }

            Console.ReadKey();

        }
        
    }
}
