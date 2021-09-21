using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the cancer helvah cake
    /// </summary>
    public class CancerHelvahCakeTests
    {
        /// <summary>
        /// Checks to see if the price is correct.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            CancerHelvahCake treat = new();
            Assert.Equal(3.00m, treat.Price);
        }

        /// <summary>
        /// Checks to see if the calories are correct.
        /// </summary>
        [Fact]
        public void CaloriesShouldBeCorrect()
        {
            CancerHelvahCake treat = new();
            Assert.Equal((uint)272, treat.Calories);
        }
    }
}
