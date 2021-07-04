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

        public static void CustomQueryByItem(List<Product> products, string item)
        {
            Console.WriteLine("Custom Query By Item");

            var result = products
                .ByItem(item)
                .ToList();

            Product.print(result);
        }

        public static void FindingAnItemUsingFirst(List<Product> products, string item)
        {
            try
            {
                Console.WriteLine("Finding an Item using First()");

                var result = products.First(p => p.Name == item);

                Product.print(result);
            }

            catch
            {
                Console.WriteLine("Item Not Found!");
            }
        }

        public static void FindingAnItemUsingFirstOrDefault(List<Product> products, string item)
        {
            Console.WriteLine("Finding an Item Using First Or Default");

            var result = products.FirstOrDefault(p => p.Name == item);

            if (result != null)
                Product.print(result);
            else
                Console.WriteLine("Item Not Found!!");
        }

        public static void FindingAnItemUsingLast(List<Product> products, int price)
        {
            try
            {
                Console.WriteLine("Finding one item with a less price than {0} using Last()..............: ", price);

                var result = products.Last(p => p.Price < price);

                Product.print(result);
            }

            catch
            {
                Console.WriteLine("Item Not FOUND!");
            }
        }

        public static void FindingByIdUsingSingleOrDefault(List<Product> products, int idToFind)
        {
            Console.WriteLine("Finding the item with {0} as an Id using SingleOrDefault() ", idToFind);

            var result = products.SingleOrDefault(p => p.Id == idToFind);

            if(result != null)
                Product.print(result);
            else
                Console.WriteLine("Item Not Found!");
        }

        public static void CalculatingNameLengthUsingName(List<Product> products)
        {
            Console.WriteLine("Calculating Name Length Using Name and ForEach().............");

            products.ForEach(p => p.NameLength = p.Name.Length);

            var result = products
                .Select(p => p.NameLength)
                .ToList();

            Product.print(result);
        }

        public static void SkippingItems(List<Product> products, int amountToSkip)
        {
            Console.WriteLine("Ordering them then skipping the first {0}", amountToSkip);

            var result = products
                .OrderBy(p => p.Price)
                .Skip(amountToSkip)
                .ToList();

            Product.print(result);
        }

        public static void TakingItems(List<Product> products, int amountToTake)
        {
            Console.WriteLine("Ordering them by name length then taking only the first {0}" , amountToTake);

            products.ForEach(p => p.NameLength = p.Name.Length);

            var result = products
                .OrderBy(p => p.NameLength)
                .Take(amountToTake)
                .ToList();

            Product.print(result); 
        }

        public static void SkipWhileStartsWithALetter(List<Product> products, string letter)
        {
            Console.WriteLine("Choosing the first item that doesn't start with {0}", letter);

            var result = products
                .SkipWhile(p => p.Name.StartsWith(letter))
                .ToList();

            Product.print(result); 
        }

        public static void ChoosingDistinctItems(List<Product> products)
        {
            var result = products
                .Select(p => p.Name)
                .Distinct()
                .ToList();

            Product.print(result);
        }

        public static void DoAllItemsContainALetter(List<Product> products, string letter)
        {
            bool result = products.All(p => p.Name.Contains(letter)); 

            if(result)
                Console.WriteLine("All Items contain {0} ", letter);
            else
                Console.WriteLine("Not All Items contain {0} ", letter);
        }
    }

}