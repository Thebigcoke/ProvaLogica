using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Fazer um programa para encontrar todos os números pares entre 1 e 100.

            

            for(int i = 0; i <= 101; i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine("Número par: " + i + "\t");
                }  

                
            }

            Console.ReadKey();
        }
    }
}
