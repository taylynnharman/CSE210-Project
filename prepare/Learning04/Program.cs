using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment ("Tay Harman", "C#");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment ("Tay Harman", "C#", "7.3", "8-19");
        Console.WriteLine(assign2.GetHomeworkList());
    }
}