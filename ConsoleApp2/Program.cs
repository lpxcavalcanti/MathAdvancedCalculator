using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class EquacaoGrau1
    {
        static void Main(string[] args)
        {

            //Inserir valor de A
            Console.WriteLine("Digite o valor de A");
            double VarA = Convert.ToDouble(Console.ReadLine());

            //Inserir valor de B
            Console.WriteLine("Digite o valor de B");
            double VarB = Convert.ToDouble(Console.ReadLine());

            //Declaração da variável X
            double VarX;

            //Código da equação
            VarX = -(VarB / VarA);

            //Impressão do resultado da equação
            Console.WriteLine("O valor de X na equação é: " + VarX);
            Console.ReadKey();

            //Fim






        }
    }
}
