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

            var firstList = new List<int> {1,2,3,4,5};

            var secondList = new List<int> {};

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
                    LinqPracticing.OrderByTwoFields(Products);
                }

                if(flag == 6)
                {
                    Console.WriteLine("Please Enter a price to find the items which are priced under? ");

                    var priceInputByUser = Convert.ToInt32(Console.ReadLine());

                    LinqPracticing.FindItemsWhichArePricedUnder(Products, priceInputByUser); 
                }

                if(flag == 7)
                {
                    Console.WriteLine("Enter a price and a letter");

                    var priceInputByUser = Convert.ToInt32(Console.ReadLine());

                    var letterInputByUser = Console.ReadLine();

                    LinqPracticing.FindingItemsPricedHigherAndStartsWithACharacter(Products, priceInputByUser, letterInputByUser);
                }

                if(flag == 8)
                {
                    Console.WriteLine("Enter the item you are trying to find");

                    var itemToFind = Console.ReadLine();

                    LinqPracticing.CustomQueryByItem(Products, itemToFind); 
                }

                if(flag == 9)
                {
                    Console.WriteLine("Enter the Item you're looking for: ");

                    var itemToFind = Console.ReadLine();

                    LinqPracticing.FindingAnItemUsingFirst(Products, itemToFind); 
                }

                if(flag == 10)
                {
                    Console.WriteLine("Enter the item you're looking for: ");

                    var itemToFind = Console.ReadLine();

                    LinqPracticing.FindingAnItemUsingFirstOrDefault(Products, itemToFind); 
                }

                if (flag == 11)
                {
                    Console.WriteLine("Please Enter A price");

                    var priceToFindUnder = Convert.ToInt32(Console.ReadLine());

                    LinqPracticing.FindingAnItemUsingLast(Products, priceToFindUnder); 
                }

                if (flag == 12)
                {
                    Console.WriteLine("Please Enter an ID to find: ");

                    var idToFindForUser = Convert.ToInt32(Console.ReadLine());

                    LinqPracticing.FindingByIdUsingSingleOrDefault(Products, idToFindForUser);
                }

                if (flag == 13)
                {
                    LinqPracticing.CalculatingNameLengthUsingName(Products);
                }

                if(flag == 14)
                {
                    Console.WriteLine("Please Enter the amount to skip");

                    var amountToSkipInput = Convert.ToInt32(Console.ReadLine());

                    LinqPracticing.SkippingItems(Products, amountToSkipInput);
                }

                if(flag == 15)
                {
                    Console.WriteLine("Please Enter the amount to take after ordering");

                    var amountToTake = Convert.ToInt32(Console.ReadLine());

                    LinqPracticing.TakingItems(Products, amountToTake); 
                }

                if (flag == 16)
                {
                    Console.WriteLine("Enter a Letter to skip the items that starts with");

                    var lettersToSkip = Console.ReadLine();

                    LinqPracticing.SkipWhileStartsWithALetter(Products, lettersToSkip);

                }

                if(flag == 17)
                {
                    LinqPracticing.ChoosingDistinctItems(Products); 
                }

                if(flag == 18)
                {
                    Console.WriteLine("Enter a letter to check whether all items contain it or not:");

                    var letterToLookFor = Console.ReadLine();

                    LinqPracticing.DoAllItemsContainALetter(Products, letterToLookFor); 
                }

                if (flag == 19)
                {
                    Console.WriteLine("Enter a letter to check if any of the items contains it");

                    var letterToLookFor = Console.ReadLine();

                    LinqPracticing.DoesAnyItemContainALetter(Products, letterToLookFor); 
                }

                if(flag == 20)
                {
                    Console.WriteLine("Please Enter An Id");

                    var idToLookFor = Convert.ToInt32(Console.ReadLine());

                    LinqPracticing.FindingTheIdUsingContains(Products, idToLookFor); 
                }

                if(flag == 21)
                {
                    var productComparer = new ProductPriceComparerClass();

                    var productToBeCompared = new Product { Id = 12, Name = "Compared Object", Price = 7.35 };

                    LinqPracticing.SamePriceChecker(Products, productToBeCompared, productComparer);
                }

                if (flag == 22)
                {
                    Console.WriteLine("First List: ");

                    Product.print(firstList);

                    Console.WriteLine("SecondList: ");

                    Product.print(secondList);

                    LinqPracticing.IntersectUnionConcatExcept(firstList, secondList);
                }

                if(flag > 25 || flag < 1)
                {
                    Console.WriteLine("Input too high or too low, please enter again");
                }
            }
        }
    }
}
