using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    

    static void Main(string[] args)
    {
        string input = "";
        Journal myJournal = new Journal();
        do
        {
            Console.WriteLine("Welcome to your Journal, please select an option by entering 1-5:");
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save to file");
            Console.WriteLine("4. Load from file");
            Console.WriteLine("5. Quit");
            input = Console.ReadLine();
            
            
            if (input == "1")
            {
                myJournal.addEntry();
            }
            else if (input == "2")
            {
                myJournal.displayAll();
            }
            else if (input == "3")
            {
                Console.WriteLine("Please enter a file name:");
                myJournal._fileName = Console.ReadLine();
                myJournal.saveFile(myJournal._fileName);
            }
            else if (input == "4")
            {
                Console.WriteLine("Please enter a file name:");
                myJournal._fileName = Console.ReadLine();
                myJournal.loadFile(myJournal._fileName);
            }
            else if (input == "5")
            {
                Console.WriteLine("Goodbye!");
            }

        } while (input != "5");
    }
}