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
    /// A class to represent a side of Sagittarius greek salad.
    /// </summary>
    public class SagittariusGreekSalad : Side, INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return $"{Size} Sagittarius Greek Salad";
        }

        /// <summary>
        /// The price of the Sagittarius greek salad.
        /// </summary>
        public override decimal Price
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
        public override uint Calories
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

