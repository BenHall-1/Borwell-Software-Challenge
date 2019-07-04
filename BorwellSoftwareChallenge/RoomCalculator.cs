using System;

namespace BorwellSoftwareChallenge
{
    class RoomCalculator
    {
        static void Main(string[] args)
        { 
            int wallCount;
            int doorCount;
            int windowCount;

            Console.WriteLine("How many walls will there be?");
            try
            {
                wallCount = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"You have entered an incorrectly formatted number (Error: {e.Message})");
            }

            Console.WriteLine("How many walls will there be?");
            try
            {
                wallCount = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"You have entered an incorrectly formatted number (Error: {e.Message})");
            }

            // Stops the program from instantly closing
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
