using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static public void DifPay()
        {
            Console.WriteLine("Введите количество лет: ");
            int year;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out year))
                    break;
                else
                    Console.WriteLine("Неверный ввод! (Ожидается целочисленное значение)");
            }

            Console.WriteLine("Введите сумму кредита: ");
            decimal amount;
            while (true)
            {
                if (Decimal.TryParse(Console.ReadLine(), out amount))
                    break;
                else
                    Console.WriteLine("Неверный ввод! (Ожидается вещественное значение)");
            }

            Console.WriteLine("Введите проценты кредита (1-100): ");
            double percent;
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out percent) && percent <= 100 && percent > 0)
                    break;
                else
                    Console.WriteLine("Неверный ввод! (Ожидается вещественное значение)");
            }

            decimal a = amount / (year * 12);
            decimal sum = 0;

            Console.WriteLine("Выплаты по месяцам: ");
            for (int i = 1; i <= year * 12; i++)
            {

                decimal pay = a + (amount * (decimal)percent) / (12 * 100);
                sum += pay;
                amount = amount - a;
                Console.WriteLine($"{i,-2} месяц {Decimal.Round(pay, 3),-2} руб.");
            }

            Console.WriteLine($"Всего к олптае {Decimal.Round(sum, 3), - 2} руб.");
        }

        static public void EqualPay()
        {
            Console.WriteLine("Введите количество лет: ");
            int year;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out year))
                    break;
                else
                    Console.WriteLine("Неверный ввод! (Ожидается целочисленное значение)");
            }

            Console.WriteLine("Введите сумму кредита: ");
            decimal amount;
            while (true)
            {
                if (Decimal.TryParse(Console.ReadLine(), out amount))
                    break;
                else
                    Console.WriteLine("Неверный ввод! (Ожидается вещественное значение)");
            }

            Console.WriteLine("Введите проценты кредита (1-100): ");
            double percent;
            while (true)
            {
                if (Double.TryParse(Console.ReadLine(), out percent) && percent<=100 && percent > 0) 
                    break;
                else
                    Console.WriteLine("Неверный ввод! (Ожидается вещественное значение)");
            }

            double percentPay = (percent / 100 / 12);

            amount = (amount * (decimal)percentPay) / (decimal)(1 - Math.Pow(1 + Convert.ToDouble(percentPay), -year*12));
            decimal pay = (amount);
            decimal sum = 0;

            Console.WriteLine("Выплаты по месяцам: ");
            for (int i = 1; i <= year * 12; i++)
            {
                sum += pay;
                Console.WriteLine($"{i,-2} месяц {Decimal.Round(pay, 3),-2} руб.");
            }

            Console.WriteLine($"Всего к олптае {Decimal.Round(sum, 3),-2} руб.");
        }

        static void Main(string[] args)
        {
            bool exit = false;
            while (exit != true)
            {
                //пусть на любое количество лет, а не только на один год
                Console.WriteLine("Введите: \n1 - для расчета кредита равными долями\n2 - для расчета кредита дифференцированными платежами\nЛюбой символ для выхода из программы");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        EqualPay();
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine();
                        DifPay();
                        break;
                    default:
                        exit = true;
                        break;
                }
            }
        }
    }
}
