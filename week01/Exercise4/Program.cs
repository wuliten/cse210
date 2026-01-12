using System;
using System.Collections.Generic;

    


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        string inputString = "";

        do
        {
            Console.Write("Enter Number: ");
            inputString = Console.ReadLine();
            if (inputString != "0")
            {
                numbers.Add(int.Parse(inputString));
            }

        } while (inputString != "0");
        int sum = 0;
        int largest = 0;
        for (int i=0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        int average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}