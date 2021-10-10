using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Sides;
using System.ComponentModel;

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

        /// <summary>
        /// Checks to see that the INotifyPropertyChanged event is correctly changed.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var side = new TaurusTabuleh();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(side);
        }

        /// <summary>
        /// Checks to see if the INotifyPropertyChanged event changes the properties.
        /// </summary>
        /// <param name="size">The size to be changed.</param>
        /// <param name="propertyName">The name of the property to be changed.</param>
        [Theory]
        [InlineData(Size.Small, "Size")]
        [InlineData(Size.Medium, "Size")]
        [InlineData(Size.Large, "Size")]
        [InlineData(Size.Small, "Price")]
        [InlineData(Size.Medium, "Price")]
        [InlineData(Size.Large, "Price")]
        [InlineData(Size.Small, "Calories")]
        [InlineData(Size.Medium, "Calories")]
        [InlineData(Size.Large, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName)
        {
            var side = new TaurusTabuleh();

            ///A quick hack to avoid not changing size when setting to the default size.
            if (size == Size.Small) { side.Size = Size.Large; }
            Assert.PropertyChanged(side, propertyName, () =>
            {
                side.Size = size;
            });
        }

        /// <summary>
        /// Checks to see if the to string override method is correct.
        /// </summary>
        /// <param name="size">The size to check.</param>
        /// <param name="name">The name to check.</param>
        [Theory]
        [InlineData(Size.Small, "Small Taurus Tabouleh")]
        [InlineData(Size.Medium, "Medium Taurus Tabouleh")]
        [InlineData(Size.Large, "Large Taurus Tabouleh")]
        public void ToStringShouldReturnExpectedValue(Size size, string name)
        {
            var side = new TaurusTabuleh()
            {
                Size = size
            };
            Assert.Equal(name, side.ToString());
        }
    }
}
