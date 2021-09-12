using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The base class for all drinks.
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// The price of the drink.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the drink.
        /// </summary>
        public abstract uint Calories { get; }
    }
}
