using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Scripture scripture = LoadRandomScripture("scriptures.txt");

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden!");
                    break;
                }

                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    return;
                }

                scripture.HideRandomWords(3);
            }

            Console.WriteLine("\nWould you like to restart? (yes/no)");
            string restart = Console.ReadLine().ToLower();

            if (restart != "yes")
            {
                break;
            }
        }
    }

    static Scripture LoadRandomScripture(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        Random rand = new Random();
        string line = lines[rand.Next(lines.Length)];

        string[] parts = line.Split("|");

        string book = parts[0];
        int chapter = int.Parse(parts[1]);
        int startVerse = int.Parse(parts[2]);

        Reference reference;

        if (parts.Length == 6)
        {
            int endVerse = int.Parse(parts[3]);
            reference = new Reference(book, chapter, startVerse, endVerse);
        }
        else
        {
            reference = new Reference(book, chapter, startVerse);
        }

        string text = parts[^1];
        return new Scripture(reference, text);
    }
}
