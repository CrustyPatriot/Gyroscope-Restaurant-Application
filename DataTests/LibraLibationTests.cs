using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Drinks;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit test for the libra libation drink.
    /// </summary>
    public class LibraLibationTests
    {
        /// <summary>
        /// Checks to see if sparkling is true in default.
        /// </summary>
        [Fact]
        public void ShouldDefaultToSparkling()
        {
            LibraLibation drink = new();
            Assert.True(drink.Sparkling);
        }

        /// <summary>
        /// Checks to see if sparkling can change.
        /// </summary>
        /// <param name="sparkling">The sparkling to change.</param>
        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ShouldBeAbleToSetSparkling(bool sparkling)
        {
            LibraLibation drink = new()
            {
                Sparkling = sparkling
            };
            Assert.Equal(sparkling, drink.Sparkling);
        }

        /// <summary>
        /// Checks to see if the libra libation flavor can change.
        /// </summary>
        /// <param name="flavor">The flavor to change.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral)]
        [InlineData(LibraLibationFlavor.Orangeade)]
        [InlineData(LibraLibationFlavor.PinkLemonada)]
        [InlineData(LibraLibationFlavor.SourCherry)]
        public void ShouldBeAbleToSetFlavor(LibraLibationFlavor flavor)
        {
            LibraLibation drink = new()
            {
                Flavor = flavor
            };
            Assert.Equal(flavor, drink.Flavor);
        }

        /// <summary>
        /// Checks to see if the price is correct for flavor.
        /// </summary>
        /// <param name="flavor">The flavor to check.</param>
        /// <param name="price">The price to check.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Orangeade, 1.00)]
        [InlineData(LibraLibationFlavor.SourCherry, 1.00)]
        [InlineData(LibraLibationFlavor.Biral, 1.00)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 1.00)]
        public void PriceShouldBeCorrectForFlavor(LibraLibationFlavor flavor, decimal price)
        {
            LibraLibation drink = new()
            {
                Flavor = flavor
            };
            Assert.Equal(price, drink.Price);
            drink.Sparkling = false;
            Assert.Equal(price, drink.Price);
        }

        /// <summary>
        /// Checks to see if the calories is correct for flavor.
        /// </summary>
        /// <param name="flavor">The flavor to check.</param>
        /// <param name="price">The price to check.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Orangeade, 180)]
        [InlineData(LibraLibationFlavor.SourCherry, 100)]
        [InlineData(LibraLibationFlavor.Biral, 120)]
        [InlineData(LibraLibationFlavor.PinkLemonada, 41)]
        public void CaloriesShouldBeCorrectForFlavor(LibraLibationFlavor flavor, uint calories)
        {
            LibraLibation drink = new()
            {
                Flavor = flavor
            };
            Assert.Equal(calories, drink.Calories);
            drink.Sparkling = false;
            Assert.Equal(calories, drink.Calories);
        }

        /// <summary>
        /// Checks to see if the name is correct for the flavor and sparkling.
        /// </summary>
        /// <param name="flavor">The flavor to check.</param>
        /// <param name="sparkling">The sparkling to check.</param>
        /// <param name="name">The name to check.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Biral, true, "Sparkling Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, true, "Sparkling Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, true, "Sparkling SourCherry Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, true, "Sparkling PinkLemonada Libra Libation")]
        [InlineData(LibraLibationFlavor.Biral, false, "Still Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.Orangeade, false, "Still Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, false, "Still SourCherry Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, false, "Still PinkLemonada Libra Libation")]
        public void NameShouldBeCorrectForFlavorAndSparkling(LibraLibationFlavor flavor, bool sparkling, string name)
        {
            LibraLibation drink = new()
            {
                Flavor = flavor,
                Sparkling = sparkling
            };
            Assert.Equal(name, drink.Name);
            sparkling = false;
            Assert.Equal(name, drink.Name);
        }
    }
}
