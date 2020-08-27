// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace Linq
// {
//     class Program
//     {

//         public void Filtering()
//         {

//             // 1. Restriction/Filtering Operations
//             // Find the words in the collection that start with the letter 'L'
//             List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

//             IEnumerable<string> LFruits = from fruit in fruits
//             where fruit[0] == 'L'
//             select fruit;

//             Console.WriteLine("Fruits Which Start with 'L'");
//             Console.WriteLine("---------------------------");
//             foreach (string l in LFruits)
//             {
//                 Console.WriteLine($"{l}");
//             }

//             // Which of the following numbers are multiples of 4 or 6
//             List<int> numbers = new List<int>()
//             {
//                 15,
//                 8,
//                 21,
//                 24,
//                 32,
//                 13,
//                 30,
//                 12,
//                 7,
//                 54,
//                 48,
//                 4,
//                 49,
//                 96
//             };

//             IEnumerable<int> fourSixMultiples = numbers.Where(num => num % 4 == 0 || num % 6 == 0);

//             Console.WriteLine("\nMultiples of 4 or 6");
//             Console.WriteLine("-------------------");
//             foreach (int num in fourSixMultiples)
//             {
//                 Console.WriteLine(num);
//             }
//         }
//     }
// }