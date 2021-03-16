using System;

namespace Project_4_4_CommonDivisorCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Greatest Common Divisor Finder");
            String choice = "y";
            while (choice == "y") { 
                Console.Write("Enter first number: ");
                int gcd = 1;
                int num1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = Int32.Parse(Console.ReadLine());
                for (int i = 1; i <= num1 && i <= num2; i++) {
                    if (num1 % i == 0 && num2 % i == 0) {
                        gcd = i;
                    }
                }




                Console.WriteLine(gcd);
                Console.WriteLine("Continue? (y/n):");
                choice = Console.ReadLine();

            }

            Console.WriteLine("Bye");
        }
    }
}
