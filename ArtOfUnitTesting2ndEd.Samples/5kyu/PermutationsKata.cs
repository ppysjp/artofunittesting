using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5kyu
{
    public class PermutationsKata
    {
        public static IEnumerable<string> Permutate(string source)
        {
            if (source.Length == 1) return new List<string> { source };

            var permutations = from c in source
                               from p in Permutate(new String(source.Where(x => x != c).ToArray()))
                               select c + p;

            return permutations;
        }
    }
}
