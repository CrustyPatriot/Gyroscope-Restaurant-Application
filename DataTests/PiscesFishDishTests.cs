using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;
using System.Collections.Generic;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the pisces fish dish.
    /// </summary>
    public class PiscesFishDishTests
    {
        /// <summary>
        /// Checks the price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            PiscesFishDish fish = new();
            Assert.Equal(5.99m, fish.Price);
        }

        /// <summary>
        /// Checks that the calories are correct.
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            PiscesFishDish fish = new();
            Assert.Equal(fish.Calories, (uint)726);
        }

        /// <summary>
        /// Checks that the special instructions are empty.
        /// </summary>
        [Fact]
        public void SpecialInstructionsShouldBeEmpty()
        {
            PiscesFishDish fish = new();
            Assert.Contains("",fish.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the To String override method is correct.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            var dish = new PiscesFishDish();
            Assert.Equal("Pisces Fish Dish", dish.ToString());
        }
    }
}
