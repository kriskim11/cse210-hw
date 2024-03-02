using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomNumberGenerator = new Random();
        int magicNumber = randomNumberGenerator.Next(1,100);
        int guess = -1;
        int attempts =0;

        while (guess != magicNumber)
        {
            Console.WriteLine("I have selected a number betweeen 1 and 100");
            guess = int.Parse(Console.ReadLine());
            attempts++;
    
            
            if (magicNumber>guess){
                Console.WriteLine("higher");

            }
            else if (magicNumber < guess){
                Console.WriteLine("lower");
            }
            else 
            {
                Console.WriteLine($"Congratulations!you guessed the number {magicNumber} in {attempts} attempts");
                break;
            }
        }
        


    }
}