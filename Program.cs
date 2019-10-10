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
            Console.WriteLine("------------------------------------");
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
            Console.WriteLine("------------------------------------");
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

        }
    }
}


