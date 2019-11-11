using System;
using System.Collections.Generic;
using System.Text;

namespace FiveSimpleProblems
{
    public class Fibonacci : BaseClass
    {

        public int HowManyIterations { get;}

        public Fibonacci(int howManyIterations) 
        {
            this.HowManyIterations = howManyIterations;
        }


        public double FibonacciIteration()
        {
            var startpoint = 0.0;
            var nextpoint = 1.0;
            var carry = 0.0;
            Console.Write($"{startpoint},{nextpoint},");
            for (int i = 3; i <= HowManyIterations; i++)
            {
                carry = startpoint;
                Console.Write($"{startpoint + nextpoint},");
                startpoint = nextpoint;
                nextpoint = carry + nextpoint; 
            }
            return nextpoint;
        }


    }
}
