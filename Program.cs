﻿using System;
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

            double purchaseTotal = purchases.Sum();

            Console.WriteLine("\nHow Much Money Have We Made?");
            Console.WriteLine("----------------------------");
            Console.WriteLine(purchaseTotal.ToString("#.00"));

            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45,
                9442.85,
                2454.63,
                45.65,
                2340.29,
                34.03,
                4786.45,
                745.31,
                21.76
            };

            double highestPrice = prices.Max();

            Console.WriteLine("\nMost Expensive Product");
            Console.WriteLine("----------------------");
            Console.WriteLine(highestPrice);

            List<int> wheresSquaredo = new List<int>()
            {
                66,
                12,
                8,
                27,
                82,
                34,
                7,
                50,
                19,
                46,
                81,
                23,
                30,
                4,
                68,
                14
            };
            /*
                Store each number in the following List until a perfect square
                is detected.

                Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */

            List<int> notYetSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0).ToList();

            Console.WriteLine("\nNumbers in List Until a Perfect Square was Reached");
            Console.WriteLine("--------------------------------------------------");
            notYetSquare.ForEach(num => Console.Write($"{num} "));

            // Build a collection of customers who are millionaires

            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Name = "Bob Lesman", Balance = 80345.66, Bank = "FTB" },
                new Customer() { Name = "Joe Landy", Balance = 9284756.21, Bank = "WF" },
                new Customer() { Name = "Meg Ford", Balance = 487233.01, Bank = "BOA" },
                new Customer() { Name = "Peg Vale", Balance = 7001449.92, Bank = "BOA" },
                new Customer() { Name = "Mike Johnson", Balance = 790872.12, Bank = "WF" },
                new Customer() { Name = "Les Paul", Balance = 8374892.54, Bank = "WF" },
                new Customer() { Name = "Sid Crosby", Balance = 957436.39, Bank = "FTB" },
                new Customer() { Name = "Sarah Ng", Balance = 56562389.85, Bank = "FTB" },
                new Customer() { Name = "Tina Fey", Balance = 1000000.00, Bank = "CITI" },
                new Customer() { Name = "Sid Brown", Balance = 49582.68, Bank = "CITI" }
            };
            List<Customer> millionaires = customers.Where(cust => cust.Balance >= 1000000).ToList();

            Console.WriteLine("\nCustomers Who are Millionaires");
            Console.WriteLine("------------------------------");
            millionaires.ForEach(mill => Console.WriteLine(mill.Name));

            /*
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */

            List<Bank> millionairesByBank = (from client in millionaires group client by client.Bank into bankCustomers select new Bank { Name = bankCustomers.Key, clients = bankCustomers.Count() }).ToList();

            Console.WriteLine("\nHow Many Millionaires Per Bank?");
            Console.WriteLine("-------------------------------");
            millionairesByBank.ForEach(bank => Console.WriteLine($"{bank.Name} {bank.clients}"));
        }

    }
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class Bank
    {
        public string Name { get; set; }
        public int clients { get; set; }
    }

}