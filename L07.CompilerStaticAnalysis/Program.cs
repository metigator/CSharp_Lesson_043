namespace L07.CompilerStaticAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.ReadKey();
        }

        private static string? GetName()
        {
            return null;
        }

        #region  Non-null
        static bool Scenario1()
        {
            string name = String.Empty; // Assignment of non null value
            return name.Length > 10;
        }
        static bool Scenario2()
        {
            string? name = GetName();
            if (name == null) // checked against null
                return false;
            return name.Length > 10; // name shouldn't be null
        }
        #endregion

        #region  Maybe-null
        static bool MaybeNullScenario()
        {
            string? name = GetName();
            return name.Length > 10; // maybe null
        }
        #endregion 

    }
}
