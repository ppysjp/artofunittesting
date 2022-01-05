using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program.Main1(args);
            //Program.Main2(args);
            Program.Main3(args);
            Console.ReadKey();
        }

        private static void Main3(string[] args)
        {
            try
            {
                SimpleParserTests_Copy_WithTestUtil.TestReturnsZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main1(string[] args)
        {
            try
            {
                SimpleParserTests.TestReturnsZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        static void Main2(string[] args)
        {
            try
            {
                SimpleParserTests_Copy.TestReturnsZeroWhenEmptyString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
