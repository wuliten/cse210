using System.Runtime.CompilerServices;

public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _entry = "";
    public string _emotion = "";

    public (string, string, string, string) Display()
    {
        Console.Write("What emotion are you feeling?");
        _emotion = Console.ReadLine();
        PromptGenerator getPrompt = new PromptGenerator();
        _prompt = getPrompt.GetRandomPrompt();
        Console.WriteLine(_prompt);
        _entry = Console.ReadLine();
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        return (_prompt, _entry, _emotion, _date);
    }
}