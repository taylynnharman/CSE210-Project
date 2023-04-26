using System;

class Program
{
    static void Main(string[] args)
    {
//Random Generator
Random randomGenerator = new Random();
int number = randomGenerator.Next(1, 100);
        
        int guess = 0;
        int user_guess = 10032450;

//Add a loop that keeps looping as long as the user_guess does not match the magic number.
        while (user_guess!= number) {
//Keep track of number of guesses
                guess ++;
//Ask the user for a user_guess.
                Console.Write("User 2, what is your guess: ");
                user_guess = Convert.ToInt32(Console.ReadLine());
// Higher message
                if (user_guess < number)
                {Console.WriteLine("Higher");}
//Lower message
                else if (user_guess > number) 
                {Console.WriteLine("Lower");}
//Correct message
                else 
                {Console.WriteLine($"Congrats! You guessed the magic number in {guess} tries!");
        }
} 

//After the game is over, ask the user if they want to play again. Then, loop back and play the whole game again and continue this loop as long as they keep saying "yes".
  //Console.Write("Do you want to play again?");
        //string play_again = Console.ReadLine();
        //if (play_again.ToLower() == "yes") 
    }
}

