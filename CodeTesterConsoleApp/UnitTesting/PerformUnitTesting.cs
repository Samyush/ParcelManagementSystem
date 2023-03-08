using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTesterConsoleApp.UnitTesting
{
    [TestFixture]
    internal class PerformUnitTesting
    {
        [Test]
        public void TestAddition()
        {
            // Arrange
            int x = 2;
            int y = 3;
            int expected = 5;

            // Act
            int result = MyMath.Add(x, y);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }

    public static class MyMath
    {
        public static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
