using System;
using Domain;


namespace App
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            Console.WriteLine("Tell me a bit more about yourself");
            var description = Console.ReadLine();
        }
    }
}
