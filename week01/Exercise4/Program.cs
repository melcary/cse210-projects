using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> nums = new List<int>();
        int num = -1;

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num != 0)
            {
                nums.Add(num);
            }
        }

        int sum = 0;

        foreach (int i in nums)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / nums.Count;
        Console.WriteLine($"The average is: {average}");

        int max = nums[0];
        int min = nums[0];

        foreach (int i in nums)
        {
            if (i > max)
            {
                max = i;
            }
            if (i < min)
            {
                min = i;
            }

        }
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The shortest number is: {min}");
        int smallestPositive = nums.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");

        nums.Sort();

        foreach (int i in nums)
        {
            Console.WriteLine(i);
        }
    }
}