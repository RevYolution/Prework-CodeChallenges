using System;

namespace CodeChallengePrework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();
            //ArrayMaxResult();
            LeapYearCalculator();
        }

        /*static void ArrayMaxResult ()
        {
            //Console.WriteLine("Hello First!");
            //Console.Read();
            int[] pickedNumbers = new int[5];
            int timesPicked = 0;

            for (int i = 0; i < pickedNumbers.Length; i++)
            {
                Console.WriteLine("Choose a number between 1 and 10: ");
                string numberPicked = Console.ReadLine();
                if (Int32.TryParse(numberPicked, out timesPicked) && int.Parse(numberPicked) > 0 && int.Parse(numberPicked) <= 10)
                {
                    pickedNumbers[i] = int.Parse(numberPicked);
                }
                else
                {
                    Console.WriteLine("That is not a number between 1 and 10. Try again");
                    i = i - 1;
                }
            }
            Console.WriteLine($"Your numbers are [{pickedNumbers[0]}, {pickedNumbers[1]}, {pickedNumbers[2]}, {pickedNumbers[3]}, {pickedNumbers[4]}]");
            Console.WriteLine("Pick a number from your list: ");

            int scoreInput = int.Parse(Console.ReadLine());
            int pickedNumberCounter = 0;

            for (int i = 0; i < pickedNumbers.Length; i++)
            {
                if (pickedNumbers[i] == scoreInput)
                {
                    pickedNumberCounter = +1;
                }
            }
            Console.WriteLine($"Your score is {scoreInput * pickedNumberCounter}");
            //Console.WriteLine("Choose a number between 1 and 10: ");
            //Console.Read();

        }*/

        static void LeapYearCalculator()
        {
            //Console.WriteLine("Hello Second!");

            Console.WriteLine("Want to know if a year is a leap year? Input a year to find out: ");
            int leapYear = int.Parse(Console.ReadLine());
            if (leapYear % 4 == 0)
            {
                Console.WriteLine($"{leapYear} is a leap year");
            }
            else
            {
                Console.WriteLine($"{leapYear} is not a leap year");
            }
            //Console.Read();
        }

    }
}
