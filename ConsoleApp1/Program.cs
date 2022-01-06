using ClassLibrary1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] D1 = { 1, 2, 3, 5, 7 };
            int[] D2 = { 10, 20, 30, 50, 70 };
            int[] D3 = Class1.Merge(D1, D2);
            foreach (var item in D3)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

    }
}
