using System;

namespace bmdb_console {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the BMDB App!");
            Movie movie = new Movie();
            String choice = "y";
            while (choice == "y") {



                movie.Id = MyConsole.getInt("Enter Movie id: ");

                movie.Title = MyConsole.getRequiredString("Enter movie title: ");

                movie.Rating = MyConsole.getRequiredString("Enter movie rating: ");

                movie.Year = MyConsole.getInt("Enter Movie year");

                movie.Director = MyConsole.getRequiredString("Enter movie director: ");

                //print to console
                Console.WriteLine(movie.ToString());
                choice = MyConsole.getChoiceString("Continue? (y/n):", "y", "n");
            }
        }
    }
}
