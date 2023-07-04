public class Journal {
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void Save(string fileName)
    {
    Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries) 
                {
                    writer.WriteLine(entry.Display());
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error saving the journal: " + e.Message);
        }
    }
    }

    public void Load(string fileName)
    {

    }
