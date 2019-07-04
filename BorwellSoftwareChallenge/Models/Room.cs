using BorwellSoftwareChallenge.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorwellSoftwareChallenge.Models
{
    /// <summary>
    /// The <see cref="Room"/> that you are calculating the paint for.
    /// </summary>
    public class Room
    {
        public Room(HashSet<Door> doors, HashSet<Wall> walls, HashSet<Window> windows)
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
        }

        /// <summary>
        /// The list of <see cref="Door"/>s that are going to be taken into account when calculating the paint needed.
        /// </summary>
        public HashSet<Door> Doors { get; set; }

        /// <summary>
        /// The list of <see cref="Wall"/>s that are going to be taken into account when calculating the paint needed.
        /// </summary>
        public HashSet<Wall> Walls { get; set; }

        /// <summary>
        /// The list of <see cref="Window"/>s that are going to be taken into account when calculating the paint needed.
        /// </summary>
        public HashSet<Window> Windows { get; set; }
    }
}
