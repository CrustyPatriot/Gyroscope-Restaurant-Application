using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Drinks;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the capricorn mountain tea drink.
    /// </summary>
    public class CapricornMountainTeaTests
    {
        /// <summary>
        /// Checks to see if the price for honey is correct.
        /// </summary>
        /// <param name="honey">The honey to check.</param>
        /// <param name="price">The price to check.</param>
        [Theory]
        [InlineData(true, 2.50)]
        [InlineData(false, 2.50)]
        public void PriceShouldBeCorrectForHoney(bool honey, decimal price)
        {
            CapricornMountainTea tea = new()
            {
                Honey = honey
            };
            Assert.Equal(price, tea.Price);
        }

        /// <summary>
        /// Checks to see if calories is correct with or without honey.
        /// </summary>
        /// <param name="honey">The honey to be checked.</param>
        /// <param name="calories">The calories to be checked.</param>
        [Theory]
        [InlineData(true, 64)]
        [InlineData(false, 0)]
        public void CaloriesShouldBeCorrectForHoney(bool honey, uint calories)
        {
            CapricornMountainTea tea = new()
            {
                Honey = honey
            };
            Assert.Equal(calories, tea.Calories);
        }
    }
}
