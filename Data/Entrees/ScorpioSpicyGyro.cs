using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A class to represent the Scorpio Spicy Gyro.
    /// </summary>
    public class ScorpioSpicyGyro : Gyro
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
                    else
                    {
                        yield return "Use Lamb";
                    }
                }
                else if (Pita == false)
                {
                    yield return "Hold pita";
                }
                else if (Peppers == false)
                {
                    yield return "Hold peppers";
                }
                else if (Onion == false)
                {
                    yield return "Hold onion";
                }
                else if (Lettuce == false)
                {
                    yield return "Hold lettuce";
                }
                else if (WingSauce == false)
                {
                    yield return "Hold wing sauce";
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
                else if (Meat == DonerMeat.Lamb)
                {
                    calorieSum += 151;
                }
                else if (Meat == DonerMeat.Chicken)
                {
                    calorieSum += 113;
                }
                else if (Meat == DonerMeat.Beef)
                {
                    calorieSum += 181;
                }
                else if (Pita == true)
                {
                    calorieSum += 262;
                }
                else if (Tomato == true)
                {
                    calorieSum += 30;
                }
                else if (Onion == true)
                {
                    calorieSum += 30;
                }
                else if (Lettuce == true)
                {
                    calorieSum += 54;
                }
                else if (Tzatziki == true)
                {
                    calorieSum += 30;
                }
                else if (Peppers == true)
                {
                    calorieSum += 33;
                }
                else if (WingSauce == true)
                {
                    calorieSum += 15;
                }
                else if (Eggplant == true)
                {
                    calorieSum += 47;
                }
                else if (MintChutney == true)
                {
                    calorieSum += 10;
                }
                return calorieSum;
            }
        }
    }
}
