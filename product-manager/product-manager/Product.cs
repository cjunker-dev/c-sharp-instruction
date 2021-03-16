using System;
using System.Collections.Generic;
using System.Text;

namespace product_manager {
    class Product {
        public String Code { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }

        public Product(string code, string description, double price) {
            this.Code = code;
            this.Description = description;
            this.Price = price;
        }
        public Product() {

        }

        public override string ToString() {
            return $"Product: {Code}, {Description}, {Price.ToString("c")}";
        }

        
    }
}
