using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWordRemoval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Sentence but without punctuation marks!");
            string line =Console.ReadLine();
            string[] words = line.Split(' ');
            
            var filtered =
                from element in words
                let lowercaseString =element.ToLower()
                orderby lowercaseString
                select lowercaseString;

            Console.WriteLine("Your Sentence without duplicate words and ordered alphabetically");
            foreach (var element in filtered.Distinct())
            {
                Console.Write(" " + element);
            }
            
            Console.ReadKey();
        }
    }
}
