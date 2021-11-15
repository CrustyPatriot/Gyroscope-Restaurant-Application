using Gyroscope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Sides;
using GyroScope.Data.Treats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyroScope.Data
{
    /// <summary>
    /// Class containing all menu items.
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Contains all the entrees.
        /// </summary>
        public static IEnumerable<IMenuItem> Entrees
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new LeoLambGyro(),
                    new PiscesFishDish(),
                    new ScorpioSpicyGyro(),
                    new VirgoClassicGyro()
                };
            }
        }

        /// <summary>
        /// Contains all the sides.
        /// </summary>
        public static IEnumerable<IMenuItem> Sides
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new AriesFries(),
                    new GeminiStuffedGrapeLeaves(),
                    new SagittariusGreekSalad(),
                    new TaurusTabuleh()
                };
            }
        }

        /// <summary>
        /// Contains all the drinks.
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new CapricornMountainTea(),
                    new LibraLibation()
                };
            }
        }

        /// <summary>
        /// Contains all the treats.
        /// </summary>
        public static IEnumerable<IMenuItem> Treats
        {
            get
            {
                return new List<IMenuItem>()
                {
                    new AquariusIce(),
                    new CancerHalvaCake()
                };
            }
        }
    }
}
