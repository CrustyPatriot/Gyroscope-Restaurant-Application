using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A class to represent a side of Gemini Stuffed Grape Leaves.
    /// </summary>
    public class GeminiStuffedGrapeLeaves
    {
        /// <summary>
        /// The size of the Gemini stuffed grape leaves.
        /// \
        /// </summary>
        public Size Size { get; set; }

        /// <summary>
        /// The price of the Gemini stuffed grape leaves.
        /// </summary>
        public decimal Price
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
        /// The calories of the Gemini stuffed grape leaves.
        /// </summary>
        public uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 360;
                    case Size.Medium:
                        return 540;
                    case Size.Large:
                        return 720;
                    default:
                        throw new NotImplementedException($"Unknown Calorie amount");
                }
            }
        }
    }
}

