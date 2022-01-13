using System;
using System.Collections.Generic;
using System.Text;

namespace _7kyu
{
    public class BinaryAdditionKata
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2); ;
           // return AddBinaryInt(a, b).ToString();
        }

        private static long AddBinaryInt(int a, int b)
        {
            return IntToBinary(a + b);
          
        }      

        public static int IntToBinary(int a)        
        {
            if (a == 1 | a == 0)
            {
                return a;
            }
            else if (a % 2 == 0)
            {
                return 10 * IntToBinary(a / 2);
            }
            else
            {
                return 1 + IntToBinary(a - 1);
            }
        }
    }
}
