using BorwellSoftwareChallenge.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BorwellSoftwareChallengeTests
{
    [TestClass]
    public class WallTests
    {
        [TestMethod]
        public void HeightCheck()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Wall(-10, 10));
        }

        [TestMethod]
        public void HeightCheckSuccessful()
        {
            try
            {
                Wall wall = new Wall(10, 10);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }

        [TestMethod]
        public void WidthCheck()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Wall(10, -10));
        }

        [TestMethod]
        public void WidthCheckSuccessful()
        {
            try
            {
                Wall wall = new Wall(10, 10);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }
    }
}
