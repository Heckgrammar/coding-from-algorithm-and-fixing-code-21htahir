namespace StartEndCodeFixingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The algorithm in the Readme contains an error
            // Rewrite the algorithm in C# bellow fixing the error
            // Show the test outputs for the test table in the Readme
            // Put your evidence where it says Do the coding task in C#
    static void Main()
    {
        RunTest(1995, 2010);
        RunTest(2010, 2005); 
        RunTest(2000, 2023); 
    }

    static void RunTest(int startYear, int endYear)
    {
        bool validChoice = false;
        int difference = -1;
        
        while (!validChoice)
        {
            if (startYear >= endYear)
            {
                Console.WriteLine("Start year must be before end year");
                break;
            }
            else if (startYear < 2000)
            {
                Console.WriteLine("Start year must be 2000 or later");
                break;
            }
            else
            {
                validChoice = true;
            }
        }

        if (validChoice)
        {
            difference = endYear - startYear;
            Console.WriteLine($"Valid Choice: {validChoice}, Difference: {difference}\n");
        }
        else
            {
                Console.WriteLine($"Valid Choice: {validChoice}, Difference: {difference}\n");
            }
        }
    }
}
