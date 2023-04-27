using System;

class Program
{
    static void Main(string[] args)
    {
//Ask the user for a series of numbers, and append each one to a list. Stop when they enter 0.
        List<int> numbers = new List<int>();
        int user_num = 209349;

        while (user_num != 0) {
        Console.WriteLine("Please enter a series of numbers; 1 at a time. Enter 0 when finished: ");
        Console.WriteLine("Enter number: ");
            user_num = Convert.ToInt32(Console.ReadLine());
        
        }
    }
}

//Core Requirements
//Compute the sum, or total, of the numbers in the list.

//Compute the average of the numbers in the list.

//Find the maximum, or largest, number in the list.
