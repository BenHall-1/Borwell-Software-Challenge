using BorwellSoftwareChallenge.Extensions;
using System;

namespace BorwellSoftwareChallenge.Models
{
    /// <summary>
    /// The windows which will be attached to the room.
    /// </summary>
    public class Window
    {
        /// <summary>
        /// Initializes an instance of the <see cref="Window"/> class.
        /// </summary>
        /// <param name="height">The height of the <see cref="Window"/>.</param>
        /// <param name="width">The width of the <see cref="Window"/>.</param>
        public Window(double height, double width)
        {
            if (!height.IsValid() || !width.IsValid())
            {
                throw new ArgumentOutOfRangeException("One or more arguments cannot be less than or equal to 0.0");
            }
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Gets or sets the <see cref="Height"/> of the <see cref="Window"/>.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Width"/> of the <see cref="Window"/>.
        /// </summary>
        public double Width { get; set; }
    }
}
