using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TreeDemo;

namespace TreeDemo.Tests
{
   public class DiagonalSumsTests
    {
        [Test]
        public void TestOne()
        {
            var input = new List<List<int>>(){
                new List<int>(){11, 2,4}, new List<int>(){4,5,6}, 
                new List<int>(){10, 8, -12} };
         
            var test = new DiagonalSums().diagonalDifference(input);
            Assert.AreEqual(15, test);
        }

        [Test]
        public void TestTwo()
        {
            var input = new List<List<int>>(){
                new List<int>(){-1, 1, -7, -8}, 
                new List<int>(){-10, -8, -5, -2},
                new List<int>(){ 0, 9, 7, - 1 },
                new List<int>(){ 4, 4, -2, 1 }
            };

            var test = new DiagonalSums().diagonalDifference(input);
            Assert.AreEqual(1, test);
        }

    }
}
