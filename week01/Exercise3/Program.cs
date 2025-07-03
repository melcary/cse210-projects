using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //Part1
        //Console.Write("What is the magic number? ");
        //int num = int.Parse(Console.ReadLine());

        Random randomNum = new Random();
        int num = randomNum.Next(1, 101);

        int response = -1;

        while (response != num)
        {
            Console.Write("What is your guess? ");
            response = int.Parse(Console.ReadLine());

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
    }
}