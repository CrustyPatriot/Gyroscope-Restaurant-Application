using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gyroscope.Data;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A class representing the "Cancer Halveh cake" treat.
    /// </summary>
    public class CancerHalvaCake : Treat, IMenuItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The description of the Cancer Halva Cake treat.
        /// </summary>
        public override string Description => "A gluten-free cake made from sesame seeds";

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return "Cancer Halva Cake";
        }

        /// <summary>
        /// The price of the cancer halveh cake.
        /// </summary>
        public override decimal Price => 3.00m;

        /// <summary>
        /// The calories of the cancer halveh cake.
        /// </summary>
        public override uint Calories => 272;

        /// <summary>
        /// The name of the Cancer Halva Cake.
        /// </summary>
        public override string Name => this.ToString();
    }
}
