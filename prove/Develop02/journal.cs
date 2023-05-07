public class Journal {
    public string _entryname = "";
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine($"Entry Name: {_entryname}");
        Console.WriteLine($"Entry: ");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

}