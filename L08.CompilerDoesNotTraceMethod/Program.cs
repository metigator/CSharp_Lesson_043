using System.Diagnostics.CodeAnalysis;

namespace L08.CompilerDoesNotTraceMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // var person = new Person(null, null);
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class Student : Person
    {
        public string Major { get; set; }

        public Student(string firstName, string lastName, string major)
            : base(firstName, lastName)
        {
            SetMajor(major);
        }

        public Student(string firstName, string lastName) :
            base(firstName, lastName)
        {
            SetMajor();
        }

        [MemberNotNull(nameof(Major))]
        public void SetMajor(string? major = default)
        {
            Major = major ?? "Undeclared";
        }
    }
}
 


