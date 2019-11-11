using System;

namespace FiveSimpleProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumProblem = new FirstProblemSumNumbers();
            sumProblem.PrintTitle("First Problem");
            sumProblem.NumbersToSum = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum using For-Loop  : {sumProblem.SumUsingFor  () }");
            Console.WriteLine($"Sum using While-Loop: {sumProblem.SumUsingWhile() }");
            Console.WriteLine($"Sum using Recursive : {sumProblem.SumRecursive () }");
            sumProblem.PrintFooter();
        }

    }
}
