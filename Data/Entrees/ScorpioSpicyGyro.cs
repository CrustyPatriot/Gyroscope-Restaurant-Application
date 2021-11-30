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
    /// A class to represent the Scorpio Spicy Gyro.
    /// </summary>
    public class ScorpioSpicyGyro : Gyro, INotifyPropertyChanged, IMenuItem
    {
        /// <summary>
        /// Constructor for the scorpio spicy gyro.
        /// </summary>
        public ScorpioSpicyGyro()
        {
            Meat = DonerMeat.Chicken;
            Pita = true;
            Peppers = true;
            Onion = true;
            Lettuce = true;
            WingSauce = true;
        }

        /// <summary>
        /// The description of the Scorpio Spicy Gyro.
        /// </summary>
        public override string Description => "A gyro with a spicy twist - seasoned doner chicken, steamed peppers, chopped onions, and shredded lettuce topped with hot wing sauce and wrapped in a warm pita.";

        /// <summary>
        /// Override to string method to be correct for the menu item.
        /// </summary>
        /// <returns>
        /// Returns updated string.
        /// </returns>
        public override string ToString()
        {
            return "Scorpio Spicy Gyro";
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
        /// The price of the scorpio spicy gyro.
        /// </summary>
        public override decimal Price => 6.20m;

        /// <summary>
        /// Property that shows a string of the customized order.
        /// </summary>
        public override IEnumerable<string> SpecialInstructions
        {
            get
            {
                if (Meat != DonerMeat.Chicken)
                {
                    if (Meat == DonerMeat.Beef)
                    {
                        yield return "Use beef";
                    }
                    if (Meat == DonerMeat.Pork)
                    {
                        yield return "Use pork";
                    }
                    if (Meat == DonerMeat.Lamb)
                    {
                        yield return "Use lamb";
                    }
                }
                if (Pita == false)
                {
                    yield return "Hold pita";
                }
                if (Peppers == false)
                {
                    yield return "Hold peppers";
                }
                if (Onion == false)
                {
                    yield return "Hold onion";
                }
                if (Lettuce == false)
                {
                    yield return "Hold lettuce";
                }
                if (WingSauce == false)
                {
                    yield return "Hold wing sauce";
                }
                if (Tomato == true)
                {
                    yield return "Add tomato";
                }
                if (Eggplant == true)
                {
                    yield return "Add eggplant";
                }
                if (Tzatziki == true)
                {
                    yield return "Add tzatziki";
                }
                if (MintChutney == true)
                {
                    yield return "Add mint chutney";
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
