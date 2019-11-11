using System;
using System.Collections.Generic;
using System.Text;

namespace FiveSimpleProblems
{
    public class FirstProblemSumNumbers : BaseClass
    {

        public int[] NumbersToSum;
        private int sumTotal;

        public int SumUsingFor()
        {
            sumTotal = 0;
            for (int i = 0; i < NumbersToSum.Length; i++)
            {
                sumTotal += NumbersToSum[i];
            }
            return sumTotal;
        }

        public int SumUsingWhile()
        {
            sumTotal = 0;
            int counter = 0;
            while (counter < NumbersToSum.Length)
            {
                sumTotal += NumbersToSum[counter++];
            }
            return sumTotal;
        }

        public int SumRecursive()
        {
            return Recursive(0);
        }

        private int Recursive(int counter)
        {
            sumTotal = 0;
            var singleValue = 0;
            if (counter < NumbersToSum.Length)
            {
                singleValue = NumbersToSum[counter];
                Recursive(++counter);
            }
            return sumTotal += singleValue;
        }


    }
}
