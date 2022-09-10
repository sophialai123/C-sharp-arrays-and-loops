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

            //Editing Arrays
            summerStrut[7] = "I Like It ";
            ratings[7] = 5;

            //find the position for the first 3-star rated song
            int X = Array.IndexOf(ratings, 3);
            Console.WriteLine($"Song number {X + 1} is rated three stars");

            //Find the first song that has more than 10 characters in its title.
            string title = Array.Find(summerStrut, song => song.Length > 10);

            Console
                .WriteLine($"more than 10 characters in the title is {title}.");

            //sort alphabetically
            Array.Sort (summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[7]);

            // This creates a new array with default values
            string[] summerStrutCopy = new string[8];

            /* Array.Copy()takes three parameters: the name of the 
            array to be copied, the new array,
             and the length of the array elements. */
            Array.Copy(summerStrut, summerStrutCopy, 8);
            Console.WriteLine(summerStrutCopy[0]);

            //reverse the array order
            Array.Reverse (summerStrut);

            //sets a range of elements in an array to the default value
            Array.Clear(ratings, 0, ratings.Length);
            Console.WriteLine(ratings[0]);
        }
    }
}
