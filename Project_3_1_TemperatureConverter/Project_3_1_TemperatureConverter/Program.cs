using System;

namespace Project_3_1_TemperatureConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            String choice = "y";
            while (choice == "y") {
                Console.WriteLine("Enter degrees in Fahrenheit");
                double degrees = Convert.ToDouble(Console.ReadLine());
                double celcius = (degrees - 32) * (5.0 / 9.0);
                Console.WriteLine("Degrees in Celcius: " + celcius.ToString("f"));
               //Console.WriteLine(percent.ToString("f"));

                Console.WriteLine("Continue? (y/n): ");
                choice = Console.ReadLine();
            }








            Console.WriteLine("Bye");
        }
    }
}
