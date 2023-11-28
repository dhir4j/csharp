using System;
public class MyFirstProgram()
{

    public static void Main()
    {

        Random random = new Random();
        bool game = true;

        while (game) {

            string userChoice = "";
            string computer = "";
            string alive;
            while (userChoice != "ROCK" && userChoice != "PAPER" && userChoice != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER OR SCISSORS: ");
                userChoice = Console.ReadLine().ToUpper();

                switch (random.Next(1, 4))
                {

                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Your Choice: "+userChoice);
                Console.WriteLine("Computer Choice: "+computer);
                switch (userChoice) {
                    case "ROCK":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("Its a Draw!");
                        }  
                        break;
                    case "PAPER":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("Its a Draw!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Win!");
                        }
                        else
                        {
                            Console.WriteLine("Its a Draw!");
                        }
                        break;
                }
            }
            Console.Write("Continue Playing? (Y/N): ");
            alive = Console.ReadLine().ToUpper();
            if (alive == "N")
            {
                game = false;
            }
            else {
                game = true;
            }
        }

    }

}