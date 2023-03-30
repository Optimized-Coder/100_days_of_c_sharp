// Day 2

using System;

namespace Day2
{
        class Program
    {
        public static void Main(string[] args)
        {
            // Increment & decrement
            int steps = 0;
            steps += 2;
            Console.WriteLine(steps);
            steps -= 1;
            Console.WriteLine(steps);

            // number methods
            Console.WriteLine("===== Number Methods =====");
            int numberOne = 52;
            double numberTwo = -31;
            double numberThree = 46.9;
            Console.WriteLine($"Number {numberOne}");
            Console.WriteLine($"Square Root: {Math.Sqrt(numberOne)}");
            Console.WriteLine($"Absolute: {Math.Abs(numberTwo)}");
            Console.WriteLine($"Lowest Number: {Math.Min(numberOne, numberThree)}");
            Console.WriteLine($"Highest Number: {Math.Max(numberOne, numberThree)}");
            Console.WriteLine($"Rounded down: {Math.Floor(numberThree)}");
            Console.WriteLine($"Rounded up: {Math.Ceiling(numberThree)}");
        }
    } 
}