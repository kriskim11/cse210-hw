using System;

class Program
{
      static void Main(string[] args)
    {
        Console.WriteLine ("what is your grade percentage?");
        string answer = Console.ReadLine();
        float percent = float.Parse(answer);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >=80)
        {
            letter = "B";
        }
        else if (percent >=70)
        {
            letter = "C";
        }
        else if(percent >=60)
        {
            letter ="D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine ($"Your Grade is {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("you passed!!!");
        }
        else
        {
            Console.WriteLine("better luck next time");
        }

    }

}