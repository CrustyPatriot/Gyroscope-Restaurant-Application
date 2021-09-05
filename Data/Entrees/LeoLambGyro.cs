﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A class to represent the Leo Lamb Gyro.
    /// </summary>
    public class LeoLambGyro
    {
        public DonerMeat Meat = DonerMeat.Lamb;
        public bool Pita = true;
        public bool Tomato = true;
        public bool Onion = true;
        public bool EggPlant = true;
        public bool Lettuce = true;
        public bool MintChutney = true;

        public bool Tzatziki = false;
        public bool Peppers = false;
        public bool WingSauce = false;

        public decimal Price => 5.75m;

        /// <summary>
        /// Property that shows a string of the customized order.
        /// </summary>
        public IEnumerable<string> SpecialInstructions
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
                    else
                    {
                        yield return "Use Pork";
                    }
                }
                else if (Pita == false)
                {
                    yield return "Hold pita";
                }
                else if (Tomato == false)
                {
                    yield return "Hold tomato";
                }
                else if (Onion == false)
                {
                    yield return "Hold onion";
                }
                else if (EggPlant == false)
                {
                    yield return "Hold eggplant";
                }
                else if (Lettuce == false)
                {
                    yield return "Hold lettuce";
                }
                else if (MintChutney == false)
                {
                    yield return "Hold mint chutney";
                }
            }
        }

        /// <summary>
        /// Property that calculates the amount of total calories.
        /// </summary>
        public uint Calories
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
                else if (EggPlant == true)
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