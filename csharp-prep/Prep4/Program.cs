using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int user_num = 209349;
        int sum = 0;
        int max = 0;
        int count = -1;
//Stop when they enter 0
        while (user_num != 0) {

////Ask the user for a series of numbers
        Console.WriteLine("Please enter a series of numbers; 1 at a time. Enter 0 when finished: ");
        Console.WriteLine("Enter number: ");
            user_num = Convert.ToInt32(Console.ReadLine());

//append each one to a list
        numbers.Add(user_num);
//Compute the sum, or total, of the numbers in the list.

        sum = sum + user_num; 
//Find the maximum, or largest, number in the list.
        if (user_num > max) {
            max = user_num;
        }
//Compute the average of the numbers in the list.
        
        }
    float average = sum/numbers.Count; 

Console.WriteLine($"Sum:{sum}");
Console.WriteLine($"Max:{max}");
Console.WriteLine($"Average:{average}");
    }
}
