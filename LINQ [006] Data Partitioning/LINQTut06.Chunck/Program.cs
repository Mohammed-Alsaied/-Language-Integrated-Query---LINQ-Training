using LINQTut06.Shared;
using System.Linq;

namespace LINQTut06.Chunck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emps = Repository.LoadEmployees();

            var chaunks = emps.Chunk(10).ToList();//.Net06
            for (int i = 0; i < chaunks.Count; i++)
            {
                chaunks[i].Print($"Chunck #{i + 1}");
            }
        }
    }
}
