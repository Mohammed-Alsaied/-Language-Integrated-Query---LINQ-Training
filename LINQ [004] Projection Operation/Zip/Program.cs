using LINQTut04.Shared;
using System.Linq;

namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExample01();
            RunExample02();

        }

        private static void RunExample01()
        {
            string[] colorName = { "Red", "Green", "Blue", "extra" };// extra in ignored
            string[] colorHEX = { "FF0000", "00FF00", "0000FF" };

            var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");

            foreach (var c in colors)
            {
                System.Console.WriteLine(c);
            }
        }

        private static void RunExample02()
        {
            var emp = Repository.LoadEmployees().ToArray();
            var firstThreeEmps = emp[..3];
            var lastThreeEmps = emp[^3..];

            var teams = firstThreeEmps.Zip(lastThreeEmps, (first, last)
                => $"{first.FullName} with {last.FullName}");

            var teams01 = from team in firstThreeEmps.Zip(lastThreeEmps)
                          select $"{team.First.FullName} with {team.Second.FullName}";

            foreach (var team in teams01)
            {
                System.Console.WriteLine(team);
            }
        }
    }
}
