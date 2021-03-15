using System;

namespace Project_4_1_Table_Of_Powers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            String choice = "y";
            while (choice == "y") {
                Console.WriteLine("Enter an integer: ");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Number Squared Cubed");
                Console.WriteLine("====== ======= =====");
                for (int i = 1; i < num + 1; i++) {
                    Console.Write(i + "\t");
                    Console.Write(i * i + "\t");
                    Console.WriteLine(i * i * i + "\t");    
                }

                Console.WriteLine("\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye");
        }
    }
}
