using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// The base class for all sides.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// The size of the side.
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the side.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the side.
        /// </summary>
        public abstract uint Calories { get; }
    }
}
