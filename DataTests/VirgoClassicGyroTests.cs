using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for virgo classic gyro
    /// </summary>
    public class VirgoClassicGyroTests
    {
        /// <summary>
        /// Checks default ingredients
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            VirgoClassicGyro gyro = new VirgoClassicGyro();
            Assert.Equal(DonerMeat.Pork, gyro.Meat);
            Assert.True(gyro.Pita);
            Assert.True(gyro.Tomato);
            Assert.True(gyro.Onion);
            Assert.True(gyro.Lettuce);
            Assert.True(gyro.Tzatziki);
            Assert.NotEqual(DonerMeat.Lamb, gyro.Meat);
            Assert.NotEqual(DonerMeat.Chicken, gyro.Meat);
            Assert.NotEqual(DonerMeat.Beef, gyro.Meat);
            Assert.False(gyro.Peppers);
            Assert.False(gyro.WingSauce);
            Assert.False(gyro.Eggplant);
            Assert.False(gyro.MintChutney);
        }

        /// <summary>
        /// Checks the price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            VirgoClassicGyro gyro = new VirgoClassicGyro();
            Assert.Equal(5.50m, gyro.Price);
        }

        /// <summary>
        /// Checks that the calories is correct.
        /// </summary>
        /// <param name="meat">The meat ingredient.</param>
        /// <param name="pita">The pita ingredient.</param>
        /// <param name="tomato">The tomato ingredient.</param>
        /// <param name="peppers">The peppers ingredient.</param>
        /// <param name="eggplant">The eggplant ingredient.</param>
        /// <param name="onion">The onion ingredient.</param>
        /// <param name="lettuce">The lettuce ingredient.</param>
        /// <param name="tzatziki">The tzatsiki ingredient.</param>
        /// <param name="wingSauce">The wingsauce ingredient.</param>
        /// <param name="mintChutney">The mintchutney ingredient.</param>
        /// <param name="calories">The amount of calories.</param>
        [Theory]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, false, true, false, true, 516)]
        [InlineData(DonerMeat.Lamb, false, true, false, true, false, true, false, true, false, 297)]
        [InlineData(DonerMeat.Beef, false, false, false, false, false, false, false, true, true, 206)]
        [InlineData(DonerMeat.Beef, false, true, false, true, true, false, false, false, false, 288)]
        [InlineData(DonerMeat.Chicken, true, true, false, false, false, false, false, false, false, 405)]
        [InlineData(DonerMeat.Chicken, false, false, false, false, true, true, false, false, false, 197)]
        [InlineData(DonerMeat.Pork, true, true, false, false, false, false, false, true, false, 494)]
        [InlineData(DonerMeat.Pork, false, false, false, false, true, false, false, false, false, 217)]
        public void CaloriesShouldBeCorrect(DonerMeat meat, bool pita, bool tomato, bool peppers,
                                            bool eggplant, bool onion, bool lettuce, bool tzatziki,
                                            bool wingSauce, bool mintChutney, uint calories)
        {
            VirgoClassicGyro gyro = new()
            {
                Meat = meat,
                Pita = pita,
                Tomato = tomato,
                Peppers = peppers,
                Eggplant = eggplant,
                Onion = onion,
                Lettuce = lettuce,
                Tzatziki = tzatziki,
                WingSauce = wingSauce,
                MintChutney = mintChutney
            };
            Assert.Equal(gyro.Calories, calories);
        }

        /// <summary>
        /// Checks that the special instructions are correct.
        /// </summary>
        /// <param name="meat">The meat ingredient.</param>
        /// <param name="pita">The pita ingredient.</param>
        /// <param name="tomato">The tomato ingredient.</param>
        /// <param name="peppers">The peppers ingredient.</param>
        /// <param name="eggplant">The eggplant ingredient.</param>
        /// <param name="onion">The onion ingredient.</param>
        /// <param name="lettuce">The lettuce ingredient.</param>
        /// <param name="tzatziki">The tzatsiki ingredient.</param>
        /// <param name="wingSauce">The wingsauce ingredient.</param>
        /// <param name="mintChutney">The mintchutney ingredient.</param>
        /// <param name="expected">The string customizing the item.</param>
        [Theory]
        [InlineData(DonerMeat.Beef, true, true, false, false, true, true, true, false, false, new string[] { "Use beef" })]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, true, false, false, new string[] { "Use lamb" })]
        [InlineData(DonerMeat.Chicken, true, true, false, false, true, true, true, false, false, new string[] { "Use chicken" })]
        [InlineData(DonerMeat.Pork, false, true, false, false, true, true, true, false, false, new string[] { "Hold pita" })]
        [InlineData(DonerMeat.Pork, true, false, false, false, true, true, true, false, false, new string[] { "Hold tomato" })]
        [InlineData(DonerMeat.Pork, true, true, false, false, false, true, true, false, false, new string[] { "Hold onion" })]
        [InlineData(DonerMeat.Pork, true, true, false, false, true, false, true, false, false, new string[] { "Hold lettuce" })]
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, false, false, false, new string[] { "Hold tzatziki" })]
        [InlineData(DonerMeat.Pork, true, true, true, false, true, true, true, false, false, new string[] { "Add peppers" })]
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, true, false, false, new string[] { "Add eggplant" })]
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, true, false, new string[] { "Add wing sauce" })]
        [InlineData(DonerMeat.Pork, true, true, false, false, true, true, true, false, true, new string[] { "Add mint chutney" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers,
                                            bool eggplant, bool onion, bool lettuce, bool tzatziki,
                                            bool wingSauce, bool mintChutney, string[] expected)
        {
            VirgoClassicGyro gyro = new()
            {
                Meat = meat,
                Pita = pita,
                Tomato = tomato,
                Peppers = peppers,
                Eggplant = eggplant,
                Onion = onion,
                Lettuce = lettuce,
                Tzatziki = tzatziki,
                WingSauce = wingSauce,
                MintChutney = mintChutney
            };
            Assert.Equal(expected, gyro.SpecialInstructions);
        }

        /// <summary>
        /// Checks to see if the To String override method is correct.
        /// </summary>
        [Fact]
        public void ToStringShouldReturnExpectedValue()
        {
            var gyro = new VirgoClassicGyro();
            Assert.Equal("Virgo Classic Gyro", gyro.ToString());
        }
    }
}
