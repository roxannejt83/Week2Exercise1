using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Exercise1
{
    class GradeConverter // Declares class that contains the main method where the execution starts
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your numeric score (0 to 100): "); // Prompt the user to enter their numeric score
            double score = Convert.ToDouble(Console.ReadLine()); // Read the input from the user and convert it to a double.  Using double allows program to handle decimal values
            switch (score) // Determine the letter grade using the switch statement
            {
                case double n when (n >= 89.5 && n <= 100): // Check if the score is between range of 89.5 and 100
                    Console.Write("The grade is: A.  Press 'Enter' to exit.");  // Prints letter grade of numeric score that was entered by user
                    break; // Prematurely exits program
                case double n when (n >= 79.5 && n < 89.5): // Check if the score is between range of 79.5 and 89.5
                    Console.Write("The grade is: B.  Press 'Enter' to exit.");  // Prints letter grade of numeric score that was entered by user
                    break; // Prematurely exits program
                case double n when (n >= 69.5 && n < 79.5): // Check if the score is between range of 69.5 and 79.5
                    Console.Write("The grade is: C.  Press 'Enter' to exit.");  // Prints letter grade of numeric score that was entered by user
                    break; // Prematurely exits program
                case double n when (n >= 59.5 && n < 69.5): // Check if the score is between 59.5 and 69.5
                    Console.Write("The grade is: D.  Press 'Enter' to exit.");  // Prints letter grade of numeric score that was entered by user
                    break; // Prematurely exits program
                case double n when (n < 59.5): // Check if the score is under 59.5
                    Console.Write("The grade is: F.  Press 'Enter' to exit.");  // Prints letter grade of numeric score that was entered by user
                    break; // Prematurely exits program
                default: // Default case if the input is not within the expected range
                    Console.Write("Invalid score entered/  Press 'Enter' to exit."); // Prints an alert notifying use that an invalid number score was entered
                    break ; // Prematurely exits program
            }
            Console.ReadLine(); // Wait to close
        }
    }
}
