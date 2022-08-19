using System;
using System.Linq;
using System.Collections.Generic;
namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> countByNumber = new Dictionary<string, int>();
            string[] words = Console.ReadLine().Split().Select(word => word.ToLower()).ToArray();
            foreach (var word in words)
            {
                if (!countByNumber.ContainsKey(word))
                {
                    countByNumber.Add(word, 0);
                }
                countByNumber[word]++;
            }
            string[] oddCountWords = countByNumber.Where(w => w.Value % 2 != 0).Select(w => w.Key).ToArray();
            Console.WriteLine(string.Join(" ", oddCountWords));
        }
    }
}
