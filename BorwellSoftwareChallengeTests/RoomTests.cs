using BorwellSoftwareChallenge.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorwellSoftwareChallengeTests
{
    [TestClass]
    public class RoomTests
    {
        [TestMethod]
        public void DoorCountCheck()
        {
            ObjectModel wallOne = new ObjectModel(10, 10);
            ObjectModel wallTwo = new ObjectModel(10, 10);
            ObjectModel wallThree = new ObjectModel(10, 10);

            ObjectModel windowOne = new ObjectModel(1, 1);

            HashSet<ObjectModel> doors = new HashSet<ObjectModel>();
            HashSet<ObjectModel> walls = new HashSet<ObjectModel>();
            HashSet<ObjectModel> windows = new HashSet<ObjectModel>();

            walls.Add(wallOne);
            walls.Add(wallTwo);
            walls.Add(wallThree);

            windows.Add(windowOne);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Room(doors, walls, windows));
        }

        [TestMethod]
        public void WallCountCheck()
        {
            ObjectModel wallOne = new ObjectModel(10, 10);

            ObjectModel windowOne = new ObjectModel(1, 1);

            HashSet<ObjectModel> doors = new HashSet<ObjectModel>();
            HashSet<ObjectModel> walls = new HashSet<ObjectModel>();
            HashSet<ObjectModel> windows = new HashSet<ObjectModel>();

            walls.Add(wallOne);

            windows.Add(windowOne);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Room(doors, walls, windows));
        }

        [TestMethod]
        public void DoorCountSuccessfulCheck()
        {
            ObjectModel doorOne = new ObjectModel(2, 1);

            ObjectModel wallOne = new ObjectModel(10, 10);
            ObjectModel wallTwo = new ObjectModel(10, 10);
            ObjectModel wallThree = new ObjectModel(10, 10);

            ObjectModel windowOne = new ObjectModel(1, 1);

            HashSet<ObjectModel> doors = new HashSet<ObjectModel>();
            HashSet<ObjectModel> walls = new HashSet<ObjectModel>();
            HashSet<ObjectModel> windows = new HashSet<ObjectModel>();

            doors.Add(doorOne);

            walls.Add(wallOne);
            walls.Add(wallTwo);
            walls.Add(wallThree);

            windows.Add(windowOne);

            try
            {
                Room room = new Room(doors, walls, windows);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }

        [TestMethod]
        public void WallCountSuccessfulCheck()
        {
            ObjectModel doorOne = new ObjectModel(2, 1);

            ObjectModel wallOne = new ObjectModel(10, 10);
            ObjectModel wallTwo = new ObjectModel(10, 10);
            ObjectModel wallThree = new ObjectModel(10, 10);

            ObjectModel windowOne = new ObjectModel(1, 1);

            HashSet<ObjectModel> doors = new HashSet<ObjectModel>();
            HashSet<ObjectModel> walls = new HashSet<ObjectModel>();
            HashSet<ObjectModel> windows = new HashSet<ObjectModel>();

            doors.Add(doorOne);

            walls.Add(wallOne);
            walls.Add(wallTwo);
            walls.Add(wallThree);

            windows.Add(windowOne);
            try
            {
                Room room = new Room(doors, walls, windows);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }

        [TestMethod]
        public void MoreDoorsThanWallsCheck()
        {
            ObjectModel doorOne = new ObjectModel(2, 1);
            ObjectModel doorTwo = new ObjectModel(2, 1);
            ObjectModel doorThree = new ObjectModel(2, 1);
            ObjectModel doorFour = new ObjectModel(2, 1);

            ObjectModel wallOne = new ObjectModel(10, 10);
            ObjectModel wallTwo = new ObjectModel(10, 10);
            ObjectModel wallThree = new ObjectModel(10, 10);

            ObjectModel windowOne = new ObjectModel(1, 1);

            HashSet<ObjectModel> doors = new HashSet<ObjectModel>();
            HashSet<ObjectModel> walls = new HashSet<ObjectModel>();
            HashSet<ObjectModel> windows = new HashSet<ObjectModel>();

            doors.Add(doorOne);
            doors.Add(doorTwo);
            doors.Add(doorThree);
            doors.Add(doorFour);

            walls.Add(wallOne);
            walls.Add(wallTwo);
            walls.Add(wallThree);

            windows.Add(windowOne);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Room(doors, walls, windows));
        }

        [TestMethod]
        public void MoreDoorsThanWallsSuccessfulCheck()
        {
            ObjectModel doorOne = new ObjectModel(2, 1);

            ObjectModel wallOne = new ObjectModel(10, 10);
            ObjectModel wallTwo = new ObjectModel(10, 10);
            ObjectModel wallThree = new ObjectModel(10, 10);

            ObjectModel windowOne = new ObjectModel(1, 1);

            HashSet<ObjectModel> doors = new HashSet<ObjectModel>();
            HashSet<ObjectModel> walls = new HashSet<ObjectModel>();
            HashSet<ObjectModel> windows = new HashSet<ObjectModel>();

            doors.Add(doorOne);

            walls.Add(wallOne);
            walls.Add(wallTwo);
            walls.Add(wallThree);

            windows.Add(windowOne);

            try
            {
                Room room = new Room(doors, walls, windows);
            }
            catch (Exception e)
            {
                Assert.Fail("No exception expected, exception thrown: " + e.Message);
            }
        }
    }
}
