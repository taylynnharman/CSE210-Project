using System;

class Goal
{
    static void Main(string[] args)
    {

    int points = 0; 

    Console.WriteLine("Welcome to the Goal Tracker!");
    Console.WriteLine($"You have {points} points.");
    
    Console.WriteLine("1. Create a new goal");
    Console.WriteLine("2. List goals");
    Console.WriteLine("3. Save goals ");
    Console.WriteLine("4. Load goals");
    Console.WriteLine("5. Record event");
    Console.WriteLine("5.Quit");

    Console.WriteLine("Please Select a Choice:");
    int userChoice = Convert.ToInt32(Console.ReadLine());

 if (userChoice == 1) {

            string currentDateTime = DateTime.Now.ToShortDateString();

            Console.WriteLine("Choice 1: Create a new goal");
            Console.WriteLine("");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal:");
            Console.WriteLine("3. :");
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
        }

        else if (userChoice == 4){    
        Console.WriteLine("Choice 4");
        }

        else if (userChoice == 5){
            Console.WriteLine("Program has been ended.");
        }

        else {
        Console.WriteLine("Please enter a valid option");
        }
    }
}

    

    Console.WriteLine("Please Select a Choice:");
    Console.ReadLine("Welcome to the Goal Tracker!");
    Console.WriteLine("Welcome to the Goal Tracker!");
}