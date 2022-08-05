using System;
using System.Linq;

namespace termoeléctrica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("cantidad de temperaturas:");
            int num_temperaturas = int.Parse(Console.ReadLine());

            int[] temperatura = new int[num_temperaturas];
            int prom = 0;
            int v1 = 0;

            for (int x = 0; x <= num_temperaturas-1; x++)
            {
                Console.WriteLine("temperatura ");
                v1 = int.Parse(Console.ReadLine());
                temperatura[x] = v1;
                prom = prom + temperatura[x];
            }
            prom = prom / num_temperaturas;

            Console.Write("\n\nla temperatura promedio es: " + prom);
            Console.Write("\n\nla temperatura mayor es : " + temperatura.Max());
            Console.Write("\n\nla temperatura menor es : " + temperatura.Min());

        }
    }
}
