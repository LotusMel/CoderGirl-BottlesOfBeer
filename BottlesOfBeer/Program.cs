using System;

namespace BottlesOfBeer
{
    public static class Program
    {
        public static void Main()
        {
            
            int counter = 99;

            while (counter > 2)

            {
                Console.WriteLine($"{counter} bottles of beer on the wall.  {counter} bottles of beer. " +
                    "Take 1 down and pass it around, " +
                    $"{counter - 1} bottles of beer on the wall."); counter--;
            }

            if (counter == 2)
            {
                Console.WriteLine($"{counter} bottles of beer on the wall.  {counter} bottles of beer. " +
                    "Take 1 down and pass it around, " +
                    $"{counter - 1} bottle of beer on the wall."); counter--;
            }

           

            if (counter == 1)
            {

                Console.WriteLine($"{counter} bottle of beer on the wall.  {counter} bottle of beer. " +
                        "Take 1 down and pass it around, " +
                        "No more bottles of beer on the wall.");
            }

                 Console.ReadLine();
        }
    }
}
 /*   Couldn't get this code to run
            if (counter == 2)
            {
                string lastBeer = $"{counter - 1} last bottle of beer on the wall.";
                Console.WriteLine($"{counter} bottles of beer on the wall.  {counter} bottles of beer. " +
                    "Take 1 down and pass it around, ");
                Console.WriteLine(lastBeer);
            }
            */