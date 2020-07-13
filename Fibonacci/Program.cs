using System;
using System.Collections.Generic;

namespace Fibonacci {
    class Program {
        static void Main(string[] args) {
            //Declaring Variables
            List<int>  fibonacci;
            int first, second, amount;

            //Starting Variables
            fibonacci = new List<int> { };   
            first = 0;
            second = 0;
            amount = 0;

            Console.Write("Enter the first number: ");
            first = int.Parse(Console.ReadLine().ToString());
            fibonacci.Add(first);

            Console.Write("The second number: ");
            second = int.Parse(Console.ReadLine().ToString());
            fibonacci.Add(second);

            Console.Write("How many numbers you want add to the sequence: ");
            amount = int.Parse(Console.ReadLine().ToString());


            for(int num = 0;num != amount;num++) {
                fibonacci.Add(fibonacci[(fibonacci.Count - 1)] + fibonacci[(fibonacci.Count - 2)]);
            }

            Console.WriteLine($"The next numbers in the sequence are:");
            foreach(var number in fibonacci) {
                Console.WriteLine(number);
            }

            Console.ReadKey();
        }
    }
}
