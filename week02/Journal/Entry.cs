using System.Runtime.CompilerServices;

public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _entry = "";
    public string _emotion = "";


    public void Display()
    {
        Console.WriteLine($"Today is {_date} and I am feeling {_emotion}. When asked '{_prompt}', my response was '{_entry}'.");
    }
}
