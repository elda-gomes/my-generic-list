using My.Generic.List;
using System;

namespace ConsoleForTestingList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing my generic list \\o/");
            Console.WriteLine();

            var listOfNumbers = new List<int>();

            Console.WriteLine("Adding a number...");
            listOfNumbers.Add(0);
            ShowListItems(listOfNumbers);

            Console.WriteLine("Adding a range of numbers...");
            listOfNumbers.AddRange(1, 2, 3, 4, 5, 6, 7, 8, 9);
            ShowListItems(listOfNumbers);

            Console.WriteLine("Removing number 5...");
            listOfNumbers.Remove(5);
            ShowListItems(listOfNumbers);

            Console.WriteLine("Adding number 5...");
            listOfNumbers.Add(5);
            ShowListItems(listOfNumbers);

            Console.ReadLine();
        }

        private static void ShowListItems(List<int> items)
        {
            Console.WriteLine();
            Console.WriteLine("List items:");
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine($"- {i}: {items[i]}");
            }
            Console.WriteLine();
        }
    }
}
