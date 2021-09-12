﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Drinks
{
    /// <summary>
    /// The class to represent the "Libra Libation" drink.
    /// </summary>
    public class LibraLibation : Drink
    {
        /// <summary>
        /// The flavor of the libra libation.
        /// </summary>
        public LibraLibationFlavor Flavor { get; set; }

        /// <summary>
        /// If the drink is sparkling (carbonated) or not.
        /// </summary>
        public bool Sparkling { get; set; } = true;

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
                    return $"{Sparkling} {Flavor} Libra Libation";
                }
                else
                {
                    return "Still " + Flavor + " Libra Libation";
                }
            }
        }
    }
}
