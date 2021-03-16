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
                double timeTravelMinutes = (miles / mph) * 60;
                double timeTravelHours = (miles / mph);
                double minutesLeft = timeTravelMinutes % 60;
                //this needs to return the hours and minutes
                //this math is wrong, there are definitely some rounding errors
                Console.WriteLine("Hours: " + Math.Round(timeTravelHours, 0));
                Console.WriteLine("Minutes: " + Math.Round(minutesLeft, 0));

            }








            Console.WriteLine("bye!");
        }
    }
}
