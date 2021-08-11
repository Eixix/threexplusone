using System;

namespace Collatz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++) collatz(i);
        }

        static void collatz(int i) {
            Console.WriteLine(i);
            if (i != 1)
            {
                int next;
                if (i % 2 == 1)
                {
                    next = 3 * i + 1;
                }
                else {
                     next = i / 2;
                }
                collatz(next);
            }
        }
    }
}