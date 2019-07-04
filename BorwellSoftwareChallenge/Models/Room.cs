using BorwellSoftwareChallenge.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BorwellSoftwareChallenge.Models
{
    /// <summary>
    /// The <see cref="Room"/> that you are calculating the paint for.
    /// </summary>
    public class Room
    {
        public Room(HashSet<ObjectModel> doors, HashSet<ObjectModel> walls, HashSet<ObjectModel> windows)
        {
            if (!doors.Count.BiggerThanOrEqualTo(1))
            {
                throw new ArgumentOutOfRangeException("You must have one or more door in a room");
            }
            else
            {
                Doors = doors;
            }
            if (!walls.Count.BiggerThanOrEqualTo(3))
            {
                throw new ArgumentOutOfRangeException("You must have three or more walls for a room");
            }
            else
            {
                Walls = walls;
            }
            if (doors.Count.BiggerThan(walls.Count))
            {
                throw new ArgumentOutOfRangeException("You cannot have more doors than walls.");
            }
            else
            {
                Walls = walls;
            }

            Windows = windows;
        }

        /// <summary>
        /// The list of <see cref="Door"/>s that are going to be taken into account when calculating the paint needed.
        /// </summary>
        public HashSet<ObjectModel> Doors { get; set; }

        /// <summary>
        /// The list of <see cref="Wall"/>s that are going to be taken into account when calculating the paint needed.
        /// </summary>
        public HashSet<ObjectModel> Walls { get; set; }

        /// <summary>
        /// The list of <see cref="Window"/>s that are going to be taken into account when calculating the paint needed.
        /// </summary>
        public HashSet<ObjectModel> Windows { get; set; }

        public double Area
        {
            get
            {
                double area = 0.0;
                Walls.ToList().ForEach((wall) => area += wall.Height * wall.Width);

                return area;
            }
        }
        public double AreaWithoutDoorsAndWindows
        {
            get
            {
                double area = Area;
                Doors.ToList().ForEach((door) => area -= door.Height * door.Width);
                Windows.ToList().ForEach((window) => area -= window.Height * window.Width);

                return area;
            }
        }
        public double PaintNeeded
        {
            get
            {
                return AreaWithoutDoorsAndWindows / 10;
            }
        }
    }
}
