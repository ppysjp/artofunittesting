using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter1
{
    class SimpleParser_Copy
    {
        public int ParseAndSum(string numbers)
        {
            if (numbers.Length == 0)
            {
                return 1;
            }
            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);



            }
            else
            {
                throw new InvalidOperationException(
                    "I can only handle 0 or 1 numbers for now!");
            }
        }

    }

    public class SimpleParserTests_Copy
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            try
            {
                SimpleParser_Copy p = new SimpleParser_Copy();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {

                    Console.WriteLine(
                        @"***SimpleParserTests.TestReturnsZeroWhenEmptyString:
                        -------
                        Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class TestUtil_Copy
    {
        public static void ShowProblem(string test, string message)
        {
            string msg = string.Format(@"
            ---{0}---
                    {1}
            --------------------
            ", test, message);
            Console.WriteLine(msg);
        }
    }

    public class SimpleParserTests_Copy_WithTestUtil
    {
        public static void TestReturnsZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser_Copy p = new SimpleParser_Copy();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtil_Copy.ShowProblem(testName, "Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception e)
            {
                TestUtil_Copy.ShowProblem(testName, e.ToString());
            }
        }
        
    }
}
