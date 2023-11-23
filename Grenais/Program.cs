using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Globalization;
using System.Net.Http.Headers;
using System.Net.Mail;

namespace Grenais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vitoriasinter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int golsinter = int.Parse(valores[0]);
                int golsGremio = int.Parse(valores[1]);

                if (golsinter > golsGremio)
                {
                    vitoriasinter = vitoriasinter + 1;
                }
                else if (golsGremio > golsinter)
                {
                    vitoriasGremio = vitoriasGremio + 1;
                }
                else
                {
                    empates = empates + 1;
                }
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }
            int total = vitoriasGremio + vitoriasinter + empates;

            Console.WriteLine(total + " grenais");
            Console.WriteLine("Inter:" + vitoriasinter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasinter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if (vitoriasGremio > vitoriasinter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else
            {
                Console.WriteLine("Nao houve vencedor ");
            }
        }
    }
}