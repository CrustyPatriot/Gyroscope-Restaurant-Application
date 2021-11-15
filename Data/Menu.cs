using Gyroscope.Data;
using GyroScope.Data.Drinks;
using GyroScope.Data.Entrees;
using GyroScope.Data.Enums;
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
                List<IMenuItem> list = new List<IMenuItem>();
                list.Add(new LeoLambGyro());
                list.Add(new PiscesFishDish());
                list.Add(new ScorpioSpicyGyro());
                list.Add(new VirgoClassicGyro());
                return list;
            }
        }

        /// <summary>
        /// Contains all the sides.
        /// </summary>
        public static IEnumerable<IMenuItem> Sides
        {
            get
            {
                var sides = new List<IMenuItem>();
                foreach(Size size in Enum.GetValues(typeof(Size)))
                {
                    sides.Add(new AriesFries() { Size = size });
                    
                }
                foreach(Size size in Enum.GetValues(typeof(Size)))
                {
                    sides.Add(new GeminiStuffedGrapeLeaves() { Size = size });
                }
                foreach(Size size in Enum.GetValues(typeof(Size)))
                {
                    sides.Add(new SagittariusGreekSalad() { Size = size });
                }
                foreach(Size size in Enum.GetValues(typeof(Size)))
                {
                    sides.Add(new TaurusTabuleh() { Size = size });
                }
                return sides;
            }
        }

        /// <summary>
        /// Contains all the drinks.
        /// </summary>
        public static IEnumerable<IMenuItem> Drinks
        {
            get
            {
                List<IMenuItem> drinks = new List<IMenuItem>();

                drinks.Add(new CapricornMountainTea());
                foreach(LibraLibationFlavor f in Enum.GetValues(typeof(LibraLibationFlavor)))
                {
                    LibraLibationFlavor flavor = f;
                    var libra = new LibraLibation();
                    libra.Flavor = flavor;
                    libra.Sparkling = true;
                    drinks.Add(libra);
                }
                foreach (LibraLibationFlavor f in Enum.GetValues(typeof(LibraLibationFlavor)))
                {
                    LibraLibationFlavor flavor = f;
                    var libra = new LibraLibation();
                    libra.Flavor = flavor;
                    libra.Sparkling = false;
                    drinks.Add(libra);
                }
                return drinks;
            }
        }

        /// <summary>
        /// Contains all the treats.
        /// </summary>
        public static IEnumerable<IMenuItem> Treats
        {
            get
            {
                List<IMenuItem> treats = new List<IMenuItem>();

                treats.Add(new CancerHalvaCake());
                foreach(Size size in Enum.GetValues(typeof(Size)))
                {
                    foreach(AquariusIceFlavor flavor in Enum.GetValues(typeof(AquariusIceFlavor))) 
                    {
                        var ice = new AquariusIce();
                        ice.Size = size;
                        ice.Flavor = flavor;
                        treats.Add(ice);
                    }
                }
                return treats;
            }
        }
    }
}
