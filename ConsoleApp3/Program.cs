using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class EquacaoGrau2
    {
        static void Main(string[] args)
        {

            double a, b, c, raizUm, raizDois, deltaUm;

            Console.Write("Digite o valor de A: ");
            a = Double.Parse(Console.ReadLine());

            Console.Write("ztDigite o valor de B: ");
            b = Double.Parse(Console.ReadLine());

            Console.Write("ztDigite o valor de C: ");
            c = Double.Parse(Console.ReadLine());

            deltaUm = (Math.Pow(b, 2)) - (4 * a * c);

            if (deltaUm < 0)
            {
                Console.Write("Não existe raiz para Delta menor que zero. Pressione qualquer tecla para sair");

            }
            else
            {
                raizUm = (-(b) + Math.Sqrt(deltaUm)) / (2 * a);
                raizDois = (-(b) - Math.Sqrt(deltaUm)) / (2 * a);

                Console.WriteLine("O resultado da equação " + a + "x²+" + b + "x+" + c + "= 0 é: X¹= " + raizUm  + " e x²= " + raizDois + ".");
                Console.Write("Digite qualquer tecla para sair!");
            }
            Console.ReadKey();



        }
    }
}
