using System;

namespace Project_5_3_GuessingGame {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++");
            String choice = "y";
            while (choice == "y") {
                Console.WriteLine("I'm thinking of a number from 1 to 100. Try to guess it.");
                Random random = new Random();
                int number = random.Next(0, 100);
                Console.WriteLine("Enter number:" + number);
                int guess = Int32.Parse(Console.ReadLine());

                while (guess != number) {
                    if (number - guess > 10) {
                        Console.WriteLine("Way too low! Guess again.");
                    } else if (number - guess < -10) {
                        Console.WriteLine("Way too high! Guess again.");
                    } else if (number - guess < 0) {
                        Console.WriteLine("Too high! Guess again.");
                    } else if (number - guess > 0) {
                        Console.WriteLine("Too low! Guess again.");
                    }
                    guess = Int32.Parse(Console.ReadLine());


                }
                Console.WriteLine("you got it!!!");




            Console.WriteLine("Bye");
            }
        }
    }
}
