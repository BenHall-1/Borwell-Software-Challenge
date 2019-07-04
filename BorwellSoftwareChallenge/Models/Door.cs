using BorwellSoftwareChallenge.Extensions;
using System;

namespace BorwellSoftwareChallenge.Models
{
    public class Door
    {
        /// <summary>
        /// Initializes an instance of the <see cref="Door"/> class.
        /// </summary>
        /// <param name="height">The height of the <see cref="Door"/>.</param>
        /// <param name="width">The width of the <see cref="Door"/>.</param>
        public Door(double height, double width)
        {
            if (!height.IsValid() || !width.IsValid())
            {
                throw new ArgumentOutOfRangeException("One or more arguments cannot be less than or equal to 0.0");
            }
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Gets or sets the <see cref="Height"/> of the <see cref="Door"/>.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Width"/> of the <see cref="Door"/>.
        /// </summary>
        public double Width { get; set; }

        private bool ValidationPassed(double value)
        {
            return !(value <= 0.0);
        }
    }
}
