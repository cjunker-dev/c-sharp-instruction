using System;

namespace Project_5_1_DiceRoller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Dice Roller App");
            Console.WriteLine("Roll the dice? (y/n) :");
            String choice = Console.ReadLine();
            Random random = new Random();
            while (choice == "y") {
                int die1, die2;
                generateDice(random, out die1, out die2);
                int total = die1 + die2;
                Console.WriteLine("Die 1: " + die1);
                Console.WriteLine("Die 2: " + die2);
                Console.WriteLine("Total: " + total);
                if (total == 2) {
                    Console.WriteLine("Sssssnake eyes!");
                } else if (total == 12) {
                    Console.WriteLine("Boxcars!");
                }


                Console.WriteLine("Roll again? (y/n):");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye!");
        }
        private static void generateDice(Random random, out int die1, out int die2) {
            die1 = random.Next(1, 7);
            die2 = random.Next(1, 7);
        }
    }
}
