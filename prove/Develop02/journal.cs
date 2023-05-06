public class Journal {
    public string _entryname = "";
    public List<Write> _entries = new List<Write>();

    public void Display()
    {
        Console.WriteLine($"Entry Name: {_entryname}");
        Console.WriteLine($"Entry: ");

        foreach (Write entry in _entries)
        {
            entry.Display();
        }
    }

}