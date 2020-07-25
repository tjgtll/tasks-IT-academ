using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp28
{
    public class MyQueue
    {
        public string Value { get; set; }

        public int Key { get; set; }
    }

    class Program
    {
        static public void WhileStack(ref Stack<string> studens)
        {
            while (true)
            {
                Console.WriteLine("\n1 - Добавить студента\n2 - Выдать кофе студенту\n3 - Выход"); 
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nВведите стундента");
                        studens.Push(Console.ReadLine());
                        break;

                    case ConsoleKey.D2:

                        Console.WriteLine();
                        if (studens.Count != 0)
                            Console.WriteLine($"{studens.Pop()} получил крушку кофе");
                        else Console.WriteLine("Стундентов нет");
                        break;

                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static public void WhileQueue(ref Queue<string> studens)
        {
            while (true)
            {
                Console.WriteLine("\n1 - Добавить студента\n2 - Выдать кофе студенту\n3 - Выход"); 
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nВведите стундента");
                        studens.Enqueue(Console.ReadLine());
                        break;

                    case ConsoleKey.D2:

                        Console.WriteLine();
                        if (studens.Count != 0)
                            Console.WriteLine($"{studens.Dequeue()} получил крушку кофе");
                        else Console.WriteLine("Стундентов нет");
                        break;

                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static public void WhileMyQueue(ref List<MyQueue> studens)
        {
            while (true)
            {
                Console.WriteLine("\n1 - Добавить студента\n2 - Выдать кофе студенту\n3 - Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine("\nВведите стундента");
                        string value = Console.ReadLine();

                        Console.WriteLine("Введите приоритет студента");
                        int key;
                        while (true)
                        {
                            if (Int32.TryParse(Console.ReadLine(), out key))
                                break;
                            else
                                Console.WriteLine("Неверный ввод!");
                        }

                        studens.Add(new MyQueue() { Value = value, Key = key });

                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine();
                        if (studens.Count != 0)
                        {
                            var itemToRemove = studens.OrderBy(r => -r.Key).First();
                            Console.WriteLine($"{itemToRemove.Value} получил крушку кофе");

                            studens.Remove(itemToRemove);
                        }
                        else Console.WriteLine("Стундентов нет");
                        break;

                    case ConsoleKey.D3:
                        return;
                }
            }
        }

        static void Main(string[] args)
        {
            Stack<string> studensS = new Stack<string>();
            Queue<string> studensQ = new Queue<string>();
            List<MyQueue> ListQueue = new List<MyQueue>();

            while (true)
            {
                Console.WriteLine("\n1 - Stack\n2 - Queue\n3 - MyQueue\nq - Выход");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        WhileStack(ref studensS);
                        break;
                    case ConsoleKey.D2:
                        WhileQueue(ref studensQ);
                        break;
                    case ConsoleKey.D3:
                        WhileMyQueue(ref ListQueue);
                        break;
                    case ConsoleKey.Q:
                        return;
                }
            }
        }
    }
}
