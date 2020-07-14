using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Dictionary
{
    class Program
    {
        public static bool IsPrime(int n)
        {
            //Единица вроде не простое?
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
                if (n % i == 0) return false;

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите n: ");
            int n;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out n))
                    break;
                else
                    Console.WriteLine("Неверный ввод!");
            }

            Console.Write("Простые числа: ");
            for (int i = 0; i <= n; i++)
            {
                if (i <= 1) continue;
                if (i == 2) Console.Write($"{i} ");
                if (i % 2 == 0) continue;

                for (int j = 3; j <= Math.Sqrt(i); j += 2)
                    if (n % i == 0) continue;
                Console.Write($"{i} ");
            }

            int ii = 0;
            Console.Write("\nПростые числа: ");
            while (true) 
            {
                ii++;
                if (ii > n) break;
                if (ii <= 1) continue;
                if (ii == 2) Console.Write($"{ii} ");
                if (ii % 2 == 0) continue;

                for (int j = 3; j <= Math.Sqrt(ii); j += 2)
                    if (n % ii == 0) continue;
                Console.Write($"{ii} ");
               
            }

            Console.WriteLine();
        }
    }
}
