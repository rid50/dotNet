using System;
using System.Linq;

class Program
{
    static void Main()
    {

        string[] words = new [] { "hell", "wonderful", "LINQ", "beautiful", "world" };

        //Get only short words
        var shortWords = from word in words where word.Length <= 5 select word;

        //Print each word out
        foreach (var word in shortWords)
        {
            Console.WriteLine(word);
        }

        // Specify the data source.
        int[] scores = { 97, 92, 81, 60 };

        // Define the query expression.
        IEnumerable<int> scoreQuery = from score in scores where score > 80 select score;

        // Execute the query.

        foreach (int i in scoreQuery)
        {
            Console.Write(i + " ");
        }

        //Console.ReadLine();
    }
}