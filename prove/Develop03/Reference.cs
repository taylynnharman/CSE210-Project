public class Reference{
    public string _reference = "";
    public bool _verses = true;

    public Reference (string reference)
    {
        _reference = reference;
        if (reference.Contains("-") || reference.Contains(","))
        {
            _verses = true;
        }
        else 
        {
            _verses = false;
        }
    }

    public void Display ()
    {
        Console.WriteLine($"{_reference}");
    }

}

