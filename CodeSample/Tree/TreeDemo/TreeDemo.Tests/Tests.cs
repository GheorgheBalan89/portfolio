using System;
using System.Diagnostics;
using NUnit.Framework;
using TreeDemo;

public class Tests
{
    [Test]
    public void FirstTreeTest()
    {
        // Test tree:
        // 
        // 1
        // +-2
        //   +-3
        //   +-4
        // +-5
        //   +-6
        //   +-7
        //
        var root = new Node(
            1,
            new Node(
                2,
                new Node(3),
                new Node(4)),
            new Node(
                5,
                new Node(6),
                new Node(7)));

        // Expected output:
        //
        // 1
        // 2
        // 3
        // 4
        // 5
        // 6
        // 7
        //
        
        var n = root;
        while (n != null)
        {
            Console.WriteLine(n.Data);
            //System.Diagnostics.Debug.WriteLine(n.Data);
            n = n.Next();
        }

        // Test
        //
        n = root;
        Assert.AreEqual(1, n.Data);
        n = n.Next();
        Assert.AreEqual(2, n.Data);
        n = n.Next();
        Assert.AreEqual(3, n.Data);
        n = n.Next();
        Assert.AreEqual(4, n.Data);
        n = n.Next();
        Assert.AreEqual(5, n.Data);
        n = n.Next();
        Assert.AreEqual(6, n.Data);
        n = n.Next();
        Assert.AreEqual(7, n.Data);
        n = n.Next();
        Assert.IsNull(n);
    }

    [Test]
    public void SecondTreeTest()
    {

        // Test tree:
        // 
        // 1
        // +-2
        //   +-3
        //   +-4
        //      +-5
        //         +-6
        // +-7
        //   +-8
        //   +-9
        // +-10 
        //   + -11
        //     + -12
        //

        var root = new Node(
            1,
            new Node(
                2,
                new Node(3),
                new Node(4, new Node(5, new Node(6)))),
            new Node(
                7,
                new Node(8),
                new Node(9)), 
            new Node(10, new Node(11, new Node(12))));

        // Expected output:
        //
        // 1
        // 2
        // 3
        // 4
        // 5
        // 6
        // 7
        // 8
        // 9
        // 10 
        // 11
        // 12
        //

        var n = root;
        while (n != null)
        {
            Console.WriteLine(n.Data);
            n = n.Next();
        }

        // Test
        //
        n = root;
        Assert.AreEqual(1, n.Data);
        n = n.Next();
        Assert.AreEqual(2, n.Data);
        n = n.Next();
        Assert.AreEqual(3, n.Data);
        n = n.Next();
        Assert.AreEqual(4, n.Data);
        n = n.Next();
        Assert.AreEqual(5, n.Data);
        n = n.Next();
        Assert.AreEqual(6, n.Data);
        n = n.Next();
        Assert.AreEqual(7, n.Data);
        n = n.Next();
        Assert.AreEqual(8, n.Data);
        n = n.Next();
        Assert.AreEqual(9, n.Data);
        n = n.Next();
        Assert.AreEqual(10, n.Data);
        n = n.Next();
        Assert.AreEqual(11, n.Data);
        n = n.Next();
        Assert.AreEqual(12, n.Data);
        n = n.Next();
        Assert.IsNull(n);
    }

