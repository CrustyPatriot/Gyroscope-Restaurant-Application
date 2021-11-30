using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;
using System.ComponentModel;
using Gyroscope.Data;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A class to represent the Leo Lamb Gyro.
    /// </summary>
    public class LeoLambGyro : Gyro, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Constructor for the leo lamb gyro.
        /// </summary>
        public LeoLambGyro()
        {
            Meat = DonerMeat.Lamb;
            Pita = true;
            Tomato = true;
            Onion = true;
            Eggplant = true;
            Lettuce = true;
            MintChutney = true;
        }

        /// <summary>
        /// The description of the Leo Lamb Gyro.
        /// </summary>
        public override string Description => "	A fresh take on the gyro - seasoned doner lamb, fresh sliced tomato, diced onion, steamed eggplant, and shredded lettuce, smothered in mint chutney and served in a pita.";

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return "Leo Lamb Gyro";
        }

        /// <summary>
        /// Gets the name of the item.
        /// </summary>
        public override string Name
        {
            get
            {
                return ToString();
            }
        }

        /// <summary>
        /// The price of the leo lamb gyro.
        /// </summary>
        public override decimal Price => 5.75m;

        /// <summary>
        /// Property that shows a string of the customized order.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                if (Meat != DonerMeat.Lamb)
                {
                    if (Meat == DonerMeat.Beef)
                    {
                        yield return "Use beef";
                    }
                    if (Meat == DonerMeat.Chicken)
                    {
                        yield return "Use chicken";
                    }
                    if (Meat == DonerMeat.Pork)
                    {
                        yield return "Use pork";
                    }
                }
                if (Pita == false)
                {
                    yield return "Hold pita";
                }
                if (Tomato == false)
                {
                    yield return "Hold tomato";
                }
                if (Onion == false)
                {
                    yield return "Hold onion";
                }
                if (Eggplant == false)
                {
                    yield return "Hold eggplant";
                }
                if (Lettuce == false)
                {
                    yield return "Hold lettuce";
                }
                if (MintChutney == false)
                {
                    yield return "Hold mint chutney";
                }
                if (WingSauce == true)
                {
                    yield return "Add wing sauce";
                }
                if (Tzatziki == true)
                {
                    yield return "Add tzatziki";
                }
                if (Peppers == true)
                {
                    yield return "Add peppers";
                }
            }
        }

        /// <summary>
        /// Property that calculates the amount of total calories.
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint calorieSum = 0;

                if (Meat == DonerMeat.Pork)
                {
                    calorieSum += 187;
                }
                if (Meat == DonerMeat.Lamb)
                {
                    calorieSum += 151;
                }
                if (Meat == DonerMeat.Chicken)
                {
                    calorieSum += 113;
                }
                if (Meat == DonerMeat.Beef)
                {
                    calorieSum += 181;
                }
                if (Pita == true)
                {
                    calorieSum += 262;
                }
                if (Tomato == true)
                {
                    calorieSum += 30;
                }
                if (Onion == true)
                {
                    calorieSum += 30;
                }
                if (Lettuce == true)
                {
                    calorieSum += 54;
                }
                if (Tzatziki == true)
                {
                    calorieSum += 30;
                }
                if (Peppers == true)
                {
                    calorieSum += 33;
                }
                if (WingSauce == true)
                {
                    calorieSum += 15;
                }
                if (Eggplant == true)
                {
                    calorieSum += 47;
                }
                if (MintChutney == true)
                {
                    calorieSum += 10;
                }
                return calorieSum;
            }
        }
    }
}
