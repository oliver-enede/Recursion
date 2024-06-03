using System;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Towers of Hanoi
            int num = 4;
            Console.WriteLine("The sequence of moves involved in the Tower of Hanoi are:\n");
            towerOfHanoi(num, 'A', 'C', 'B');
            Console.WriteLine();

            // GCD
            int m = 56;
            int n = 98;
            Console.WriteLine($"The GCD of {m} and {n} is: {GCD(m, n)}");
            Console.WriteLine();

            // Fibonacci
            int fibN = 10;
            Console.WriteLine($"The {fibN}th number in the Fibonacci series is: {fibonacci(fibN)}");

            Console.ReadLine();
        }

        public static void towerOfHanoi(int num, char src, char dst, char temp)
        {
            if (num == 1)
            {
                Console.WriteLine($"Move disk 1 from {src} to {dst}");
                return;
            }

            towerOfHanoi(num - 1, src, temp, dst);
            Console.WriteLine($"Move disk {num} from {src} to {dst}");
            towerOfHanoi(num - 1, temp, dst, src);
        }

        public static int GCD(int m, int n)
        {
            if (n == 0)
                return m;
            return GCD(n, m % n);
        }

        public static int fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}