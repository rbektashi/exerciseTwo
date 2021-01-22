using System;

namespace exerciseTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Update your variable to ask the user for their social security number, store their input into a string variable
            string greetingMessage = "Please enter your SSN";
            Console.WriteLine(greetingMessage);
            string SSN = Console.ReadLine();
            // Display only the first digits of their SSN
            Console.WriteLine(SSN.Remove(3,8));
            // Display only the last four digits of their SSN
            Console.WriteLine(SSN.Remove(0, 7));
            // Display the whole SSN removing all dashes and replacing all but the last four digits with the * symbol
            Console.WriteLine("*****" + SSN.Substring(SSN.Length - 4, 4));

        }
    }
}
