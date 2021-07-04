using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticing
{
    public static class LinqPracticing
    {
        public static void SelectAll(List<Product> products)
        {
            Console.WriteLine("Select All");

            var LinqList = products
                .Select(p => p)
                .ToList();

            Product.print(LinqList);
        }

        public static void SelectNameColumnOnly(List<Product> products)
        {
            Console.WriteLine("Select Name Column Only");

            var result = products.Select(p => p.Name).ToList();

            Product.print(result); 
        }

        public static void OrderByAscending(List<Product> products)
        {
            Console.WriteLine("Order By Ascending");

            var result = products.OrderBy(p => p.Price).ToList();

            Product.print(result);
        }

        public static void OrderByDescending(List<Product> products)
        {
            Console.WriteLine("Order By Based On Price Descending");

            var result = products.OrderByDescending(p => p.Price).ToList();

            Product.print(result);
        }

        public static void OrderByTwoFields(List<Product> products)
        {
            Console.WriteLine("Order By Two Fields");

            var result = products.OrderBy(p => p.Price).ThenBy(p => p.Name).ToList();

            Product.print(result); 
        }

        public static void FindItemsWhichArePricedUnder(List<Product> products, int price)
        {
            Console.WriteLine("Finding Items Priced Under {0}.....", price);

            var result = products
                .Where(p => p.Price < price)
                .ToList();

            Product.print(result); 
        }

        public static void FindingItemsPricedHigherAndStartsWithACharacter(List<Product> products, int price, string letter)
        {
            Console.WriteLine("Finding Items priced higher than {0} and start with {1}.......", price, letter);

            var result = products.Where(p => p.Price > price && p.Name.StartsWith(letter)).ToList();

            Product.print(result); 
        }
    }
}
