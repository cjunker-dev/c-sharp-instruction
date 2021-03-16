using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager {
    class Book : Product {
        public String Author { get; set; }
        public Book() { }

        public Book(string code, string desc, double price, string author) :
            base(code, desc, price) {
            Author = author;

        }

        public override string ToString() {
            return base.ToString() + $" Book: {Author}";
        }
    }

    
}
