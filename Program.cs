using System;

namespace frogFitness
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

          while(keepGoing)
          {
               //Prompt user for minutes exercised
                Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");

                string entry = Console.ReadLine();

                if (entry == "quit")
                {
                    keepGoing = false;
                }
                else{
                    //converts string input to a number
                    int minutes = int.Parse(entry);
                    runningTotal = runningTotal + minutes;

                    //Add minutes exercised to total
                    //Display total minutes exercises to screen
                    Console.WriteLine("You've entered " + runningTotal + " minutes!");
                }
                //Repeat until user quits
            };
            Console.WriteLine("Goodbye!");
        }
    }
}
