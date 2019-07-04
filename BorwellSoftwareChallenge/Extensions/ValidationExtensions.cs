namespace BorwellSoftwareChallenge.Extensions
{
    public static class ValidationExtensions
    {
        public static bool IsValid(this double value)
        {
            return !(value <= 0.0);
        }
    }
}
