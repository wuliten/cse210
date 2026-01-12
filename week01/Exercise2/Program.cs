using System;
using System.Runtime.CompilerServices;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your grade percentage:");
        string input = Console.ReadLine();
        int percent = int.Parse(input);
        string output = "";
        if (percent >= 90)
        {
            output = "A";
        }
        else if (percent >= 80)
        {
            output = "B";
        }
        else if (percent >= 70)
        {
            output = "C";
        }
        else if (percent >= 60)
        {
            output = "D";
        }
        else
        {
            output = "F";
        }
        Console.WriteLine($"Your grade is {output}");
        if (percent >= 70)
        {
            Console.WriteLine("You passed! Good job!");
        }
        else
        {
            Console.WriteLine("Try harder next time!");
        }
    

    }

}