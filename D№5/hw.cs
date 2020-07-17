using System;
using System.Linq;

public class Program
{

    public static void arrTask1()
    {
        int[] a = new int[8];
        Random ran = new Random();
        Console.WriteLine("Массив: ");
        for (int i = 0; i < 8; i++)
        {
            a[i] = ran.Next(11) - 5;
            Console.Write($"{a[i]} ");
        }

        bool chek = false;
        for (int i = 7; i >= 0; i--)
        {
            if (a[i] < 0)
            {
                Console.WriteLine($"\nЗначение последнего отриацтельного элемента {a[i]} и его номер {i + 1}");
                chek = !chek;
                break;
            }
        }
        if (chek == false) Console.WriteLine("\nОтрицательного элемент в данном массиве не обнаружен");
    }

    public static void arrTask2(int n,int m)
    {
        int[,] a = new int[n,m];

        Random ran = new Random();

        Console.WriteLine("Двумерный массив");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = ran.Next(201) - 100;
                Console.Write($"|{a[i, j], -3}| ");
            }
            Console.WriteLine("");
        }

        Console.WriteLine("Измененный массив");

        for (int i = 0; i < n; i++)
        {
            int max = a[i, 0];
            int indexJMax = 0;

            for (int j = 0; j < m; j++)
            {
                if(max<=a[i,j])
                {
                    max = a[i, j];
                    indexJMax= j;
                }
            }

            for (int j = 0; j < m; j++)
            {
                if(indexJMax < j) a[i, j] = 0;
                Console.Write($"|{a[i, j],-3}| ");
            }

            //Можно и так
            //for (int j = indexJMax+1; j < m; j++)
            //{
            //    a[i, j] = 0;
            //}

            //for (int j = 0; j < m; j++)
            //{
            //    Console.Write($"|{a[i, j],-3}| ");
            //}

            Console.WriteLine("");
        }

    }

    public static void arrTask3(int n)
    {

        int[][] arr = new int[n][];

        Random ran = new Random();

        Console.WriteLine("Массив массивов");

        for (int i = 0; i < n; i++)
        {
            int m = ran.Next(10);
            int[] a = new int[m];
            if (m == 0)
            {
                Console.WriteLine($"null ");
                arr[i] = a;
                continue;
            }
            for (int j = 0; j < m; j++)
            {
                a[j] = ran.Next(201) - 100;
                Console.Write($"|{a[j],-3}| ");
            }
            arr[i] = a;
            Console.WriteLine("");
        }

        Console.WriteLine("Измененный массив");

        for (int i = 0; i < n; i++)
        {
            int[] a = arr[i];
            if (a.Length == 0)
            {
                Console.WriteLine($"null ");
                continue;
            }
            int max = a[0];
            int indexJMax = 0;
            for (int j = 0; j < a.Length; j++)
            {
                if (max <= a[j])
                {
                    max = a[j];
                    indexJMax = j;
                }
            }

            for (int j = 0; j < a.Length; j++)
            {
                if (indexJMax < j) a[j] = 0;
                Console.Write($"|{a[j],-3}| ");
            }
            Console.WriteLine("");
        }
    }

    public static void stringTask1(string s)
    {
        char[] vowels = { 'а', 'о', 'и', 'е', 'ё', 'э', 'ы', 'у', 'ю', 'я', 'А', 'О', 'И', 'Е', 'Ё', 'Э', 'Ы', 'У', 'Ю', 'Я' };
        int i = s.Where(l => vowels.Contains(l)).Count();
        if (i == 0) Console.WriteLine("Гласные буквы не обнаружены");
        else
        Console.WriteLine($"Количество гласных {i}");
    }

    public static void stringTask2(string s)
    {
        string output = "";
        for (int i = 0; i < s.Length; i++)
        {
            //русская или англ
            if (s[i] == 'а' || s[i] == 'a') output += "A";
            else output += s[i];
        }
        Console.WriteLine(output);
    }

    public static void Input(out int a)
    {
        while (true)
        {
            if (Int32.TryParse(Console.ReadLine(), out a))
                break;
            else Console.WriteLine("Неверный ввод");
        }
    }

    public static void Main()
    {
        Console.WriteLine("Задание Массивы №1");
        arrTask1();

        Console.WriteLine("Задание Массивы №2");
        Console.WriteLine("Введите размерность двумерного массива");
        int n, m;
        Console.WriteLine("Введите n");
        Input(out n);
        Console.WriteLine("Введите m");
        Input(out m);

        arrTask2(n, m);

        Console.WriteLine("Задание Массивы №3");
        n = 0;
        Console.WriteLine("Введите размерность основного массива массива");
        Input(out n);

        arrTask3(n);


        Console.WriteLine("Задание Строки №1");
        Console.WriteLine("Введитие строку для подсчета количества гласных");
        stringTask1(Console.ReadLine());

        Console.WriteLine("Задание Строки №1");
        Console.WriteLine("Введитие строку для замены 'а' на 'А' ");
        stringTask2(Console.ReadLine());
    }
}
