namespace BorwellSoftwareChallenge.Extensions
{
    public static class ValidationExtensions
    {
        /// <summary>
        /// Checks whether the number is larger than 0
        /// </summary>
        /// <param name="value">The number that is being checked</param>
        /// <returns>Whether the number is larger than 0</returns>
        public static bool IsValid(this double value)
        {
            return !(value <= 0.0);
        }

        /// <summary>
        /// Checks whether the <paramref name="value"/> is bigger than or equal to the <paramref name="biggerOrEqualsTo"/>.
        /// </summary>
        /// <param name="value">The value that you want to check against <paramref name="biggerOrEqualsTo"/></param>
        /// <param name="biggerOrEqualsTo">The number to that you want to see whether the <paramref name="value"/> is bigger than or equal to</param>
        /// <returns></returns>
        public static bool BiggerThanOrEqualTo(this int value, int biggerOrEqualsTo)
        {
            return value >= biggerOrEqualsTo;
        }
        /// <summary>
        /// Checks whether the <paramref name="value"/> is bigger than the <paramref name="biggerOrEqualsTo"/>.
        /// </summary>
        /// <param name="value">The value that you want to check against <paramref name="biggerOrEqualsTo"/>.</param>
        /// <param name="biggerOrEqualsTo">The number to that you want to see whether the <paramref name="value"/> is bigger than.</param>
        /// <returns></returns>
        public static bool BiggerThan(this int value, int biggerThan)
        {
            return value > biggerThan;
        }
    }
}
