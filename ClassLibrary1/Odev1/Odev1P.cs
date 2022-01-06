using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ClassLibrary1.Odev1
{
    public static class Odev1P
    {
        public static void Soru1()
        {
            Console.WriteLine("Array boyutu giriniz");
            int.TryParse(Console.ReadLine(),out int n);
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out int sayi);
                array[i] = sayi;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]%2==0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        public static void Soru2()
        {
            Console.WriteLine("Array Boyutu:");
            int.TryParse(Console.ReadLine(), out int n);
            Console.WriteLine("kontrol sayisi");
            int.TryParse(Console.ReadLine(), out int m);
            var array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                int.TryParse(Console.ReadLine(), out int sayi);
                array[i] = sayi;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % m == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        public static void Soru3()
        {
            Console.WriteLine("Array boyutu giriniz");
            int.TryParse(Console.ReadLine(), out int n);
            var array = new string[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }
             Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        public static void Soru4()
        {
            string cumle = Console.ReadLine();
            string[] kelimeler = cumle.Split(" ");
            int harfSayisi = 0;
            foreach (var item in kelimeler)
            {
                Console.WriteLine(item);
                foreach (var harf in item)
                {
                    harfSayisi++;
                }
            }
            Console.WriteLine("Harf Sayisi: "+harfSayisi);
        }

    }
}
