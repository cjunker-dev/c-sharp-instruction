using System;

namespace Pig_Dice {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Pig Dice Game. The die will be rolled until it gets a 1.");
            //call method that rolls die until a one
            Random random = new Random();
            String choice = "y";
           
            while (choice == "y") {
                int highScore = 0;
                int score = 0;
                Console.WriteLine("Enter number of times you'd like to play: ");
                int numberOfGames = Int32.Parse(Console.ReadLine());
                for (int i = 0; i < numberOfGames; i++) {
                    score = rollDice();
                    if (highScore < score) {
                        highScore = score;
                    }
                }
                Console.WriteLine("Highest score: " + highScore);
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
                
            }








        }
        public static int rollDice() {
            Random random = new Random();

            int total = 0;
            int numberOfRolls = 0;
            int roll = 0;
            while (roll != 1) {
                roll = random.Next(0, 7);
                total += roll;
                numberOfRolls++;
            }
            //store total score, number of rolls, and any other data
            Console.WriteLine($"Total score: {total}\nNumber of rolls: {numberOfRolls}");
            return total;



        }
    }
}
