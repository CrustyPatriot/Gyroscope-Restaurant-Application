using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Sides;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the taurus tabuleh side.
    /// </summary>
    public class TaurusTabulehTests
    {
        /// <summary>
        /// Checks to see if the size is default set to small.
        /// </summary>
        [Fact]
        public void SizeShouldDefaultToSmall()
        {
            TaurusTabuleh side = new();
            Assert.Equal(Size.Small, side.Size);
        }

        /// <summary>
        /// Checks to see if the size can change.
        /// </summary>
        /// <param name="size">The size to change.</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            TaurusTabuleh side = new();
            side.Size = size;
            Assert.Equal(size, side.Size);
        }

        /// <summary>
        /// Checks to see if the price matches the size.
        /// </summary>
        /// <param name="size">The size to check.</param>
        /// <param name="price">The price to check.</param>
        [Theory]
        [InlineData(Size.Small, 1.50)]
        [InlineData(Size.Medium, 2.00)]
        [InlineData(Size.Large, 2.50)]
        public void PriceShouldBeCorrectForSize(Size size, decimal price)
        {
            TaurusTabuleh side = new()
            {
                Size = size
            };
            Assert.Equal(price, side.Price);
        }

        /// <summary>
        /// Checks to see if the calories are correct for the size.
        /// </summary>
        /// <param name="size">The size to check.</param>
        /// <param name="calories">The calories to check.</param>
        [Theory]
        [InlineData(Size.Small, 124)]
        [InlineData(Size.Medium, 186)]
        [InlineData(Size.Large, 248)]
        public void CaloriesShouldBeCorrectForSize(Size size, uint calories)
        {
            TaurusTabuleh side = new()
            {
                Size = size
            };
            Assert.Equal(calories, side.Calories);
        }
    }
}
