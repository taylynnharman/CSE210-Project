public class Entry {
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

        public void Display()
    {
        Console.WriteLine($"Date:{_date} Prompt:({_prompt}) Response:{_response}");
    }
}

//Hold template for entries