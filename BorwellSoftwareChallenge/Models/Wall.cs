using System;
using System.ComponentModel.DataAnnotations;

namespace BorwellSoftwareChallenge.Models
{
    public class Wall
    {
        public Wall(double height, double width)
        {
            if (!ValidationPassed(height) || !ValidationPassed(width))
            {
                throw new ArgumentOutOfRangeException("One or more arguments cannot be less than or equal to 0.0");
            }
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Gets or sets the <see cref="Height"/> of the <see cref="Wall"/>.
        /// </summary>
        [Range(0.0, double.MaxValue)]
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Width"/> of the <see cref="Wall"/>.
        /// </summary>
        [Range(0.0, double.MaxValue)]
        public double Width { get; set; }

        private bool ValidationPassed(double value)
        {
            return !(value <= 0.0);
        }
    }
}
