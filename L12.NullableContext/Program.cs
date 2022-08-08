using System;

namespace L12.NullableContext
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string? fname = null; // read from user
            string lname = null; // read from user
            var person = new Person(fname.ToUpper(), lname.ToLower());
            Console.ReadKey();
        }
    }
}