using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClassLibrary1.Class1.throwException("this is an exception");
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
