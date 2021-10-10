using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the cancer helvah cake
    /// </summary>
    public class CancerHalvaCakeTests
    {
        /// <summary>
        /// Checks to see if the price is correct.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            CancerHalvaCake treat = new();
            Assert.Equal(3.00m, treat.Price);
        }

        /// <summary>
        /// Checks to see if the calories are correct.
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            CancerHalvaCake treat = new();
            Assert.Equal((uint)272, treat.Calories);
        }

        /// <summary>
        /// Checks to see if the To String override method is correct.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            var cake = new CancerHalvaCake();
            Assert.Equal("Cancer Halva Cake", cake.ToString());
        }
    }
}
