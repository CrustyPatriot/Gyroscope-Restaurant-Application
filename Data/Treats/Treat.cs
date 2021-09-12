using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// The base class for all treats.
    /// </summary>
    public abstract class Treat
    {
        /// <summary>
        /// The price of the treat.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the treat.
        /// </summary>
        public abstract uint Calories { get; }
    }
}
