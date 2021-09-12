using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A class to represent a side of Tarus Tabuleh.
    /// </summary>
    public class TaurusTabuleh : Side
    {
        /// <summary>
        /// The price of the Tarus Tabuleh.
        /// </summary>
        public override decimal Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.50m;
                    case Size.Medium:
                        return 2.00m;
                    case Size.Large:
                        return 2.50m;
                    default:
                        throw new NotImplementedException($"Unknown Size {Size}");
                }
            }
        }

        /// <summary>
        /// The calories of the Tarus Tabuleh.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 124;
                    case Size.Medium:
                        return 186;
                    case Size.Large:
                        return 248;
                    default:
                        throw new NotImplementedException($"Unknown Calorie amount");
                }
            }
        }
    }
}
