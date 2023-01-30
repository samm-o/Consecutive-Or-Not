using System;
using System.Collections.Generic;
using System.Linq;

namespace Consecutive_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integers seperated by a hyphen: ");
            var input = Console.ReadLine();
            while (true)
            {
                if (input == "")
                {
                    Console.WriteLine("Empty List.");
                    break;
                }
                var numbers = Array.ConvertAll(input.Split('-'), int.Parse).ToList();
                numbers.Sort();

                if (numbers.Count == 1)
                {
                    Console.WriteLine("Only one number.");
                    break;
                }
                else if (numbers[0] + numbers.Count - 1 == numbers.Last())
                {
                    Console.WriteLine("Consecutive.");
                    break;
                }
                else
                {
                    Console.WriteLine("Not Consecutive");
                    break;
                }
            }
            
            

        }
    }
}