    [Test]
    public void ThirdTreeTest()
    {

        // Test tree:
        // 
        // 1
        // +-2
        //   +-3
        //   +-4
        //      +-5
        //         +-6
        // +-7
        //   +-8
        //   +-9
        // +-10 
        //   + -11
        //     + -12
        //         + -13
        //              +- 14
        //              + -15
        //              + -16
        //                  + -17
        // +-18
        //    +-19
        //    +-20

        var root = new Node(
            1,
            new Node(
                2,
                new Node(3),
                new Node(4, new Node(5, new Node(6)))),
            new Node(
                7,
                new Node(8),
                new Node(9)),
            new Node(10, 
                new Node(11, 
                    new Node(12, 
                        new Node(13, 
                            new Node(14), new Node(15), new Node(16, 
                                                                                    new Node(17)))))),
            new Node(18,
                new Node(19), new Node(20))
            );

        // Expected output:
        //
        // 1
        // 2
        // 3
        // 4
        // 5
        // 6
        // 7
        // 8
        // 9
        // 10 
        // 11
        // 12
        // 13
        // 14
        // 15
        // 16 
        // 17
        // 18
        // 19 
        // 20
        //

        var n = root;
        while (n != null)
        {
            Console.WriteLine(n.Data);
            n = n.Next();
        }

        // Test
        //
        n = root;
        Assert.AreEqual(1, n.Data);
        n = n.Next();
        Assert.AreEqual(2, n.Data);
        n = n.Next();
        Assert.AreEqual(3, n.Data);
        n = n.Next();
        Assert.AreEqual(4, n.Data);
        n = n.Next();
        Assert.AreEqual(5, n.Data);
        n = n.Next();
        Assert.AreEqual(6, n.Data);
        n = n.Next();
        Assert.AreEqual(7, n.Data);
        n = n.Next();
        Assert.AreEqual(8, n.Data);
        n = n.Next();
        Assert.AreEqual(9, n.Data);
        n = n.Next();
        Assert.AreEqual(10, n.Data);
        n = n.Next();
        Assert.AreEqual(11, n.Data);
        n = n.Next();
        Assert.AreEqual(12, n.Data);
        n = n.Next();
        Assert.AreEqual(13, n.Data);
        n = n.Next();
        Assert.AreEqual(14, n.Data);
        n = n.Next();
        Assert.AreEqual(15, n.Data);
        n = n.Next();
        Assert.AreEqual(16, n.Data);
        n = n.Next();
        Assert.AreEqual(17, n.Data);
        n = n.Next();
        Assert.AreEqual(18, n.Data);
        n = n.Next();
        Assert.AreEqual(19, n.Data);
        n = n.Next();
        Assert.AreEqual(20, n.Data);
        n = n.Next();
        Assert.IsNull(n);
    }

    [Test]
    public void FourthTreeTest()
    {

        // Test tree:
        // 
        // 9
        // +-4
        //   +-2
        //   +-6
        //      +-8
        //         +-0
        // +-2
        //   +-5
        //   +-6
        //      +-7
        //      +-8
        //      +-0

        var root = new Node(
            9,
            new Node(
                4,
                    new Node(2),new Node(6, 
                                                    new Node(8, new Node(0)))),
            new Node(
                2,
                new Node(5),new Node(6, 
                    new Node(7), new Node(8), new Node(0)))
           );

        // Expected output:
        //
        // 9
        // 4
        // 2
        // 6
        // 8
        // 0
        // 2
        // 5
        // 6
        // 7 
        // 8
        // 0
        //

        var n = root;
        while (n != null)
        {
            Console.WriteLine(n.Data);
            n = n.Next();
        }

        // Test
        //
        n = root;
        Assert.AreEqual(9, n.Data);
        n = n.Next();
        Assert.AreEqual(4, n.Data);
        n = n.Next();
        Assert.AreEqual(2, n.Data);
        n = n.Next();
        Assert.AreEqual(6, n.Data);
        n = n.Next();
        Assert.AreEqual(8, n.Data);
        n = n.Next();
        Assert.AreEqual(0, n.Data);
        n = n.Next();
        Assert.AreEqual(2, n.Data);
        n = n.Next();
        Assert.AreEqual(5, n.Data);
        n = n.Next();
        Assert.AreEqual(6, n.Data);
        n = n.Next();
        Assert.AreEqual(7, n.Data);
        n = n.Next();
        Assert.AreEqual(8, n.Data);
        n = n.Next();
        Assert.AreEqual(0, n.Data);
        n = n.Next();
        Assert.IsNull(n);
    }
}