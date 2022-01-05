using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _6kyu
{
    public class IsValidWalkKata
    {
        public static bool IsValidWalk(string[] walk)
        {
            // this is a collection so we should be using Linq! 
            var DirectionWeights = new Dictionary<string, int>()
                {
                    { "n", 2 },
                    { "s", -2 },
                    { "e", 1 },
                    { "w", -1 },
                };

            int[] ints = Array.ConvertAll(walk, w => DirectionWeights[w]);

            return ints.Sum() == 0;
        }
    }
}
