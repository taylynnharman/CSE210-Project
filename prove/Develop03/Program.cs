using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, welcome to the scripture memorizer!");
        Console.WriteLine("");
        
        Console.WriteLine("Please enter the scripture reference in the following format (John 3:16): ");
        Reference reference = new Reference(Console.ReadLine());
    
        Console.WriteLine("");
        Console.WriteLine("Please enter the scripture to memorize: ");
        string text = Console.ReadLine();
        Scripture scripture = new Scripture(reference, text);
        Console.Clear();
        scripture.Display();

        while(!scripture.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();
                       
            if (userInput.ToLower() == "quit")
                break;

            Console.Clear();
            scripture.HideRandomWords();
            scripture.Display();
        }
    }
}
        }
}