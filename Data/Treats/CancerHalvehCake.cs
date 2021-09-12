using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data.Treats
{
    /// <summary>
    /// A class representing the "Cancer Halveh cake" treat.
    /// </summary>
    public class CancerHalvehCake : Treat
    {
        /// <summary>
        /// The price of the cancer halveh cake.
        /// </summary>
        public override decimal Price => 3.00m;

        /// <summary>
        /// The calories of the cancer halveh cake.
        /// </summary>
        public override uint Calories => 272;
    }
}
