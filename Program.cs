using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Restriction/Filtering Operations
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = from fruit in fruits
            where fruit[0] == 'L'
            select fruit;

            Console.WriteLine("Fruits Which Start with 'L'");
            Console.WriteLine("---------------------------");
            foreach (string l in LFruits)
            {
                Console.WriteLine($"{l}");
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

            Console.WriteLine("\nMultiples of 4 or 6");
            Console.WriteLine("-------------------");
            foreach (int num in fourSixMultiples)
            {
                Console.WriteLine(num);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = names.OrderByDescending(name => name).ToList();

            Console.WriteLine("\nStudent Names in Descending Order");
            Console.WriteLine("---------------------------------");
            descend.ForEach(name => Console.Write($"{name} "));
            Console.WriteLine();

            // Build a collection of these numbers sorted in ascending order
            List<int> numbers2 = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            List<int> ascend = numbers2.OrderBy(num => num).ToList();

            Console.WriteLine("\nNumbers in Ascending Order");
            Console.WriteLine("--------------------------");
            ascend.ForEach(num => Console.Write($"{num} "));
            Console.WriteLine();

            // Output how many numbers are in this list
            List<int> numbers3 = new List<int>()
            {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            int totalNums = numbers3.Count;
            Console.WriteLine("\nTotal Number of Numbers");
            Console.WriteLine("-----------------------");
            Console.WriteLine(totalNums);

            // How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29,
                745.31,
                21.76,
                34.03,
                4786.45,
                879.45,
                9442.85,
                2454.63,
                45.65
            };

            double purchaseTotal = purchases.Sum(price => price);

            Console.WriteLine("\nHow Much Money Have We Made?");
            Console.WriteLine("----------------------------");
            Console.WriteLine(purchaseTotal.ToString("#.00"));
        }
    }
}