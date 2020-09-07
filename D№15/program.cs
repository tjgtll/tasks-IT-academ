using System;
using System.Linq;

namespace console
{
    class Program
    {
        private static void Quicksort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int i = left;
            int j = right;

            var pivot = array[left + (right - left) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                    i++;

                while (array[j].CompareTo(pivot) > 0)
                    j--;

                if (i <= j)
                {
                    var tmp = array[i];
                    array[i] = array[j];
                    array[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                Quicksort(array, left, j);

            if (i < right)
                Quicksort(array, i, right);
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 3, 5, 7, 8, 4, 2, 1, 9, 6 };

            double[] a1 = new double[] { 3, 5, 7, 8, 4, 2, 1, 9, 6 };

            string[] s1 = new string[] { "3", "5", "7", "8", "4", "2", "1", "9", "6" };

            Quicksort(a, 0, a.Length - 1);
            Quicksort(a1, 0, a1.Length - 1);
            Quicksort(s1, 0, s1.Length - 1);
            Console.WriteLine();
        }
    }
}
