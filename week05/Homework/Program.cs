using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment1 = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment1.GetSummary());

        MathAssigment assigment2 = new MathAssigment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());

        WritingAssigment assigment3 = new WritingAssigment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assigment3.GetSummary());
        Console.WriteLine(assigment3.GetWritingInformation());
    }
}