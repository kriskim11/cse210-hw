using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"What is yout first name");
        string firstName = Console.ReadLine();
        Console.WriteLine($"What is your last name");
        String lastName = Console.ReadLine();
        Console.WriteLine($"your name is {lastName},{firstName} {lastName}.");
    }
}