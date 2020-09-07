using System;
using System.Linq;

namespace console
{
    class Program
    {
        static void quicksort<T>(T[] arr, int min, int max) where T : IComparable<T>
        {

            if (min >= max) return;

            int i = min;
            int j = max;
            var p = arr[(min + max) / 2];

           
            while (i < j)
            {
                while (arr[i].CompareTo(p) < 0) i++;
                while (arr[j].CompareTo(p)  > 0) j--;
                if (i <= j)
                {
                    var buf = arr[i];
                    arr[i] = arr[j];
                    arr[j] = buf;
                    i++;
                    j--;

                }
            }

            quicksort(arr, min, j);

            quicksort(arr, i, max);
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 5, 7, 8, 4, 2, 1, 9, 6 };

            double[] a1 = new double[] { 3, 5, 7, 8, 4, 2, 1, 9, 6 };

            string[] s1 = new string[] { "3", "5", "7", "8", "4", "2", "1", "9", "6" };

            quicksort(a, 0, a.Length - 1);
            quicksort(a1, 0, a1.Length - 1);
            quicksort(s1, 0, s1.Length - 1);
            Console.WriteLine();
        }
    }
}
