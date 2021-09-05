using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A class to represent a side of Sagittarius greek salad.
    /// </summary>
    public class SagittariusGreekSalad
    {
        /// <summary>
        /// The size of the Sagittarius greek salad.
        /// \
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// The price of the Sagittarius greek salad.
        /// </summary>
        public decimal Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 2.00m;
                    case Size.Medium:
                        return 2.50m;
                    case Size.Large:
                        return 3.00m;
                    default:
                        throw new NotImplementedException($"Unknown Size {Size}");
                }
            }
        }

        /// <summary>
        /// The calories of the Sagittarius greek salad.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 180;
                    case Size.Medium:
                        return 270;
                    case Size.Large:
                        return 360;
                    default:
                        throw new NotImplementedException($"Unknown Calorie amount");
                }
            }
        }
    }
}

