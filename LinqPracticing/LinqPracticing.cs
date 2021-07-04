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

    }
}
