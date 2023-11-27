using System;
using System.Runtime.ConstrainedExecution;
public class MyFirstProgram() {

    public static void Main() {

        Random random = new Random();

        Console.WriteLine("Select Difficulty level\n1. Easy\n2. Medium\n3. Hard \n");
        int difficulty = Convert.ToInt32(Console.ReadLine());
        int final = 0, guess, attempts = 5;
        if (difficulty == 1)
        {
            final = random.Next(1, 11);
            attempts = 3;
            Console.WriteLine("Guess between 1 and 10");
        }
        else if (difficulty == 2)
        {
            final = random.Next(1, 51);
            attempts = 6;
            Console.WriteLine("Guess between 1 and 50");
        }
        else if (difficulty == 3)
        {
            final = random.Next(1, 101);
            attempts = 10;
            Console.WriteLine("Guess between 1 and 100");
        }
        else {
            Console.WriteLine("Wrong difficulty level entered Quiting.");
        }

        for (int i = 1; i <= attempts; i++) {
            Console.WriteLine("Guess the number: ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > final)
            {
                Console.WriteLine("Wrong! the number is below your guess.\nAttemps left: " + i + " / " + attempts);
            }
            else if (guess < final)
            {
                Console.WriteLine("Wrong! the number is above your guess.\nAttemps left: " + i + " / " + attempts);
            }
            else if (guess == final)
            {
                Console.WriteLine("Congratulations You guessed it correctly!\nIn " + i + " / " + attempts + " Attemps");
                i =attempts;
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }

        }
        

    }

}