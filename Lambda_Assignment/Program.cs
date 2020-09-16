using System;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example 1 (Microsoft, 2015a): 
            // Initialization of an anonymous method with the use of delegate.
            // Invoke the delegate testDelB.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };
            testDelB("Print testDelB");

            // Example 2 (Microsoft, 2015a): 
            //Initialization of an anonymous method with the use of an lambda expression.
            //Invoke the delegate testDelC
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };
            testDelC("Print testDelC");

            //Example 3:
            //Step 2: Initialize Anonymous function()
            //Step 3: Invoke the delegate 
            Example3 test = (x, y) => x + y;
            Console.WriteLine(test(5, 5));


        }

        // Example 1: Declaration of method with a string parameter s
        delegate void TestDelegate(string s);

        //Example 3: 
        //Step 1: Make a delegate.
        delegate int Example3(int x, int y);
    }
}
