using System;
using System.Collections.Generic;
using System.Text;

namespace bmdb_console {
    class Movie {
        public int Id { get; set; }
        public String Title { get; set; }
        public String Rating { get; set; }
        public int Year { get; set; }
        public String Director { get; set; }

        public Movie() {

        }
        
        public Movie(int id, string title, string rating, int year, string director) {
            Id = id;
            Title = title;
            Rating = rating;
            Year = year;
            Director = director;
        }

        public override String ToString() {
            return $"Id = {Id}, Title = {Title}, Rating = {Rating}, Year = {Year}, Director = {Director}";
        }



    }
}
