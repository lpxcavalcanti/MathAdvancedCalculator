using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Porcento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inserir número para calcular a porcentagem 
            Console.WriteLine("Digite o número que você deseja ");

            double VarA = Convert.ToDouble(Console.ReadLine());
            //Cálculo da porcentagem,pegue o número adicionado pelo usúario e multiplica por 0.1
            VarA = VarA * 0.1;
            //Exibe a porcentagem do valor digitado
            Console.WriteLine("Resultado é: " + VarA);
            Console.ReadLine();

            //Fim do método

        }
    }
}
