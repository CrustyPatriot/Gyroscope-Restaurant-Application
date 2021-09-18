using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The base class for all entrees.
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// The price of the entree.
        /// </summary>
        public abstract decimal Price { get; }

        /// <summary>
        /// The calories of the entree.
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions for each 
        /// </summary>
        public virtual IEnumerable<string> SpecialInstructions { get; }
    }
}
