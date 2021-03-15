using System;

namespace Project_4_4_CommonDivisorCalculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Greatest Common Divisor Finder");
            String choice = "y";
            while (choice == "y") { 
                Console.Write("Enter first number: ");
                int x = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int y = Int32.Parse(Console.ReadLine());
                while (x > 0) {


                    while (!(y < x)) {
                        y -= x;
                    }
                    while (!(x < y)) {
                        x -= y;
                    }

                }
                Console.WriteLine("Greatest common divisor: " + x);
                Console.WriteLine("Continue? (y/n):");
                choice = Console.ReadLine();

            }

            Console.WriteLine("Bye");
        }
    }
}
