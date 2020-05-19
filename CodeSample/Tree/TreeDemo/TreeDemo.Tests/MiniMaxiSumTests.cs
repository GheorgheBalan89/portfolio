using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TreeDemo.Tests
{
    public class MiniMaxiSumTests
    {
        [Test]
        public void TestOne()
        {
            var input = new int[] {1, 2, 3, 4, 5};
            var sum = new MiniMaxiSum().miniMaxSum(input);
        }
    }
}
