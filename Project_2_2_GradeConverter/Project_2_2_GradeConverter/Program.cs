using System;

namespace Project_2_2_GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Letter Grade Converter");
            String choice = "y";
            while (choice == "y") { 
                Console.WriteLine("Enter numerical grade: ");
                int numGrade = Int32.Parse(Console.ReadLine());
                String letGrade;
                if (numGrade < 60) {
                    letGrade = "F";
                } else if (numGrade < 67) {
                    letGrade = "D";
                } else if (numGrade < 79) {
                    letGrade = "C";
                } else if (numGrade < 87) {
                    letGrade = "B";
                } else {
                    letGrade = "A";
                }



                Console.WriteLine("Letter grade: " + letGrade);

                Console.WriteLine("Continue?");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Goodbye");
        }
    }
}
