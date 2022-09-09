using System;

namespace BuildingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            // initialize an array with new keyword;
            summerStrut =
                new string[] {
                    "Juice",
                    "Missing U",
                    "Raspberry Beret",
                    "New York Groove",
                    "Make Me Feel",
                    "Rbel Rebel",
                    "Despacito",
                    "Los Angeles"
                };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            Console
                .WriteLine($"You rated the song {summerStrut[1]}{
                    ratings[1]} stars.");
        }
    }
}
