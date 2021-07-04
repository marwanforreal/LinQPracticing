using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticing
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        //Calculated Properties

        public int NameLength { get; set; }

        public static void print(List<Product> prod)
        {
            foreach (Product product in prod)
            {
                Console.WriteLine("Id: " + product.Id + " " +"Name: " + product.Name + " " + "Price: " + product.Price);
            }
        }

        public static void print(List<string> listofstring)
        {
            foreach(string x in listofstring)
            {
                Console.WriteLine(x);
            }
        }

        public static void print(List<int> listofint)
        {
            foreach (int x in listofint)
            {
                Console.WriteLine(x);
            }
        }

        public static void print(Product prod)
        {
            Console.WriteLine("Id: " + prod.Id + " " + "Name: " + prod.Name + " " + "Price: " + prod.Price);
        }

    }
}
