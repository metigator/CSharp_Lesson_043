using System;

namespace L01.CompileVsRunTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "123A";
            // "compile time" building source code and convert it to IL
            // int num1 = input; // CS0029 can't convert string to int

            //  "runtime" when you excuted the compiled code
            int num2 = int.Parse(input);
            Console.ReadKey();
        }
    }
}
