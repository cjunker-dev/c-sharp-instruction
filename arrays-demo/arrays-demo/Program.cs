using System;

namespace arrays_demo {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Arrays Demo!");
            int[] numbers = new int[4];
            numbers[0] = 5;
            numbers[1] = 50;
            numbers[2] = 15;
            numbers[3] = 500;


            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine($"i = {i}, {numbers[i]}");
            }

            String[] names = { "Bryan", "Celina", "Tom", "Daemon", "Will", "Lance" };
            foreach (string s in names) {
                Console.WriteLine("name = " + s);
            }






            Console.WriteLine("bye");
        }
    }
}
