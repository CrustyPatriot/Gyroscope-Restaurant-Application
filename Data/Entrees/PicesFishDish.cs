using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A class to represent the Pisces Fish dish.
    /// </summary>
    public class PicesFishDish
    {
        public decimal Price => 5.99m;

        public uint Calories => 726;

        public IEnumerable<string> CustomOrder = Enumerable.Empty<string>();
    }
}
