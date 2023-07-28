using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        private static void doApp()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }

            Console.Write("Enter a day number (1-7): ");
            input = Console.ReadLine();
            int day = int.Parse(input);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;
            }

            Console.Write("Enter the end value for the loop: ");
            input = Console.ReadLine();
            int endValue = int.Parse(input);

            for (int i = 1; i <= endValue; i++)
            {
                Console.WriteLine("Current value of i: " + i);
            }
            Console.Write("Enter the number of times to loop: ");
            input = Console.ReadLine();
            int loopCount = int.Parse(input);

            int count = 0;
            while (count < loopCount)
            {
                Console.WriteLine("Current count: " + count);
                count++;
            }
        }
    }
}
