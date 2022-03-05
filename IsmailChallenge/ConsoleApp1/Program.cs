using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string testCase = "the day is sunny the is day is the nday sunny sunny";
            var split = testCase.Split(' ');
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            foreach (var word in split)
            {
                if (word != "")
                {
                    string check = word;
                    if (dictionary.ContainsKey(check))
                    {
                        dictionary[check] = dictionary[check] + 1;
                    }
                    else
                    {
                        dictionary.Add(check, 1);
                    }
                }
            }

            foreach (var wordCount in dictionary)
            {
                Console.WriteLine($"{wordCount.Key}\t{wordCount.Value}");
            }
            Console.ReadKey();
        }
    }
}
