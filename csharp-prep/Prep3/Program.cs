using System;

class Program
{
    static void Main(string[] args)
    {
//Ask the user to enter a magic number
        Console.Write("User 1, please enter the magic number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int guess = 10032450;

//Add a loop that keeps looping as long as the guess does not match the magic number.
        while (guess!= number) {

//Ask the user for a guess.
                Console.Write("User 2, what is your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
// Higher message
                if (guess < number)
                {Console.WriteLine("Higher");}
//Lower message
                else if (guess > number) 
                {Console.WriteLine("Lower");}
//Correct message
                else 
                {Console.WriteLine("Congrats! You guessed the magic number!");}
        }
    }
}

//Instead of having the user supply the magic number, generate a random number from 1 to 100.

//Stretch Challenge
//Keep track of how many guesses the user has made and inform them of it at the end of the game.

//After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".