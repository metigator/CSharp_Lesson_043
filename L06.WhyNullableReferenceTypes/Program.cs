namespace L06.WhyNullableReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name =  null;
            string decision = IsLongName(name) ? "long" : "short";
            Console.WriteLine($"{name} is {decision}");
            Console.ReadKey();
        }  

        static bool IsLongName(string? name)
        {
            if (name is null)
                return false;

            return name.Length > 10; // assumption name could be null 
         
        }
    }
}
