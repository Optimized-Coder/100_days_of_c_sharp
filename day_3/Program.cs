using System;

namespace Day3
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] drinks = {
                "Vodka lemonade",
                 "Rum and Coke",
                 "Tequila Sunrise",
                 "Sex on the beach"
            };



            Console.WriteLine("Welcome to the C# Club!");
            Console.Write("Please confirm your age to enter: ");
            string userAgeString = Console.ReadLine();

            int userAge;

            // check if value can be parsed
            if (int.TryParse(userAgeString, out userAge))
            {
                Console.WriteLine($"Your age is: {userAge}. You may enter");
            }
            else 
            {
                Console.WriteLine("Please enter a valid age.");
                return;
            }
            Console.WriteLine("Would you like a drink?");
            Console.WriteLine("Here is our drinks menu:");
            foreach(string d in drinks)
            {
                Console.WriteLine(d);
            }
            string drink = Console.ReadLine();
            if(!drinks.Contains(drink))
            {
                Console.WriteLine("Sorry, that drink is not available.");
                return;
            }
            else
            {
                Console.WriteLine($"You chose: {drink}");
                Console.WriteLine($"I will make your {drink} for you now");
            }
            Console.WriteLine("Okay, it's closing time! Time to go home");
        }
    }
}