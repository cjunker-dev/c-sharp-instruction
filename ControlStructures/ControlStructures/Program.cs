using System;

namespace ControlStructures {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Chapter 4 - Control Structures");
            int dow = 4;
            switch (dow) {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }

            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Loop #: " + i);
            }





            Console.WriteLine("Bye");
        }
    }
}
