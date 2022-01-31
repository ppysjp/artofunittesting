using System;
using System.Collections.Generic;
using System.Linq;

namespace _5kyu
{
    public class ScrambleKata
    {

        public static bool Scramble(string s1, string s2)
        {
            s1 = SortAlphabetically(s1);
            s2 = SortAlphabetically(s2);

            int count = 0;
            int j = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] == s2[j])
                {
                    count += 1;
                    j += 1;
                }
                if (j == s2.Length)
                {
                    break;
                }
            }
            return count == s2.Length;
        }

        private static string SortAlphabetically(string s1)
        {
            s1 = String.Concat(s1.OrderBy(c => c));
            return s1;
        }

        public static bool Scramble_Linq(string s1, string s2)
        {
            // Get Rob to explain.

            Func<string, Dictionary<char, int>> toMap = s =>
              s.GroupBy(c => c)
              .Select(g => new { g.Key, Count = g.Count() })
              .ToDictionary(pair => pair.Key, pair => pair.Count);

            var map1 = toMap(s1);
            var map2 = toMap(s2);

            foreach (KeyValuePair<char, int> p2 in map2)
            {
                if (!map1.ContainsKey(p2.Key)) return false;

                if (map1[p2.Key] < p2.Value) return false;
            }

            return true;
        }
    }
}
