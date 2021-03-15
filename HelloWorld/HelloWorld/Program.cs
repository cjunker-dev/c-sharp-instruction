using System;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            int n1 = 6;
            int n2 = 7;
            Console.WriteLine(n1 + n2);

            
            Console.Write("Enter a whole number");
            int n3 = Int32.Parse(Console.ReadLine());

            Console.Write("enter first name: ");
            string fName = Console.ReadLine();

            Console.Write("enter last name: ");
            String lName = Console.ReadLine();

            String fullName = fName + " " + lName;
            Console.WriteLine("Your name is " + fullName);

            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter color name: (r/g/b)");
                String color = Console.ReadLine();
                if (color == "r") {
                    Console.WriteLine("Red was picked. you have good taste.");
                }
                else if (color == "g") {
                    Console.WriteLine("green was picked. the color of plants and nature.");
                }
                else if (color == "b") {
                    Console.WriteLine("blue was picked. the color of the ocean and the sky.");
                }
                Console.WriteLine("Continue? (y/n):");
                choice = Console.ReadLine();
            }



        }
    }
}
