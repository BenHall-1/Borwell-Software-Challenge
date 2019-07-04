using BorwellSoftwareChallenge.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorwellSoftwareChallenge.Models
{
    public class ObjectModel
    {
        /// <summary>
        /// Initializes an instance of the <see cref="ObjectModel"/> class.
        /// </summary>
        /// <param name="height">The height of the <see cref="ObjectModel"/>.</param>
        /// <param name="width">The width of the <see cref="ObjectModel"/>.</param>
        public ObjectModel(double height, double width)
        {
            if (!height.IsValid() || !width.IsValid())
            {
                throw new ArgumentOutOfRangeException("One or more arguments cannot be less than or equal to 0.0");
            }
            Height = height;
            Width = width;
        }

        /// <summary>
        /// Gets or sets the <see cref="Height"/> of the <see cref="ObjectModel"/>.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Width"/> of the <see cref="ObjectModel"/>.
        /// </summary>
        public double Width { get; set; }
    }
}
