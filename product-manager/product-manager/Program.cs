using System;

namespace product_manager {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Product Manager!");

            Console.Write("Enter product code: ");
            String code = Console.ReadLine();

            Console.Write("Enter product description: ");
            String desc = Console.ReadLine();

            Console.Write("Enter product price: ");
            String priceStr = Console.ReadLine();

            double price = Convert.ToDouble(priceStr);
            Product p1 = new Product(code, desc, price);
           // p1.Code = code;
            //p1.Description = desc;
            //p1.Price = price;

            //Console.WriteLine("Product entered: " + code + ", " + desc + ", " + price);

            //string interpolation
           // Console.WriteLine($"Product entered: { code }, { desc}, { price}");
            Console.WriteLine(p1.ToString());

            Book b1 = new Book("mysql", "Murach's MYSQL", 59.80, "Joel Murach");
            Console.WriteLine(b1);
            Software s1 = new Software("vs", "Visual Studio", 0.0, "16.3.7");
            Console.WriteLine(s1);

        }
    }
}
