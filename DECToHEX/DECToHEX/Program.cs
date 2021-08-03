using System;
using System.Collections.Generic;
using System.Collections;
namespace DECToHEX
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Stack<int> hex = new Stack<int>();
            while (num != 0)
            {
                hex.Push(num % 16);
                num /= 16;
            }
            foreach (var n in hex)
            {
                if(n < 10)
                {
                    Console.Write(n);
                }
                else
                {
                    if (n == 10) { Console.Write('A'); }
                    if (n == 11) { Console.Write('B'); }
                    if (n == 12) { Console.Write('C'); }
                    if (n == 13) { Console.Write('D'); }
                    if (n == 14) { Console.Write('E'); }
                    if (n == 15) { Console.Write('F'); }
                }
            }
        }
    }
}
