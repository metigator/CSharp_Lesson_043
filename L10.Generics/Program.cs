using System;

namespace L10.Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static T? DoSomething<T>(T source)
        {
            return source;
        }
    }
}
