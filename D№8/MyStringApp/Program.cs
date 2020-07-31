using System;

namespace MyStringApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyString s = "dada:b";

            MyString s2 = "Коля";

            Console.WriteLine(s2[0]);
            Console.WriteLine(MyString.Name);

            Console.WriteLine(s + s2);
            s.CopyTo(ref s2, 2);
            Console.WriteLine(s2);
            s = s.Concat("sadsdfa");
            Console.WriteLine(s);
        }
    }
}
