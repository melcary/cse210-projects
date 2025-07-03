using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Part1
        //Console.Write("What is the magic number? ");
        //int num = int.Parse(Console.ReadLine());

        string answer = "yes";

        while (answer == "yes")
        {
            Random randomNum = new Random();
            int num = randomNum.Next(1, 101);

            int response = -1;
            int count = 0;

            while (response != num)
            {
                Console.Write("What is your guess? ");
                response = int.Parse(Console.ReadLine());
                count += 1;

                if (response > num)
                {
                    Console.WriteLine("Lower");
                }
                else if (response < num)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You gessed it!");
                }
            }
            Console.WriteLine($"It took you {count} guesses");
            Console.WriteLine("Would you like to continue playing (yes | no)?: ");
            answer = Console.ReadLine();
        }
    }
}