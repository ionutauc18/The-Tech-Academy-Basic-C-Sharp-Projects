using System;
using System.Collections.Generic;

namespace ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This line is an array of strings
            string[] PremChampArray = { "Manchester City FC", "Arsenal FC", "Liverpool FC", "Manchester United FC", "Newcastle United FC", "Tottenham Hotspur FC" };
            // This line asks the user for a number to display the string at that index
            Console.WriteLine("Select a number between 0 and 5:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favourite football club is " + PremChampArray[stringSelect]);
                    validString = true;
                }
                // This line adds an error message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 5. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            // This line is a list of strings
            List<string> BestPlayerList = new List<string>()
        {   "Erling Haaland",
            "Bukayo Saka",
            "Mohammed Salah",
            "Bruno Fernandes",
            "Nick Pope",
            "Heung Min Son"
        };
            // This line asks the user for a number to display the string at that index
            Console.WriteLine("\nSelect another number between 0 and 5:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList)
            {
                try
                {
                    Console.WriteLine("The best player of your team is: " + BestPlayerList[listSelect]);
                    validList = true;
                }
                // This line adds an error message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry,that number selection is invalid. Select a number between 0 and 5. ");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();

        }
    }
}
