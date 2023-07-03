using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;
        while (userChoice != 5) {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following: ");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("Please enter which you would like to do using the # assigned: ");
            userChoice = Convert.ToInt32(Console.ReadLine());
            Journal journal = new Journal();

            
    //use while loop to get the function to call again or use true or false
            if (userChoice == 1) {

                string currentDateTime = DateTime.Now.ToShortDateString();

                Console.WriteLine("Choice 1: Write in my Journal");
                Console.WriteLine("");
                Console.WriteLine("Please enter your response to the prompt:");
                Prompt prompt = new Prompt();
                string userPrompt = prompt.GivePrompt();
                Console.WriteLine(userPrompt);

                Entry entry = new Entry (Console.ReadLine(), userPrompt, currentDateTime);
                journal.AddEntry(entry);
                Console.WriteLine("");
                Console.WriteLine("Entry saved to Journal");
                Console.WriteLine("");
                
            }

            else if (userChoice == 2) {
                Console.WriteLine("Choice 2: Display Journal");
                Console.WriteLine("");
                journal.Display();
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
}

/* Design: 
Classes: entry, prompt, journal. The entry will hold the template for the journal entry. The prompt will hold and generate a prompt for the user, and the journal will hold the responses.
*/

/* Description of how elements interact: 
When write is called entry program is used as template for the user to fill out. The prompt program is also called to give the user a prompt when filling out the entry. After the user fills out their entry they can choose to save it to their journal where it will be copied onto the file.
*/

/*
Functional Requirements

Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
Display the journal - Iterate through all entries in the journal and display them to the screen.
Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
Provide a menu that allows the user choose these options
Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:

\
Design Requirements:
Contain classes for the major components in the program.
Contain at least two classes in addition to the Program class.
Demonstrate the principle of abstraction by using member variables and methods appropriately.


Do not worry about the following:
Saving your file as a .csv file requires you to handle commas and quotes in the content appropriately. At this point, you can ignore that and just choose a symbol for a separator that you think is unlikely to show up in the content (such as | or ~ or ~|~).
You do not need to store the date as an actual C# DateTime object in your class or in the file. You can simply store it as a string.
*/