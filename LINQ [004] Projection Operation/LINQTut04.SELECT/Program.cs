using System.Collections.Generic;
using System.Linq;

namespace LINQTut04.SELECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();


























        }

        private static void RunExample01()
        {
            //string[] words = new() { "I", "Love", "asp.net", "core" };

            List<string> words = new() { "I", "Love", "asp.net", "core" };
            //var result01 = words.Select(x => { return x; });
            var result = words.Select(x => x.ToUpper());

            foreach (var word in result)
            {
                System.Console.WriteLine(word);
            }
        }
    }
}
