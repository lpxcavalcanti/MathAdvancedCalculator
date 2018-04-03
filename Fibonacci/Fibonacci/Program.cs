using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Código para retornar o valor da sequência de fibonacci

        
namespace Fibonacci
    {
        class TestaFibonacci
        {
           //Iniciando o método Main
            public static void Main()
            {
                //Área na qual o usúario deve digitar o valor de Fibonacci que deseja
                Console.WriteLine("Digite o termo ao qual você deseje o número Fibonacci: ");

                 //Converte de int para double é associa a variável number
                int number = Convert.ToInt32(Console.ReadLine());

                //Exibe o número da sequência de fibonacci referente ao número inserido
                Console.WriteLine(Fibonacci(number));

                Console.ReadKey();
            }
           
            static int Fibonacci(int a) 
            {
                //Se x menor ou igual a um retorna o valor de 1 senão entra na função de fibonacci
                if (a <= 1)
                {
                    return 1;
                }
                //Executa a função de fibonacci com o valor digitado da variável número
                return Fibonacci(a-1) + Fibonacci(a-2);
               //Fim do método
            }
        }
    }


