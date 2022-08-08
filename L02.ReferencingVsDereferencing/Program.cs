using System;

namespace L02.ReferencingVsDereferencing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string is reference type
            string str1 = default; // default is null string str1 = null;
            string str2 = "Issam";
            // dereferencing follow tge reference pointed to access the
            // underlying object
            Console.WriteLine(str2.Length); // 5
            Console.WriteLine(str1.Length); // Null reference exception

            // value type
            DateTime datetime = default; // default is '0001/01/01 00:00 AM'
            Console.WriteLine(datetime.Month);
            Console.ReadKey();
        }
    }
}
