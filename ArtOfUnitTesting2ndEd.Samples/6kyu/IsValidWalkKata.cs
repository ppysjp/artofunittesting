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
            var numberOfNorths = walk.Count(w => w == "n");
            var numberOfSouths = walk.Count(w => w == "s");
            var numberOfEasts = walk.Count(w => w == "e");
            var numberOfWests = walk.Count(w => w == "w");

            return numberOfNorths == numberOfSouths && numberOfEasts == numberOfWests && walk.Length == 10;
        }
    }
}
