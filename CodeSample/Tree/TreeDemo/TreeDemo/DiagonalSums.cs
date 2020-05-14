using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeDemo
{
    public class DiagonalSums
    {
        public int diagonalDifference(List<List<int>> arr)
        {
            int matrixLength = Math.Abs( arr.Count);
            
            List<int> leftDiagonal = new List<int>();
            List<int> rightDiagonal = new List<int>();

            int leftPointer = 0;
            int rightPointer = matrixLength -1;

            for (int j = 0; j <= matrixLength; j++)
            {
                if (leftPointer < matrixLength)
                {
                    leftDiagonal.Add(arr[j][leftPointer]);
                    leftPointer++;
                }

                if (rightPointer < matrixLength && rightPointer >= 0)
                {
                    rightDiagonal.Add(arr[j][rightPointer]);
                    rightPointer--;
                }
             
            }

            long leftDiagSum = leftDiagonal.Sum();
            long rightDiagSum = rightDiagonal.Sum();
            decimal diff = leftDiagSum - rightDiagSum;

            return Convert.ToInt32(Math.Abs(diff));
        }

    
    }
}
