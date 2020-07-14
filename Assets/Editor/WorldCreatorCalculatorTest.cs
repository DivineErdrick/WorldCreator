using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;

public class WorldCreatorCalculatorTest
{
    [Test]
    public void T00PassingTest()
    {
        Assert.AreEqual(1, 1);
    }

    [Test]
    public void TWS10UT0()
    {
        int[] circumferences = { 10 , 8 };
        Assert.AreEqual(circumferences, WorldCreatorCalculator.CreateRadiusArray(10, 0));
    }

    [Test]
    public void TWS10UT1()
    {
        int[] circumferences = { 63, 63, 62, 60, 58, 54, 50, 45, 38, 27, 0 };
        Assert.AreEqual(circumferences, WorldCreatorCalculator.CreateRadiusArray(10, 1));
    }

    [Test]
    public void TWS10UT2()
    {
        int[] circumferences = { 31, 31, 29, 25, 19, 0 };
        Assert.AreEqual(circumferences, WorldCreatorCalculator.CreateRadiusArray(10, 2));
    }
}
