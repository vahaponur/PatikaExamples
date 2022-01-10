using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ClassLibrary1.Odevler
{
    public static class Odev2
    {
        public static void Soru1()
        {
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                
                    if (!int.TryParse(Console.ReadLine(), out int n))
                    {
                        throw new Exception("Sayı gir krdşm dalga mı geçiyosun?");
                    }
                    
                    if (n<0)
                    {
                        throw new Exception("girilen sayı 0 dan küçük olamaz");
                    }
                    arrList.Add(n);
                
             
            }
            ArrayList asal = new ArrayList(arrList.Cast<int>().Where(s=>Check_Prime(s)).ToList());
            ArrayList asalDegil = new ArrayList(arrList.Cast<int>().Where(s => !Check_Prime(s)).ToList());
            asal.Sort();asal.Reverse();
            asalDegil.Sort();asalDegil.Reverse();
            Console.WriteLine("Asal Değil");
            foreach (var item in asalDegil)
            {
                
                Console.Write(item +",");
                
            }
            Console.WriteLine();
            Console.WriteLine("Asal");
            foreach (var item in asal)
            {

                Console.Write(item+",");
            }
        }
        public static void Soru2()
        {
            int[] girilen = new int[20];
            for (int i = 0; i < girilen.Length; i++)
            {

                if (!int.TryParse(Console.ReadLine(), out int n))
                {
                    throw new Exception("Sayı gir krdşm dalga mı geçiyosun?");
                }

                if (n < 0)
                {
                    throw new Exception("girilen sayı 0 dan küçük olamaz");
                }
                girilen[i] = n;

            }

            int[] small3 = new int[3];
            Array.Sort(girilen);
            Array.Copy(girilen, small3, 3);
            Console.WriteLine("Small 3");
            foreach (var item in small3)
            {
                Console.Write(item+",");
            }
            Console.WriteLine();
            Array.Reverse(girilen);
            int[] big3 = new int[3];
            Array.Copy(girilen, big3, 3);
            Console.WriteLine("Big 3");
            foreach (var item in big3)
            {
                Console.WriteLine(item+",");
            }
        }

        private static bool Check_Prime(int number)
        {
            int i;
            for (i = 2; i <= number - 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            if (i == number)
            {
                return true;
            }
            return false;
        }
    }
}
