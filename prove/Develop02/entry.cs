public class Entry {
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    public Entry (string response, string date, string prompt )
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }
    
    public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt:({_prompt}) Response:{_response}");
    }
}

//Hold template for entries