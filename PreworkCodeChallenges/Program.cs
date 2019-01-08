using System;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProblemOne();
            ProblemTwo();
        }

        static void ProblemOne()
        {
            Console.Write("Enter five numbers between 1 & 10, separated by spaces: ");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split();
            Console.WriteLine($"Enter a number from the following list: {string.Join(", ", numbers)}");
            string numberSelection = Console.ReadLine();

            int count = 0;
            foreach(string num in numbers)
            {
                if(num == numberSelection)
                {
                    count++;
                }
            }
            Console.WriteLine($"The number {numberSelection} has a score of {int.Parse(numberSelection) * count}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        static void ProblemTwo()
        {
            Console.Write("Enter a year: ");
            string userInput = Console.ReadLine();
            int year = int.Parse(userInput);

            if(year % 4 != 0)
            {
                // odd year, not a leap year
                Console.WriteLine($"{year} is not a leap year");
            }
            else if( (year % 100 == 0) && (year % 400 == 0))
            {
                //even year divisible by 100 AND 400, leap year
                Console.WriteLine($"{year} is a leap year");
            }
            else if(year % 100 == 0)
            {
                //even year divisible by 100 but not 400, not a leap year
                Console.WriteLine($"{year} is not a leap year");
            }
            else
            {
                //even year that doesn't meet other exceptions
                Console.WriteLine($"{year} is a leap year");
            }                
        }
    }
}
