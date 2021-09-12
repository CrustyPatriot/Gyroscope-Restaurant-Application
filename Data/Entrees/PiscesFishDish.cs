using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A class to represent the Pisces Fish dish.
    /// </summary>
    public class PiscesFishDish : Entree
    {
        /// <summary>
        /// The price for the pisces fish dish.
        /// </summary>
        public override decimal Price => 5.99m;

        /// <summary>
        /// The calories for the pisces fish dish.
        /// </summary>
        public override uint Calories => 726;

        /// <summary>
        /// The special instructions for the pisces fish dish.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                yield return "";
            }
        }
    }
}
