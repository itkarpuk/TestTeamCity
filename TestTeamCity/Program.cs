using System;

namespace TestTeamCity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(GetSum(10, 20));
            Console.WriteLine("-----------------------------------\nThe END!");

            Console.ReadKey();
        }

        public static int GetSum(int a, int b)
        {
            return a + b;
        }
    }
}
