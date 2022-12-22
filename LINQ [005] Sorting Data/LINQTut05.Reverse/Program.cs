using LINQTut05.Shared;
using System.Linq;

namespace LINQTut05.Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits =
            {
                "apricot","orange","banana","mango"
                ,"apple","grape","straberry"
            };

            var reversedOrder = fruits.Reverse();// work
            reversedOrder.Print("Employee in reverse Order");

            fruits.Reverse();// not work
            fruits.Print("Employee in reverse Order");

        }
    }
}
