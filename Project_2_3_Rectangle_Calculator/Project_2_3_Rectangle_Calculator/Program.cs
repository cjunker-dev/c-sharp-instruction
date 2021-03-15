using System;

namespace Project_2_3_Rectangle_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");
            string choice = "y";
            while (choice == "y") {
                Console.Write("Enter length: ");
                String sLength = (Console.ReadLine());
                double length = Convert.ToDouble(sLength);
                Console.Write("Enter width: ");
                String sWidth = (Console.ReadLine());
                double width = Convert.ToDouble(sWidth);
                double area = length * width;
                double perimeter = (2 * width) + (2 * length);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }
            
            Console.WriteLine("Goodbye");
        }
    }
}
