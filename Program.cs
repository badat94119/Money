using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USD = ");
            string value = Console.ReadLine()!;
            int price = Convert.ToInt32(value) * 23000;
            Console.WriteLine("VND = " + price);
        }
    }
}
