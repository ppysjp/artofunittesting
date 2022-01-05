using System;

namespace _6kyu
{
    public class CountBitsKata
    {
        public static int CountBits(int n)
        {

            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else if (n % 2 == 1)
            {
                return 1 + CountBits(n/2);
            }
            else
            {
                return 0 + CountBits(n/2);
            }
        }
    }
}
