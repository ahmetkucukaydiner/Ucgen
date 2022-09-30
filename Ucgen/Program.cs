using System;

namespace Ucgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgen için uzunluk giriniz: ");
            int edge = int.Parse(Console.ReadLine());
            Ucgen(edge);
        }

        static void Ucgen(int e)
        {
            for (int i = 0; i < e; i++)
            {
                for(int j = i; j < e-1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
