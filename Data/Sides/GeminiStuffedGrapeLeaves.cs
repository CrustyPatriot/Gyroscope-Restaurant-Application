using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;
using PointOfSale;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A class to represent a side of Gemini Stuffed Grape Leaves.
    /// </summary>
    public class GeminiStuffedGrapeLeaves : Side, INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return $"{Size} Gemini Stuffed Grape Leaves";
        }

        /// <summary>
        /// The price of the Gemini stuffed grape leaves.
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
        /// The calories of the Gemini stuffed grape leaves.
        /// </summary>
        public override uint Calories
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

