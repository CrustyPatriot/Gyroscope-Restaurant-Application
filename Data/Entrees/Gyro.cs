﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// The class containing the Gyro instructions.
    /// </summary>
    public class Gyro : Entree
    {
        /// <summary>
        /// The price.
        /// </summary>
        public override decimal Price { get; }

        /// <summary>
        /// The calories.
        /// </summary>
        public override uint Calories { get; }
        /// <summary>
        /// The type of meat.
        /// </summary>
        public DonerMeat Meat { get; set; }
        /// <summary>
        /// The ingredient pita.
        /// </summary>
        public bool Pita { get; set; }
        /// <summary>
        /// The ingredient tomato.
        /// </summary>
        public bool Tomato { get; set; }
        /// <summary>
        /// The ingredient onion.
        /// </summary>
        public bool Onion { get; set; }
        /// <summary>
        /// The ingredient eggplant.
        /// </summary>
        public bool Eggplant { get; set; }
        /// <summary>
        /// The ingredient lettuce.
        /// </summary>
        public bool Lettuce { get; set; }
        /// <summary>
        /// The ingredient mint chutney.
        /// </summary>
        public bool MintChutney { get; set; }
        /// <summary>
        /// The ingredient tzatziki.
        /// </summary>
        public bool Tzatziki { get; set; }
        /// <summary>
        /// The ingredient peppers.
        /// </summary>
        public bool Peppers { get; set; }
        /// <summary>
        /// The ingredient wing sauce.
        /// </summary>
        public bool WingSauce { get; set; }
    }
}