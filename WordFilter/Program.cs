using System;
using System.Linq;
using System.Collections.Generic;
namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrWords = Console.ReadLine().Split().Where(arrWords => arrWords.Length % 2 == 0).ToArray();
            Console.WriteLine(string.Join(Environment.NewLine, arrWords));
        }
    }
}
