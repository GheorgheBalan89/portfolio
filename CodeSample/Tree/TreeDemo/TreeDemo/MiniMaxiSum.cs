using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{

    /*
     *
     * *
     * From hacker rank: https://www.hackerrank.com/challenges/mini-max-sum/problem
     * *
     * Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

        For example, . Our minimum sum is  and our maximum sum is . We would print

        16 24
        Function Description

        Complete the miniMaxSum function in the editor below. It should print two space-separated integers on one line: the minimum sum and the maximum sum of  of  elements.

        miniMaxSum has the following parameter(s):

        arr: an array of  integers
        Input Format

        A single line of five space-separated integers.

        Constraints


        Output Format

        Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)
     */
    public class MiniMaxiSum
    {
        public int [] miniMaxSum(int[] arr)
        {
            var values = new int[]{};
            var maxValue = arr.Max();

            var maxSum = arr.Where(x => x!= maxValue).ToList().Sum();
            var minValue = arr.Min();

            var minSum = arr.Where(y => y != minValue).ToList().Sum();
            values[0] = minSum;
            values[1] = maxSum;
            return values;
        }
    }
}
