using System;

namespace SmallerThanCurrentNumber_1365
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new();
            var result = solution.SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
