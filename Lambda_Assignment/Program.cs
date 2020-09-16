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
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };
            

            // Example 2 (Microsoft, 2015a): 
            // Initialization of an anonymous method with the use of an lambda expression.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };
            

            // Example 3:
            // Step 2: Initialize Anonymous function()
            Example3 test = (x, y) => x + y;
            

            //Invoke the delegates
            testDelB("Print testDelB");
            testDelC("Print testDelC");
            Console.WriteLine(test(5, 5));
        }

        // Example 1: Declaration of method with a string parameter s
        delegate void TestDelegate(string s);

        // Example 3: 
        // Step 1: Make a delegate.
        delegate int Example3(int x, int y);
    }
}
