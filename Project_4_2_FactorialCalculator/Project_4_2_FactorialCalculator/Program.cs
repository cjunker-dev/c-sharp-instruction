using System;

namespace Project_4_2_FactorialCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial Calculator!!");
            String choice = "y";
            while (choice == "y") {
                Console.WriteLine("Enter an integer that's greater than 0 and less than 10: ");
                int num = Int32.Parse(Console.ReadLine());
                int factorial = 1;
                for (int i = 1; i < num+1; i++) {
                    factorial *= i;
                }
                Console.WriteLine("The factorial of " + num + " is " + factorial);
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();

            }






            Console.WriteLine("Bye");
        }
    }
}
