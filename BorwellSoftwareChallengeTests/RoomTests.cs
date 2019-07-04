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
            Wall wall = new Wall(10, 10);
            Wall wall2 = new Wall(10, 10);
            Wall wall3 = new Wall(10, 10);
            Door door = new Door(2, 1);
            Window window = new Window(1, 1);

            HashSet<Door> doors = new HashSet<Door>();
            HashSet<Wall> walls = new HashSet<Wall>();
            HashSet<Window> windows = new HashSet<Window>();

            walls.Add(wall);
            walls.Add(wall2);
            walls.Add(wall3);
            windows.Add(window);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Room(doors, walls, windows));
        }

        [TestMethod]
        public void WallCountCheck()
        {
            Wall wall = new Wall(10, 10);
            Door door = new Door(2, 1);
            Window window = new Window(1, 1);

            HashSet<Door> doors = new HashSet<Door>();
            HashSet<Wall> walls = new HashSet<Wall>();
            HashSet<Window> windows = new HashSet<Window>();

            doors.Add(door);
            walls.Add(wall);
            windows.Add(window);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Room(doors, walls, windows));
        }

        [TestMethod]
        public void DoorCountSuccessfulCheck()
        {
            Wall wall = new Wall(10, 10);
            Wall wall2 = new Wall(10, 10);
            Wall wall3 = new Wall(10, 10);
            Door door = new Door(2, 1);
            Window window = new Window(1, 1);

            HashSet<Door> doors = new HashSet<Door>();
            HashSet<Wall> walls = new HashSet<Wall>();
            HashSet<Window> windows = new HashSet<Window>();

            doors.Add(door);
            walls.Add(wall);
            walls.Add(wall2);
            walls.Add(wall3);
            windows.Add(window);

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
            Wall wall = new Wall(10, 10);
            Wall wall2 = new Wall(10, 10);
            Wall wall3 = new Wall(10, 10);
            Door door = new Door(2, 1);
            Window window = new Window(1, 1);

            HashSet<Door> doors = new HashSet<Door>();
            HashSet<Wall> walls = new HashSet<Wall>();
            HashSet<Window> windows = new HashSet<Window>();

            doors.Add(door);
            walls.Add(wall);
            walls.Add(wall2);
            walls.Add(wall3);
            windows.Add(window);
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
            Wall wall = new Wall(10, 10);
            Wall wall2 = new Wall(10, 10);
            Wall wall3 = new Wall(10, 10);
            Door door = new Door(2, 1);
            Door door2 = new Door(2, 1);
            Door door3 = new Door(2, 1);
            Door door4 = new Door(2, 1);
            Window window = new Window(1, 1);

            HashSet<Door> doors = new HashSet<Door>();
            HashSet<Wall> walls = new HashSet<Wall>();
            HashSet<Window> windows = new HashSet<Window>();

            doors.Add(door);
            doors.Add(door2);
            doors.Add(door3);
            doors.Add(door4);
            walls.Add(wall);
            walls.Add(wall2);
            walls.Add(wall3);
            windows.Add(window);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Room(doors, walls, windows));
        }

        [TestMethod]
        public void MoreDoorsThanWallsSuccessfulCheck()
        {
            Wall wall = new Wall(10, 10);
            Wall wall2 = new Wall(10, 10);
            Wall wall3 = new Wall(10, 10);
            Door door = new Door(2, 1);
            Window window = new Window(1, 1);

            HashSet<Door> doors = new HashSet<Door>();
            HashSet<Wall> walls = new HashSet<Wall>();
            HashSet<Window> windows = new HashSet<Window>();

            doors.Add(door);
            walls.Add(wall);
            walls.Add(wall2);
            walls.Add(wall3);
            windows.Add(window);

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
