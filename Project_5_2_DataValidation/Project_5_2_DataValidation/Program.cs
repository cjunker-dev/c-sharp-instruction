using System;

namespace Project_5_2_DataValidation {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcoem to the Area and Perimeter Calculator!");
            string choice = "y";
            while (choice == "y") {
                double length = getInput("Enter length: ");
                double width = getInput("Enter width: ");
                Console.WriteLine("Area: " + length * width);
                Console.WriteLine("Perimeter: " + (length * 2 + width * 2));
                Console.Write("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye");
        }

        private static double getInput(String s) {
            Console.Write(s);
            double input = 0;
            Boolean success = false;
            while (success == false) {
                try {
                    //input = Convert.ToDouble(input);
                    input = Convert.ToDouble(Console.ReadLine());
                    success = true;
                } catch (Exception) {
                    Console.WriteLine("Error. Input must be a number.");
                }
            }
            return input;
        }
        private static int GetInt(String prompt) {
            int nbr = 0;
            Boolean success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    nbr = Int32.Parse(Console.ReadLine());
                    success = true;
                } catch (Exception e) {
                    Console.WriteLine("Error. Must be a whole number. Try again.");
                }
            }
            return nbr;
        }
    }
}
