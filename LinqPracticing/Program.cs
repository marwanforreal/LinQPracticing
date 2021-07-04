using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqPracticing
{
    class Program
    {
        static void Main(string[] args)
        {

            var Products = new List<Product>
            {
                new Product { Id = 1, Name = "Mango", Price = 53.5 },
                new Product { Id = 2, Name = "Watermelon", Price = 622.3},
                new Product { Id = 3, Name = "Cars", Price = 7.35 },
                new Product { Id = 4, Name = "Houses", Price = 9.424},
                new Product { Id = 5, Name = "Bikes", Price = 10.00},
                new Product { Id = 6, Name = "Falafel", Price = 56.3 },
                new Product { Id = 7, Name = "Chocolate", Price = 659.3 },
                new Product { Id = 8, Name = "Coffee", Price = 983.3 },
                new Product { Id = 9, Name = "Football", Price = 15.8 },
                new Product { Id = 10, Name = "Laptop", Price = 885.2 },
                new Product { Id = 11, Name = "Apples", Price = 6.3 },
            };


            int flag;

            var firstList = new List<int> { 1, 2, 4, 5, 67, 7, 7, 3, 45, 2, 6, 4, 236, 262, 6, 242, 6, 2 };

            var secondList = new List<int> { 1, 2, 4, 6, 6, 3, 4, 5, 6, 3, 5, 99, 9325, 1, 593, 5125, 5195, 3915, 3, 11, 4, 4, 5, 1251 };

            while (true) {
                try
                { 
                    flag = Convert.ToInt32(Console.ReadLine());
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Please Enter an Integer!");
                    continue;
                }

                if (flag == 0)
                    break;
                
                if (flag == 1)
                {
                    LinqPracticing.SelectAll(Products);
                }

                if (flag == 2)
                {
                    LinqPracticing.SelectNameColumnOnly(Products);
                }

                if (flag == 3)
                {
                    LinqPracticing.OrderByAscending(Products);
                }

                if (flag == 4)
                {
                    LinqPracticing.OrderByDescending(Products);
                }

                if(flag == 5)
                {
                    Console.WriteLine("Order By Two Fields");

                    var OrderedList = Products.OrderBy(prod => prod.Price)
                        .ThenBy(p => p.Name)
                        .ToList();

                    Product.print(OrderedList);
                }

                if(flag == 6)
                {
                    Console.WriteLine("Searching for the prices less than 300");

                    var FilteredList = Products
                        .Where(p => p.Price < 300)
                        .ToList();

                    Product.print(FilteredList); 
                }

                if(flag == 7)
                {
                    Console.WriteLine("Searching for items with higher prices than 500 and name starts with C");
                   
                    var FilteredList = Products
                        .Where(p => p.Price > 500.0 &&
                        p.Name.StartsWith("C"))
                        .ToList();
                    
                    Product.print(FilteredList);
                }

                if(flag == 8)
                {
                    Console.WriteLine("Creating a custom query (By Item) which only finds a string of items");

                    Console.WriteLine("Enter An Item Name To Find");

                    var ItemToFind = Console.ReadLine();

                    var FilteredList = Products
                        .ByItem(ItemToFind)
                        .ToList();

                    Product.print(FilteredList); 
                }

                if(flag == 9)
                {
                    try
                    {
                        Console.WriteLine("First");

                        Console.WriteLine("Pick a Name");

                        var NameToFind = Console.ReadLine();

                        var ResultList = Products.First(prod => prod.Name == NameToFind);

                        Product.print(ResultList);
                    }
                    catch
                    {
                        Console.WriteLine("Item Not Found!"); 
                    }
                }

                if(flag == 10)
                {
                    Console.WriteLine("FirstOrDefault");

                    Console.WriteLine("Pick an Item");

                    var ItemToFind = Console.ReadLine();

                    var Result = Products.FirstOrDefault(prod => prod.Name == ItemToFind);
                    
                    if (Result == null)
                        Console.WriteLine("Item Not Found");
                    else
                        Product.print(Result);
                }

                if (flag == 11)
                {
                    try
                    {
                        Console.WriteLine("Last");

                        Console.WriteLine("Enter A price to find one item that has a price less");

                        var price = Convert.ToInt32(Console.ReadLine());

                        var Result = Products.Last(prod => prod.Price < price);

                        Product.print(Result);
                    }

                    catch
                    {
                        Console.WriteLine("Item Not Found!");
                    }
                }

                if (flag == 12)
                {
                    Console.WriteLine("Single Or Default");

                    Console.WriteLine("Choose an ID");

                    var id = Convert.ToInt32(Console.ReadLine());

                    var Result = Products.SingleOrDefault(prod => prod.Id == id);

                    if(Result == null)
                        Console.WriteLine("Record Not Found!");
                    else
                        Product.print(Result); 
                }

                if (flag == 13)
                {
                    Console.WriteLine("Calculated Property -- Name Length");

                    Products.ForEach(p => p.NameLength = p.Name.Length);

                    var result = Products
                        .Select(y => y.NameLength)
                        .ToList();

                    Product.print(result); 
                }

                if(flag == 14)
                {
                    Console.WriteLine("Skip First 5");

                    var result = Products
                        .OrderBy(p => p.Price)
                        .Skip(6)
                        .ToList();

                    Product.print(result);
                }

                if(flag == 15)
                {
                    Console.WriteLine("Take First 5 Name Lengths, Ordered by Name Lengths");

                    Products.ForEach(p => p.NameLength = p.Name.Length);

                    var orderedList = Products
                        .OrderBy(p => p.NameLength)
                        .Take(5)
                        .ToList();

                    var result = orderedList
                        .Select(p => p.NameLength)
                        .ToList();

                    Product.print(result);
                }

                if(flag == 16)
                {
                    Console.WriteLine("Skip While Starts with C");

                    var result = Products
                        .SkipWhile(p => p.Name.StartsWith("C"))
                        .ToList();

                    Product.print(result);

                }

                if(flag == 17)
                {
                    Console.WriteLine("Select Distinct Items");

                    var result = Products
                        .Select(p => p.Name)
                        .Distinct()
                        .ToList();

                    Product.print(result);
                }

                if(flag == 18)
                {
                    Console.WriteLine("Do All Products have 'a' in them? Using All()");

                    var result = Products.All(p => p.Name.Contains("a")); 

                    if(result)
                        Console.WriteLine("All Items Contain an 'a' ");
                    else
                        Console.WriteLine("Not all items contain an 'a'");
                }

                if(flag == 19)
                {
                    Console.WriteLine("Does any of the products contain an 'a' ? ");

                    var result = Products
                        .Any(p => p.Name.Contains('a'));

                    if (result)
                        Console.WriteLine("One of the products does indeed has an 'a' ");
                    else
                        Console.WriteLine("None of the items has an 'a' ");
                }

                if(flag == 20)
                {
                    Console.WriteLine("Contains");

                    Console.WriteLine("Please Enter an ID to search if it exists");

                    var idToLookFor = Convert.ToInt32(Console.ReadLine());

                    var idColumnsOnly = Products
                        .Select(p => p.Id)
                        .ToList();

                    var result = idColumnsOnly.Contains(idToLookFor);

                    if (result)
                        Console.WriteLine("Id {0} Exists", idToLookFor);
                    else
                        Console.WriteLine("Id {0} does not exist", idToLookFor);
                    
                }

                if(flag == 21)
                {
                    Console.WriteLine("Checking If the Price Is Equal using Equality comparer");

                    var productComparer = new ProductPriceComparerClass();

                    var productToBeCompared = new Product { Id = 12, Name = "Compared Object", Price = 7.35 };

                    var result = Products.Contains(productToBeCompared, productComparer);

                    Console.WriteLine(result);
                }

                if(flag == 22)
                {
                    var result = firstList.Except(secondList).ToList();

                    Product.print(result); 

                }

                if(flag == 23)
                {
                    var result = firstList.Intersect(secondList).ToList();

                    Product.print(result); 
                }

                if(flag == 24)
                {
                    var result = firstList.Union(secondList).ToList();

                    Product.print(result); 
                }

                if(flag == 25)
                { 
                    var result = firstList.Concat(secondList).ToList();

                    Product.print(result); 
                }

                if(flag > 25 || flag < 1)
                {
                    Console.WriteLine("Input too high or too low, please enter again");
                }
            }
        }
    }
}
