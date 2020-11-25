using System;

namespace Balloons
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please provide a string.");
            string baseText = Console.ReadLine();
            var searcher = new Searcher(baseText);

            while (true)
            {
                Console.WriteLine("Please provide search string");
                string searchString = Console.ReadLine();
                if(searchString == "exit")
                {
                    break;
                }
                else
                {
                    int result = searcher.Search(searchString);
                    Console.WriteLine($"The string fits {result} times.");
                }
            }
        }
    }
}
