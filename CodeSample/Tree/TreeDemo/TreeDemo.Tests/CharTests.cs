using System;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using TreeDemo;

public class CharTests
{
    [Test]
    public void CharTest()
    {
        var expressions = new List<string>(){"<>>>", "<>>>>" };
        var replacements = new List<int>(){2, 2}; 
        var charTest = new CharTest().balancedOrNot(expressions, replacements);
        Assert.AreEqual(1, charTest[0]);
        Assert.AreEqual(0, charTest[0]);
    }

    [Test]
    public void CharTest2()
    {
        var expressions = new List<string>() { "<>", "<>><" };
        var replacements = new List<int>() { 2, 1 };
        var charTest = new CharTest().balancedOrNot(expressions, replacements);

       Assert.AreEqual(1, charTest[0]);
       Assert.AreEqual(0, charTest[1]);
        
        //charTest[2].Equals(0);
    }

    [Test]
    public void CharTest3()
    {
        var expressions = new List<string>() { "<><<>><><<<<>>>><>>><<<>><>>>><<><<<<>><>" };
        var replacements = new List<int>() { 5 };
        var charTest = new CharTest().balancedOrNot(expressions, replacements);

         Assert.AreEqual(0,  charTest[0]);
      
       
    }

    [Test]
    public void CharTestFour()
    {
        var expressions = new List<string>() { "<<<><><>" };
        var replacements = new List<int>() { 1 };
        var charTest = new CharTest().balancedOrNot(expressions, replacements);

        Assert.AreEqual(0, charTest[0]);
       

        //charTest[2].Equals(0);
    }
}