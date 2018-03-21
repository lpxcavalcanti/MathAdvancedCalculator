using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp2
    {
        class Program
        {
            static void Main(string[] args)
            {

                Console.WriteLine("Digite o número que você deseja ");
                
                double VarA = Convert.ToDouble(Console.ReadLine());


                Console.WriteLine("Digite a porcentagem ");
                double VarB = Convert.ToDouble(Console.ReadLine());

                double VarC;

                VarB = VarB / 100;
                VarC = VarB;
                VarA = VarA * VarC;

                Console.WriteLine("Resultado é: " + VarA);
                Console.ReadLine();





            }
        }
    }
 
        
    