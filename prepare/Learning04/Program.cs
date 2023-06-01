using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment ("Tay Harman", "C#");
        Console.WriteLine(assign1.GetSummary());
    }
}