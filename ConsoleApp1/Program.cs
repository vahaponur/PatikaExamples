using ClassLibrary1;
using System;
using ClassLibrary1.Odevler;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int weight = 80;
            if (weight<=(int)BodyType.Fat)
            {
                Console.WriteLine("NOT "+BodyType.Fat);
            }
        }

    }
    public enum BodyType
    {
        Fat=100,
        Skinny=40,
        Normal=70,
    }
}
