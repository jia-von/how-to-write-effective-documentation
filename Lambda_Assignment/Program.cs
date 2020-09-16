﻿using System;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // Example 3:
            // Step 2: Initialize Anonymous function()
            Example3 test = (x, y) => x + y;
            

            //Invoke the delegates
            Console.WriteLine(test(5, 5));

            //Output:
            //10
        }
        // Example 3: 
        // Step 1: Make a delegate.
        delegate int Example3(int x, int y);
    }
}
