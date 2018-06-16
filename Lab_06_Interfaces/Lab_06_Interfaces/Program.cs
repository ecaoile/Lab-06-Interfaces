using System;
using Lab_06_Interfaces.Classes;
using Lab_06_Interfaces.Classes.Bird;
using Lab_06_Interfaces.Classes.Fish;
using Lab_06_Interfaces.Classes.Mammal;
using Lab_06_Interfaces.Classes.Reptile;

namespace Lab_06_Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lab 06!");
            Console.WriteLine("Today we're going to make some animals. Let's start off with a salmon!");

            Salmon salmon1 = new Salmon();
            Console.WriteLine("Okay, we have salmon now. Now let's turn it into sushi!");
            Console.WriteLine(salmon1.Sushify());

            Console.WriteLine("\nThank you for playing! Press any button to exit.");
            Console.ReadKey();
        }
    }
}
