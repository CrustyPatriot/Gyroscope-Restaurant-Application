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
        /// All types of menu items.
        /// </summary>
        public static string[] Type
        {
            get => new string[]
            {
                "Entrees",
                "Sides",
                "Drinks",
                "Treats"
            };
        }
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
        /// Searches for the specific menu item.
        /// </summary>
        /// <param name="items">The list of menu items.</param>
        /// <param name="names">THe name of the menu items.</param>
        /// <returns>
        /// Returns the list of menu items.
        /// </returns>
        public static IEnumerable<IMenuItem> Search(IEnumerable<IMenuItem> items, string names)
        {
            List<IMenuItem> resultList = new List<IMenuItem>();
            if (names != null)
            {
                
                foreach(IMenuItem menuItem in items)
                {
                    if (menuItem != null && menuItem.Name.Contains(names, StringComparison.CurrentCultureIgnoreCase))
                    {
                        resultList.Add(menuItem);
                    }
                    else if (menuItem.Description != null && menuItem.Description.Contains(names, StringComparison.CurrentCultureIgnoreCase))
                    {
                        resultList.Add(menuItem);
                    }
                }
            }
            return resultList;
        }

        /// <summary>
        /// A filter to add a specific type of menu item.
        /// </summary>
        /// <param name="items">The list of items.</param>
        /// <param name="itemType">The type of item.</param>
        /// <returns>
        /// Returns a list of items.
        /// </returns>
        public static IEnumerable<IMenuItem> TypeFilter(IEnumerable<IMenuItem> items, IEnumerable<string> itemType)
        {
            if (itemType == null || itemType.Count() == 0)
            {
                return items;
            }

            List<IMenuItem> resultList = new List<IMenuItem>();

            if (itemType.Contains("Entrees"))
            {
                foreach(IMenuItem item in items)
                {
                    resultList.Add(item);
                }
            }
            if (itemType.Contains("Sides"))
            {
                foreach(IMenuItem item in items)
                {
                    resultList.Add(item);
                }
            }
            if (itemType.Contains("Drinks"))
            {
                foreach(IMenuItem item in items)
                {
                    resultList.Add(item);
                }
            }
            if (itemType.Contains("Treats"))
            {
                foreach(IMenuItem item in items) 
                {
                    resultList.Add(item);
                }
            }
            return resultList;
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
