using System;

namespace PreworkCodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemOne();
            ProblemTwo();
        }

        static void ProblemOne()
        {
            Console.WriteLine("Enter five numbers between 1 & 10, separated by spaces");
            string userInput = Console.ReadLine();
            string[] numbers = userInput.Split();
            Console.WriteLine($"Enter a number from the following list: {string.Join(", ", numbers)}");
            string numberSelection = Console.ReadLine();

            int count = 0;
            foreach(string num in numbers){
                if(num == numberSelection){
                    count++;
                }
            }
            Console.WriteLine($"The number {numberSelection} has a score of {int.Parse(numberSelection) * count}");
            Console.WriteLine("Press any key to continue");
            Console.ReadLine();
        }

        static void ProblemTwo()
        {

        }
    }
}
