using System;
using System.Collections.Generic;

namespace CodeChallengePrework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.Read();
            //ArrayMaxResult();
            //LeapYearCalculator();
            PerfectSequence();
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

        /*static void LeapYearCalculator()
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
        }*/

        static void PerfectSequence()
        {
            //Console.WriteLine("Hello 3");
            List<int> sequence = new List<int>();

            Console.WriteLine("Input any sequence of whole numbers positive or negitive. Hit enter after each entry and type \"done\" when complete.");
            Console.WriteLine("If the sum and product of the sequence are equal the sequence is perfect.");

            bool inputSequence = true;

            while (inputSequence)
            {
                string inputValues = Console.ReadLine();

                if (inputValues == "done")
                {
                    int sequenceSum = 0;
                    int sequenceProduct = 1;

                    foreach (var value in sequence)
                    {
                        sequenceSum += value;
                        sequenceProduct *= value;
                    }
                    if (sequenceSum == sequenceProduct)
                    {
                        Console.WriteLine("Perfect");
                    }
                    else
                    {
                        Console.WriteLine("Imperfect");
                    }
                    inputSequence = false;
                }
                else
                {
                    int val;
                    int.TryParse(inputValues, out val);
                    sequence.Add(val);
                    //Console.WriteLine("Nope");
                }
            }
            //Console.Read();
        }


    }
}
