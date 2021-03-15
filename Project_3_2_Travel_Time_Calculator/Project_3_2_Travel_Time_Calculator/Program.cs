using System;

namespace Project_3_2_Travel_Time_Calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Time Travel Calculator!");
            String choice = "y";
            while (choice == "y") {
                Console.WriteLine("Enter miles: ");
                double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter miles for hour: ");
                double mph = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                double timeTravel = miles / mph;
                //this needs to return the hours and minutes
                Console.WriteLine("Travel time: " + timeTravel);

            }








            Console.WriteLine("bye!");
        }
    }
}
