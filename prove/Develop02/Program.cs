using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following: ");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.WriteLine("Please enter which you would like to do using the # assigned: ");
        int userChoice = Convert.ToInt32(Console.ReadLine());
        Journal journal = new Journal();

        
//use while loop to get the function to call again or use true or false
        if (userChoice == 1) {

            string currentDateTime = DateTime.Now.ToShortDateString();

            Console.WriteLine("Choice 1: Write in my Journal");
            Console.WriteLine("");
            Prompt prompt = new Prompt();
            string userPrompt = prompt.GivePrompt();
            Console.WriteLine(userPrompt);
            
            Entry entry = new Entry ();
            entry._response = Console.ReadLine();
            entry._prompt = userPrompt;
            entry._date = currentDateTime;

            journal._entries.Add(entry);
            Console.WriteLine("");
            Console.WriteLine("Entry saved to Journal");
            Console.WriteLine("");
            
        }

        else if (userChoice == 2) {
            Console.WriteLine("Choice 2: Display Journal");
            Console.WriteLine("");
            Console.WriteLine(journal._entries.ToString());
            
        }

        else if (userChoice == 3) {
            Console.WriteLine("Choice 3");
             Console.WriteLine("");
            Console.WriteLine("Please enter the filename you would like to load");

        }

        else if (userChoice == 4){    
        Console.WriteLine("Choice 4");
        Console.WriteLine("");
        Console.WriteLine("Please enter the filename you would like to save to");
        }

        else if (userChoice == 5){
            Console.WriteLine("Program has been ended.");
        }

        else {
        Console.WriteLine("Please enter a valid option");
        }
    }
}

