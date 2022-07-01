using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 – Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe o código da cidade escolhida.
            //    Em seguida pedir uma data para o usuário. 
            //    Ao final deve ser apresentada em tela a data completa em formato extenso longo, juntamente com a cidade escolhida. 
            //Exemplo: Bragança Paulista, 29 de junho de 2022.

            //A relação das cidades é a seguinte:

            //1 – Atibaia
            //2 – Bragança Paulista
            //3 – Mairiporã
            //4 – Nazaré
            //5 – Terra Preta
            //6 – Extrema
            //7 – Vargem

            //Requisitos: Criar uma função para converter a data em extenso.

            DateTime dataescolhida = new DateTime();

            string atibaia, bragança, mairipora, nazare, terrapreta, extrema, vargem;
            int codigo;

            Console.WriteLine("Escolha o código da cidade: 1 - Atibaia, 2 - Bragança Paulista, 3 - Mairiporã, 4 - Nazaré, " +
                "5 - Terra Preta, 6 - Extrema, 7 - Vargem");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite uma data: ");
            dataescolhida = DateTime.Parse(Console.ReadLine());

            if(codigo == 1)
            {
                atibaia = "Atibaia";
                Console.WriteLine(atibaia + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if(codigo == 2)
            {
                bragança = "Bragança Paulista";
                Console.WriteLine(bragança + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if(codigo == 3)
            {
                mairipora = "Mairiporã";
                Console.WriteLine(mairipora + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if(codigo == 4)
            {
                nazare = "Nazaré";
                Console.WriteLine(nazare + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if(codigo == 5)
            {
                terrapreta = "Terra Preta";
                Console.WriteLine(terrapreta + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if(codigo == 6)
            {
                extrema = "Extrema";
                Console.WriteLine(extrema + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else if(codigo == 7)
            {
                vargem = "Vargem";
                Console.WriteLine(vargem + ", " + dataescolhida.ToString("dd MMMM  yyyy") + ".");
            }
            else
            {
                Console.WriteLine("Código Inválido");
            }

            Console.ReadKey();

        }
    }
}
