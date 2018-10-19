using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOnListOnList_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to your list!\nLets start by adding something to your list!");
            List<string> userList = new List<string>();
            bool breakAdding = true;
            do
            {
                AddToList(userList);
                
                Console.WriteLine("Would you like to add another item? (y/n)");
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "y")
                {
                    Console.WriteLine("Add another item");
                    continue;
                }
                else if (answer == "no" || answer == "n")
                {
                    breakAdding = false;
                    break;
                }
                
            }
            while (breakAdding);

            while (true)
            {
                Console.WriteLine("What would you like to do with your list?\nSort in alphabetical order (sort)\nSearch(search)\nPrint to console(print)");
                string userAnswer = Console.ReadLine().ToLower();

                switch (userAnswer)
                {
                    case "sort":
                        SortList(userList);
                        break;

                    case "search":
                        SearchList(userList);
                        break;

                    case "print":
                        userList.ForEach(s => Console.WriteLine($"\t{s}"));
                        break;

                    default:
                        Console.WriteLine("That is not a valid answer. Try again");
                        continue;
                }
            }


        }

        static void AddToList(List<string> list)
        {
            bool breakWhile = true;
            while (breakWhile)
            {
                string input = Console.ReadLine();
                if (input is string)
                {
                    list.Add(input);
                    breakWhile = false;
                }
                else
                {
                    Console.WriteLine("Enter a string please");
                    continue;
                }
            }

        }

        static void SortList(List<string> list)
        {
            list.Sort();
            list.ForEach(s => Console.WriteLine($"\t{s}"));
            
        }

        static void SearchList(List<string> list)
        {
            Console.WriteLine("Type in something to search:");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine($"The following matches your search:\n \t{list.Find(s => s.Contains(input))}"); 
        }
    }
}
