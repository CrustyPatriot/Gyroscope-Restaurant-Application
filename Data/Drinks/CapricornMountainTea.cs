﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PointOfSale;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// A class to represent the "Capricorn Mountain Tea" drink.
    /// </summary>
    public class CapricornMountainTea : Drink, INotifyPropertyChanged, IMenuItem
    {

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return "Capricorn Mountain Tea";
        }

        /// <summary>
        /// The price of the capricorn mountain tea.
        /// </summary>
        public override decimal Price => 2.50m;

        /// <summary>
        /// The calories of the capricorn mountain tea.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Honey)
                {
                    return 64;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>
        /// Backing field for honey.
        /// </summary>
        public bool _honey = false;

        /// <summary>
        /// The ingredient honey.
        /// </summary>
        public bool Honey
        {
            get => _honey;
            set
            {
                if (_honey != value)
                {
                    _honey = value;
                    OnPropertyChanged(nameof(Honey));
                    OnPropertyChanged(nameof(Calories));
                }
            }
        }

        /// <summary>
        /// The special instructions.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions => null;

        /// <summary>
        /// The name of the drink.
        /// </summary>
        public override string Name => "Capricorn Mountain Tea";
    }
}
