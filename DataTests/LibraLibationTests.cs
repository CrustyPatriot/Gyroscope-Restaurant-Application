using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Drinks;
using System.ComponentModel;

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
        /// <param name="calories">The calories to check.</param>
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

        /// <summary>
        /// Checks to see that the INotifyPropertyChanged event is correctly changed.
        /// </summary>
        [Fact]
        public void ShouldImplementINotifyPropertyChanged()
        {
            var drink = new LibraLibation();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(drink);
        }

        /// <summary>
        /// Checks to see if the INotifyPropertyChanged event changes the properties.
        /// </summary>
        /// <param name="flavor">The size to be changed.</param>
        /// <param name="propertyName">The name of the property to be changed.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Orangeade, "Name")]
        [InlineData(LibraLibationFlavor.Orangeade, "Calories")]
        [InlineData(LibraLibationFlavor.SourCherry, "Name")]
        [InlineData(LibraLibationFlavor.SourCherry, "Calories")]
        [InlineData(LibraLibationFlavor.Biral, "Name")]
        [InlineData(LibraLibationFlavor.Biral, "Calories")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Name")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "Calories")]
        public void ShouldNotifyOfPropertyChangedWhenFlavorChanges(LibraLibationFlavor flavor, string propertyName)
        {
            var drink = new LibraLibation();

            ///A quick hack to avoid not changing flavor when setting to the default flavor.
            if (flavor == LibraLibationFlavor.Orangeade) { drink.Flavor = LibraLibationFlavor.SourCherry; }
            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Flavor = flavor;
            });
        }

        /// <summary>
        /// Checks to see if the INotifyPropertyChanged event changes the properties.
        /// </summary>
        /// <param name="sparkling">The sparkling to be changed.</param>
        /// <param name="propertyName">The name of the property to be changed.</param>
        [Theory]
        [InlineData(true, "Name")]
        [InlineData(false, "Name")]
        public void ShouldNotifyOfPropertyChangedWhenSparklingChanges(bool sparkling, string propertyName)
        {
            var drink = new LibraLibation();

            ///A quick hack to avoid not changing flavor when setting to the default flavor.
            if (sparkling) { sparkling = false; }
            Assert.PropertyChanged(drink, propertyName, () =>
            {
                drink.Sparkling = sparkling;
            });
        } 

        /// <summary>
        /// Checks to see if the to string override method is correct.
        /// </summary>
        /// <param name="flavor">The flavor to check.</param>
        /// <param name="name">The name to check.</param>
        [Theory]
        [InlineData(LibraLibationFlavor.Orangeade, "Orangeade Libra Libation")]
        [InlineData(LibraLibationFlavor.SourCherry, "SourCherry Libra Libation")]
        [InlineData(LibraLibationFlavor.Biral, "Biral Libra Libation")]
        [InlineData(LibraLibationFlavor.PinkLemonada, "PinkLemonada Libra Libation")]
        public void ToStringShouldReturnExpectedValue(LibraLibationFlavor flavor, string name)
        {
            var drink = new LibraLibation()
            {
                Flavor = flavor
            };
            Assert.Equal(name, drink.ToString());
        }
    }
}
