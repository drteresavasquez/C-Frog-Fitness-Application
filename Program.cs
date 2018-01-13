using System;

namespace frogFitness
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
           //Prompt user for minutes exercised
           Console.Write("Enter how many minutes you exercised: ");

           string entry = Console.ReadLine();

           //converts string input to a number
           int minutes = int.Parse(entry);
           runningTotal = runningTotal + minutes;

           //Add minutes exercised to total
           //Display total minutes exercises to screen
           Console.WriteLine("You've entered " + runningTotal + " minutes!");


           //Repeat until user quits

        }
    }
}
