using System;

namespace ClassLibrary1
{
    public static class Class1
    {
   

        public static void throwException(string message)
        {
            if (message.Contains("exception"))
            {
                throw new Exception("message");
            }
        }
        public static int[] Merge(int[] d1, int[] d2)
        {
            int[] d3 = new int[d2.Length + d1.Length];
            for (int i = 0; i < d1.Length; i++)
            {
                int secondIndex = 0;
                for (int j = d1.Length; j < d1.Length + d2.Length; j++)
                {

                    d3[i] = d1[i];
                    d3[j] = d2[secondIndex];
                    secondIndex++;
                }
            }

            return d3;
        }
        public static void DortKarakterBul(string[,] srr) {

            int dortluSayisi = 0;
            Console.WriteLine(srr.Length);
            for (int i = 0; i < srr.Length; i++)
            {
               
            }
        }

    }

}
