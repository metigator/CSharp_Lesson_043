using System.Diagnostics.CodeAnalysis;

namespace L11.StructAndArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            //Print(default);

            string[] names = new string[10];
            var firstValue = names[0];
            Console.WriteLine(firstValue.ToUpper());
            Console.ReadLine();
        } 

        static void Print(Student student)
        {
            Console.WriteLine($"First Name: {student.FirstName.ToUpper()}");
            Console.WriteLine($"Middle Name: {student.FirstName?.ToUpper()}");
            Console.WriteLine($"Last Name: {student.LastName.ToUpper()}");
        }
        
    }

    // struct contains reference types
    public struct Student
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;
    }
}