using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GyroScope.Data.Enums;

namespace GyroScope.Data.Entrees
{
    /// <summary>
    /// A class to represent the Virgo Classic Gyro.
    /// </summary>
    public class VirgoClassicGyro
    {
        public DonorMeat Meat = DonorMeat.Pork;
        public bool Pita = true;
        public bool Tomato = true;
        public bool Onion = true;
        public bool Lettuce = true;
        public bool Tzatziki = true;

        public bool Peppers = false;
        public bool WingSauce = false;
        public bool EggPlant = false;
        public bool MintChutney = false;

        public decimal Price => 5.50m;

        /// <summary>
        /// Property that shows a string of the customized order.
        /// </summary>
        public IEnumerable<string> SpecialInstructions
        {
            get
            {
                if (Meat != DonorMeat.Pork)
                {
                    if (Meat == DonorMeat.Beef)
                    {
                        yield return "Use beef";
                    }
                    if (Meat == DonorMeat.Chicken)
                    {
                        yield return "Use chicken";
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
                else if (Tomato == false)
                {
                    yield return "Hold tomato";
                }
                else if (Onion == false)
                {
                    yield return "Hold onion";
                }
                else if (Lettuce == false)
                {
                    yield return "Hold lettuce";
                }
                else if (Tzatziki == false)
                {
                    yield return "Hold tzatziki";
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

                if (Meat == DonorMeat.Pork)
                {
                    calorieSum += 187;
                }
                else if (Meat == DonorMeat.Lamb)
                {
                    calorieSum += 151;
                }
                else if (Meat == DonorMeat.Chicken)
                {
                    calorieSum += 113;
                }
                else if (Meat == DonorMeat.Beef)
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
