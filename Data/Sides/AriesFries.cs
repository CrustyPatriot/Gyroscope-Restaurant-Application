using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;
using Gyroscope.Data;

namespace GyroScope.Data.Sides
{
    /// <summary>
    /// A class to represent a side of Aries Fries.
    /// </summary>
    public class AriesFries : Side, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// The description of the Aries Fries.
        /// </summary>
        public override string Description => "Crispy fried potatoes topped with feta cheese, onions, and herbs.";

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return $"{Size} Aries Fries";
        }

        /// <summary>
        /// The price of the Ares Fries.
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
        /// The calories of the Ares Fries.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 304;
                    case Size.Medium:
                        return 456;
                    case Size.Large:
                        return 608;
                    default:
                        throw new NotImplementedException($"Unknown Calorie amount");
                }
            }
        }
    }
}
