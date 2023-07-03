public class Reference{
    private string _book;
    private int _chapter;
    private List<int> _verses;

    public Reference (string book, int chapter, int verse)
    {

    }

    public Reference (string book, int chapter, int startVerse, int endVerse)
    {

    }

    public void GetDisplayString ()
    {
        if (_verses.Length > 1) 
        {
            Console.WriteLine($"{_book} {_chapter}:{_verses[0]}:{_verses[_verses.Length - 1]}");
        }
        else 
        {
            Console.WriteLine($"{_book} {_chapter}:{_verses[0]}");
        }
    }

}
