using BorwellSoftwareChallenge.Extensions;
using BorwellSoftwareChallenge.Models;
using System;
using System.Collections.Generic;

namespace BorwellSoftwareChallenge
{
    public class RoomCalculator
    {
        /// <summary>
        /// Calculates the amount of paint needed for the room
        /// </summary>
        static void Main(string[] args)
        {
            var walls = Setup("wall");
            var doors = Setup("door");
            var windows = Setup("window");

            var room = new Room(doors, walls, windows);

            Console.WriteLine($"Area (Including Doors and Windows): {room.Area}m²");
            Console.WriteLine($"Area (Excluding Doors and Windows): {room.AreaWithoutDoorsAndWindows}m²");
            Console.WriteLine($"Litres of paint needed: {room.PaintNeeded}l");

            Console.ReadKey();
        }

        /// <summary>
        /// Sets up all of the <see cref="Door"/>s for the <see cref="Room"/>.
        /// </summary>
        /// <returns>a <see cref="HashSet{Door}"/> of <see cref="Door"/>s.</returns>
        public static HashSet<ObjectModel> Setup(string type)
        {
            HashSet<ObjectModel> models = new HashSet<ObjectModel>();
            var count = 0;
            var isValid = false;

            Console.WriteLine($"How many {type}s are there?");

            while (isValid == false)
            {
                try
                {
                    count = int.Parse(Console.ReadLine());
                    isValid = true;
                }
                catch (FormatException ignored)
                {
                    Console.WriteLine($"You did not enter a number ({ignored.Message})");

                }
            }

            for (int i = 0; i < count; i++)
            {
                isValid = false;

                while (isValid == false)
                {
                    try
                    {
                        Console.WriteLine($"What is the height of {type} #{i + 1}.");
                        var height = int.Parse(Console.ReadLine());

                        Console.WriteLine($"What is the width of {type} #{i + 1}.");
                        var width = int.Parse(Console.ReadLine());

                        models.Add(new ObjectModel(height, width));

                        isValid = true;
                    }
                    catch (FormatException ignored)
                    {
                        Console.WriteLine($"You did not enter a number ({ignored.Message})");

                    }
                }
            }

            return models;
        }
    }
}
