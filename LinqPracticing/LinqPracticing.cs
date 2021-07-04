using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPracticing
{
    public static class LinqPracticing
    {
        public static void SelectAll(List<Product> Products)
        {
            Console.WriteLine("Select All");

            var LinqList = Products
                .Select(p => p)
                .ToList();

            Product.print(LinqList);
        }

        public static void SelectNameColumnOnly(List<Product> Products)
        {
            var result = Products.Select(p => p.Name).ToList();
            Product.print(result); 
        }
    }
}
