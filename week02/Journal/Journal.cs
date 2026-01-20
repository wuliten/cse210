using System.Security.Cryptography.X509Certificates;

public class Journal
{

    List<Entry> _entries = new List<Entry>();

    public void addEntry()
    {
        Entry newEntry = new Entry();
        var (prompt1, entry1, emotion1, date1) = newEntry.Display();
        newEntry._emotion = emotion1;
        newEntry._prompt = prompt1;
        newEntry._entry = entry1;
        newEntry._date = date1;
        myJournal._entries.Add(newEntry);

    }

}