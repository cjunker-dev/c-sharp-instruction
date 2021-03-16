using System;
using System.Collections.Generic;

namespace lists_and_maps {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Lists and Maps!!");
            List<String> singers = new List<String>();
            singers.Add("Bob Marley");
            singers.Add("Dave Grohl");
            singers.Add("Freddie Mercury");
            singers.Add("Bob Dylan");
            singers.Sort();


            foreach (String item in singers) {
                Console.WriteLine(item);

            }






            Console.WriteLine("bye");
        }
    }
}
