using System;
using FizzBuzz.GameEngine;

namespace ConsoleApp.FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Play the game");

            for (var iteration = 0; iteration <= 100; iteration++)
            {
                var result = FizzBuzzGameEngine.IterationOfIs(iteration);
                Console.WriteLine(result);
            }

            Console.ReadLine();
        }
    }
}
