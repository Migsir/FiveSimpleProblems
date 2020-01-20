using System;
using System.Collections.Generic;

namespace FiveSimpleProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            var sumProblem = new FirstProblemSumNumbers();
            sumProblem.PrintTitle("First Problem Sumatory");
            sumProblem.NumbersToSum = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Sum using For-Loop  : {sumProblem.SumUsingFor  () }");
            Console.WriteLine($"Sum using While-Loop: {sumProblem.SumUsingWhile() }");
            Console.WriteLine($"Sum using Recursive : {sumProblem.SumRecursive () }");
            sumProblem.PrintFooter();

            var fibonacci = new Fibonacci(20);
            fibonacci.PrintTitle("Third Fibonacci Secuence");
            fibonacci.FibonacciIteration();
            fibonacci.PrintFooter();

            var numbers = new CreateMaxNumber(new List<int>(){100,8,95,5,9});
            var maxNumber = numbers.GetMaxNumber();
            numbers.PrintTitle("Create Max Number from an Integer list");
            Console.WriteLine($"Max Number created:{maxNumber}");
            numbers.PrintFooter();
        }

    }
}
