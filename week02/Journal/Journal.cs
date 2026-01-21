using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Journal
{

    List<Entry> _entries = new List<Entry>();
    public string _fileName = "";
    public void addEntry()
    {

        Entry newEntry = new Entry();
        Console.Write("What emotion are you feeling?");
        newEntry._emotion = Console.ReadLine();
        PromptGenerator getPrompt = new PromptGenerator();
        newEntry._prompt = getPrompt.GetRandomPrompt();
        Console.WriteLine(newEntry._prompt);
        newEntry._entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        newEntry._date = theCurrentTime.ToShortDateString();
        _entries.Add(newEntry);


    }
    public void displayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void loadFile(string fileNameEntry)
    {
        
        string[] lines = System.IO.File.ReadAllLines(fileNameEntry);
        foreach (string line in lines)
        {
            Entry loadEntry = new Entry();
            string[] parts = line.Split(",");
            string dateLoad = parts[0];
            string emotionLoad = parts[1];
            string promptLoad = parts[2];
            string entryLoad = parts[3];
            loadEntry._date = dateLoad;
            loadEntry._emotion = emotionLoad;
            loadEntry._prompt = promptLoad;
            loadEntry._entry = entryLoad;
            if (loadEntry._date != "Date")
            {
                _entries.Add(loadEntry);
            }
            
        }
    }
    public void saveFile(string fileNameEntry)
    {
        string fileNameExt = $"{fileNameEntry}.csv";
        using (StreamWriter outputFile = new StreamWriter(fileNameExt))
        {
            outputFile.WriteLine("Date,Emotion,Prompt,Entry");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._emotion},{entry._prompt},{entry._entry}");
            }
            
        }
    }


}