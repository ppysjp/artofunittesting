using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _6kyu
{
    public class ArrayDiffKata
   {
        public static int[] ArrayDiff(int[] listA, int[] listB)
        {
            var result = listA.Where(a => listB.All(b => a != b));                         
            return result.ToArray();
        }

        // Recursion I just don't think will be possible here
        // On the other hand I think you could use LINQ. 
        // Which is definitely the thing that yhou want to do because it just means that 
        // you can use the built in abstraction for collections that comes with C# and then you can 
        // use the techniques from SICP to solve your collection issues which is great! 
        
    }
}
