using BorwellSoftwareChallenge.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BorwellSoftwareChallengeTests
{
    [TestClass]
    public class ObjectTests
    {
        [TestMethod]
        public void HeightCheck()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ObjectModel(-10, 10));
        }

        [TestMethod]
        public void HeightCheckSuccessful()
        {
            try
            {
                ObjectModel model = new ObjectModel(10, 10);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }

        [TestMethod]
        public void WidthCheck()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new ObjectModel(10, -10));
        }

        [TestMethod]
        public void WidthCheckSuccessful()
        {
            try
            {
                ObjectModel model = new ObjectModel(10, 10);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }
    }
}
