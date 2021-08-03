using System;
using System.Collections.Generic;

namespace DECToBIN
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());
            decToBin(dec);
            for (int i = 1; i <= dec; i++)
            {
                decToBin(i);
                Console.WriteLine();
            }
        }
        static void decToBin(int dec)
        {
            Stack<int> bin = new Stack<int>();
            while (dec != 0)
            {
                if (dec % 2 == 0)
                {
                    bin.Push(0);
                }
                else
                {
                    bin.Push(1);
                }
                dec /= 2;
            }
            foreach (var item in bin)
            {
                Console.Write(item);
            }
        }
    }
}
