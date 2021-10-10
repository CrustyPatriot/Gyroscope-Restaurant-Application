using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The class to represent the "Libra Libation" drink.
    /// </summary>
    public class LibraLibation : Drink, INotifyPropertyChanged
    {

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Flavor} Libra Libation";
        }

        /// <summary>
        /// Private backing field for libra libation flavor.
        /// </summary>
        public LibraLibationFlavor _flavor = LibraLibationFlavor.Orangeade;

        /// <summary>
        /// The flavor of the libra libation.
        /// </summary>
        public LibraLibationFlavor Flavor
        {
            get => _flavor;
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    OnPropertyChanged(nameof(Flavor));
                    OnPropertyChanged(nameof(Calories));
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Backing field for sparkling
        /// </summary>
        private bool _sparkling = true;

        /// <summary>
        /// If the drink is sparkling (carbonated) or not.
        /// </summary>
        public bool Sparkling
        {
            get => _sparkling;
            set
            {
                if (_sparkling != value)
                {
                    _sparkling = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// The calories of the libra libation.
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch(Flavor)
                {
                    case LibraLibationFlavor.Orangeade:
                        return 180;
                    case LibraLibationFlavor.SourCherry:
                        return 100;
                    case LibraLibationFlavor.Biral:
                        return 120;
                    default:
                        return 41;
                }
            }
        }

        /// <summary>
        /// The price of the libra libation.
        /// </summary>
        public override decimal Price => 1.00m;

        /// <summary>
        /// The full name of the libra libation.
        /// </summary>
        public string Name
        {
            get
            {
                if (Sparkling)
                {
                    return "Sparkling " + Flavor +  " Libra Libation";
                }
                else
                {
                    return "Still " + Flavor + " Libra Libation";
                }
            }
        }
    }
}
