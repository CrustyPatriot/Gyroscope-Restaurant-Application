﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// A class to represent the "Capricorn Mountain Tea" drink.
    /// </summary>
    public class CapricornMountainTea : Drink, INotifyPropertyChanged
    {
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

        public bool _honey = false;

        /// <summary>
        /// The ingredient honey.
        /// </summary>
        public bool Honey
        {
            get => _honey;
            set
            {
                _honey = value;
                OnPropertyChanged(nameof(Calories));
            }
        }
    }
}
