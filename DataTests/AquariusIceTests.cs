using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using System.ComponentModel;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for AquariusIce
    /// </summary>
    public class AquariusIceTests
    {
        /// <summary>
        /// Checks default flavor
        /// </summary>
        [Fact]
        public void FlavorShouldDefaultToLemon()
        {
            var ice = new AquariusIce();
            Assert.Equal(AquariusIceFlavor.Lemon, ice.Flavor);
        }

        /// <summary>
        /// Checks that the <paramref name="flavor"/> can be set
        /// </summary>
        /// <param name="flavor">The flavor to use</param>
        [Theory]
        [InlineData(AquariusIceFlavor.BlueRaspberry)]
        [InlineData(AquariusIceFlavor.Lemon)]
        [InlineData(AquariusIceFlavor.Mango)]
        [InlineData(AquariusIceFlavor.Orange)]
        [InlineData(AquariusIceFlavor.Strawberry)]
        [InlineData(AquariusIceFlavor.Watermellon)]
        public void ShouldBeAbleToSetFlavor(AquariusIceFlavor flavor)
        {
            var ice = new AquariusIce();
            ice.Flavor = flavor;
            Assert.Equal(flavor, ice.Flavor);
        }

        /// <summary>
        /// Checks the default size
        /// </summary>
        [Fact]
        public void ShouldDefaultToSmall()
        {
            var ice = new AquariusIce();
            Assert.Equal(Size.Small, ice.Size);
        }

        /// <summary>
        /// Checks the price based on the size 
        /// </summary>
        /// <param name="size">The size to check</param>
        /// <param name="price">The expected price</param>
        [Theory]
        [InlineData(Size.Small, 2.0)]
        [InlineData(Size.Medium, 2.5)]
        [InlineData(Size.Large, 3.0)]
        public void ShouldHaveTheRightPriceForSize(Size size, decimal price)
        {
            var ice = new AquariusIce()
            {
                Size = size
            };
            Assert.Equal(price, ice.Price);

        }

        /// <summary>
        /// Checks that the size is able to be set.
        /// </summary>
        /// <param name="size">The size to check.</param>
        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void ShouldBeAbleToSetSize(Size size)
        {
            var ice = new AquariusIce() { Size = size };
            Assert.Equal(size, ice.Size);
        }

        /// <summary>
        /// Checks to see that the name for the size and flavor match.
        /// </summary>
        /// <param name="size">The size to check.</param>
        /// <param name="flavor">The flavor to check.</param>
        /// <param name="name">the name to check.</param>
        [Theory]
        [InlineData(Size.Small, AquariusIceFlavor.BlueRaspberry, "Small BlueRaspberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Lemon, "Small Lemon Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Mango, "Small Mango Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Orange, "Small Orange Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Strawberry, "Small Strawberry Aquarius Ice")]
        [InlineData(Size.Small, AquariusIceFlavor.Watermellon, "Small Watermellon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.BlueRaspberry, "Medium BlueRaspberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Lemon, "Medium Lemon Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Mango, "Medium Mango Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Orange, "Medium Orange Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Strawberry, "Medium Strawberry Aquarius Ice")]
        [InlineData(Size.Medium, AquariusIceFlavor.Watermellon, "Medium Watermellon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.BlueRaspberry, "Large BlueRaspberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Lemon, "Large Lemon Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Mango, "Large Mango Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Orange, "Large Orange Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Strawberry, "Large Strawberry Aquarius Ice")]
        [InlineData(Size.Large, AquariusIceFlavor.Watermellon, "Large Watermellon Aquarius Ice")]
        public void ShouldHaveTheRightNameForSizeAndFlavor(Size size, AquariusIceFlavor flavor, string name)
        {
            var ice = new AquariusIce()
            {
                Size = size,
                Flavor = flavor
            };
            Assert.Equal(name, ice.Name);
        }

        /// <summary>
        /// Checks to see that the INotifyPropertyChanged event is correctly changed.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var ice = new AquariusIce();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(ice);
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
        public void ShouldNotifyOfPropertyChangedWhenSizeChanges(Size size, string propertyName)
        {
            var ice = new AquariusIce();

            ///A quick hack to avoid not changing size when setting to the default size.
            if (size == Size.Small) { ice.Size = Size.Large; }
            Assert.PropertyChanged(ice, propertyName, () =>
            {
                ice.Size = size;
            });
        }


    }
}
