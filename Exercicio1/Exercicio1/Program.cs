using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Faça um programa que receba o nome do aluno, nota de trabalho,
            //nota da prova 1 e nota da prova 2.Calcule a média  final(média simples)
            //e apresente o conceito obtido seguindo a seguinte formula:

            // O conceito da será calculado da seguinte forma:
            //Se a nota final for maior ou igual a 8.5, então o conceito é A.
            //Se a nota final estiver entre 7.0 e 8.4, então o conceito é B.
            //Se a nota final estiver entre 6.0 e 6.9, então o conceito é C.
            //Se a nota final estiver entre 0.1 e 5.9, então o conceito é D.
            //Se a nota final for igual a 0.0, então o conceito é E.

            string nome, conceito;
            double notatrabalho, nota1, nota2, media;

            Console.Write("Digite o nome do aluno: ");
            nome = Console.ReadLine();
            Console.Write("Digite a nota do trabalho: ");
            notatrabalho = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota da primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Digite a nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (notatrabalho + nota1 + nota2) / 3;

            if (media > 8.5)
            {
                conceito = "A";
            }
            else if (media >= 7 && media <= 8.4)
            {
                conceito = "B";
            }
            else if (media >= 6 && media <= 6.9)
            {
                conceito = "C";
            }
            else if (media >= 0.1 && media <= 5.9)
            {
                conceito = "D";
            }
            else
            {
                conceito = "E";
            }

            Console.Write("Aluno: " + nome + "\t");
            Console.Write("Média: " + media.ToString("F1", CultureInfo.InvariantCulture) + "\t");
            Console.Write("Conceito: " + conceito + "\t");

            Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }
}