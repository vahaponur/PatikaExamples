using System;

namespace ClassLibrary1
{
    public class Class1
    {
        byte b = 5;
        sbyte c = 5;
        //But it actually doesn't matter

        public static void throwException(string message)
        {
            if (message.Contains("exception"))
            {
                throw new Exception("message");
            }
        }

    }

}
