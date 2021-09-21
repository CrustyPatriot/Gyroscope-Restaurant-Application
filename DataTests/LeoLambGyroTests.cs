using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the leo lamb gyro
    /// </summary>
    public class LeoLambGyroTests
    {
        /// <summary>
        /// Checks default ingredients
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            LeoLambGyro gyro = new();
            Assert.Equal(DonerMeat.Lamb, gyro.Meat);
            Assert.True(gyro.Pita);
            Assert.True(gyro.Tomato);
            Assert.True(gyro.Onion);
            Assert.True(gyro.Eggplant);
            Assert.True(gyro.Lettuce);
            Assert.True(gyro.MintChutney);
            Assert.NotEqual(DonerMeat.Pork, gyro.Meat);
            Assert.NotEqual(DonerMeat.Chicken, gyro.Meat);
            Assert.NotEqual(DonerMeat.Beef, gyro.Meat);
            Assert.False(gyro.Peppers);
            Assert.False(gyro.WingSauce);
            Assert.False(gyro.Tzatziki);
        }

        /// <summary>
        /// Checks the price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            LeoLambGyro gyro = new();
            Assert.Equal(5.75m, gyro.Price);
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
            LeoLambGyro gyro = new()
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
        [InlineData(DonerMeat.Beef, true, true, false, true, true, true, false, false, true, new string[] { "Use beef" })]
        [InlineData(DonerMeat.Pork, true, true, false, true, true, true, false, false, true, new string[] { "Use pork" })]
        [InlineData(DonerMeat.Chicken, true, true, false, true, true, true, false, false, true, new string[] { "Use chicken" })]
        [InlineData(DonerMeat.Lamb, false, true, false, true, true, true, false, false, true, new string[] { "Hold pita" })]
        [InlineData(DonerMeat.Lamb, true, false, false, true, true, true, false, false, true, new string[] { "Hold tomato" })]
        [InlineData(DonerMeat.Lamb, true, true, false, false, true, true, false, false, true, new string[] { "Hold eggplant" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, false, true, false, false, true, new string[] { "Hold onion" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, false, false, false, true, new string[] { "Hold lettuce" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, false, false, new string[] { "Hold mint chutney" })]
        [InlineData(DonerMeat.Lamb, true, true, true, true, true, true, false, false, true, new string[] { "Add peppers" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, true, false, true, new string[] { "Add tzatziki" })]
        [InlineData(DonerMeat.Lamb, true, true, false, true, true, true, false, true, true, new string[] { "Add wing sauce" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers,
                                            bool eggplant, bool onion, bool lettuce, bool tzatziki,
                                            bool wingSauce, bool mintChutney, string[] expected)
        {
            LeoLambGyro gyro = new()
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
    }
}
