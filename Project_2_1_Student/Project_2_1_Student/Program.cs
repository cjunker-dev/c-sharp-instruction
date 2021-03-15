using System;

namespace Project_2_1_Student {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Student Registration App!");
            Console.WriteLine("Enter first name: ");
            String fName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            String lName = Console.ReadLine();
            String fullName = fName + " " + lName;

            Console.WriteLine("Enter year of birth: ");
            String year = Console.ReadLine();
            String password = fName + "*" + year;
            Console.WriteLine("Welcome " + fullName + "!");
            Console.WriteLine("Your registration is complete.");
            Console.WriteLine("Your temporary password is: " + password);








            Console.WriteLine("Goodbye");
        }
    }
}
