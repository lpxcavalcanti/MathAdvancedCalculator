using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Código para realização de uma equação de segundo grau.

namespace ConsoleApp3
{
    class EquacaoGrau2
    {
        static void Main(string[] args)
        {

            double a, b, c, RaizUm, RaizDois, DeltaUm;

            //Inserir o valor de A
            Console.Write("Digite o valor de A: ");
            a = Double.Parse(Console.ReadLine());
            
            //Inserir o valor de B
            Console.Write("Digite o valor de B: ");
            b = Double.Parse(Console.ReadLine());

            //Inserir o valor de C
            Console.Write("Digite o valor de C: ");
            c = Double.Parse(Console.ReadLine());

            //Código de Delta
           DeltaUm = (Math.Pow(b, 2)) - (4 * a * c);

            //Condições de Delta
            if (DeltaUm < 0)
            {
                //Se Delta é menor que zero a compilação encerra
                Console.Write("Não existe raiz para Delta menor que zero. Pressione qualquer tecla para sair");

            }
            else
            {
                //Se Delta maior que zero
                RaizUm = (-(b) + Math.Sqrt(DeltaUm)) / (2 * a);
                RaizDois = (-(b) - Math.Sqrt(DeltaUm)) / (2 * a);
                
                
                //Resultado
                Console.WriteLine("O resultado da equação " + a + "x²+" + b + "x+" + c + "= 0 é: X¹= " + RaizUm  + " e x²= " + RaizDois + ".");
                Console.Write("Digite qualquer tecla para sair!");
            }

            Console.ReadKey();

        }
    }
}
