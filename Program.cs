using System;
using System.Collections.Generic;
using System.Linq;

namespace linq_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>()
            { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            List<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L")).ToList();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Fruits that start with 'L':");
            Console.WriteLine("-----------------------------------");
            foreach (string fruit in LFruits)
            {
                Console.WriteLine(fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0).ToList();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Numbers divisible by 4 or 6:");
            Console.WriteLine("-----------------------------------");
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Names in descending order:");
            Console.WriteLine("-----------------------------------");
            foreach (string name in descend)
            {
                Console.WriteLine(name);
            }

            // Build a collection of these numbers sorted in ascending order
            List<int> otherNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            List<int> ascendingNums = otherNumbers.OrderBy(num => num).ToList();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Numbers ascending:");
            Console.WriteLine("-----------------------------------");
            foreach (int num in ascendingNums)
            {
                Console.WriteLine(num);
            }

            // Output how many numbers are in this list
            List<int> someMoreNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int numberCount = someMoreNumbers.Count();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Count of numbers:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(numberCount);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double totalPurchasesAmount = purchases.Sum();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total Purchases:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"${totalPurchasesAmount}");

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double highestPrice = prices.Max();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Highest Price:");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"${highestPrice}");

            /*
            Store each number in the following List until a perfect square
            is detected.

            Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            List<int> numsBeforeSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 !=0).ToList();
            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Highest Price:");
            Console.WriteLine("-----------------------------------");

            foreach (int num in numsBeforeSquare)
            {
            Console.WriteLine(num);
            }
                

        }
    }
}


