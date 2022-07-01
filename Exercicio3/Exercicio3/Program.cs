using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes,
            //    não vale quadrado e nem retângulo.

            //    Observação: as figuras são de escolha livre,
            //    dá um Google se não lembrar como faz o cálculo de alguma delas.

            //    Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular.
            //    Deve - se utilizar Switch Case.


            int escolha;
            double a, b, c, d, area;

            Console.WriteLine("Escolha entre as opções: 1 - Trapésio, 2 - Hexágono, 3 - Círculo");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Write("Digite a base maior: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Didite a base menor: ");
                    b = double.Parse(Console.ReadLine());
                    Console.Write("Digite a altura: ");
                    c = double.Parse(Console.ReadLine());

                    area = (a + b) * c / 2;
                    Console.WriteLine("A área do trapésio é de " + area);
                    break;

                case 2:
                    Console.Write("Digite a base: ");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("Didite a altura: ");
                    b = double.Parse(Console.ReadLine());

                    area = ((a * b) / 2) * 6;
                    Console.WriteLine("A área do hexágono é de " + area);
                    break;
                case 3:
                    Console.Write("Digite o raio do círculo: ");
                    a = double.Parse((Console.ReadLine()));

                    area = 3.14 * (a * a);
                    Console.WriteLine("A área do círculo é de " + area);
                    break;
                default:
                    Console.WriteLine("Código Inválido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
