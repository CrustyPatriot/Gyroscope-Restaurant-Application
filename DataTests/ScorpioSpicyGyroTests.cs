using System;
using Xunit;
using GyroScope.Data.Enums;
using GyroScope.Data.Treats;
using GyroScope.Data.Entrees;

namespace GyroScope.DataTests
{
    /// <summary>
    /// Unit tests for the scorpio spicy gyro.
    /// </summary>
    public class ScorpioSpicyGyroTests
    {
        /// <summary>
        /// Checks default ingredients
        /// </summary>
        [Fact]
        public void DefaultIngredientsShouldBeCorrect()
        {
            ScorpioSpicyGyro gyro = new();
            Assert.Equal(DonerMeat.Chicken, gyro.Meat);
            Assert.True(gyro.Pita);
            Assert.True(gyro.Peppers);
            Assert.True(gyro.Onion);            
            Assert.True(gyro.Lettuce);
            Assert.True(gyro.WingSauce);
            Assert.NotEqual(DonerMeat.Pork, gyro.Meat);
            Assert.NotEqual(DonerMeat.Lamb, gyro.Meat);
            Assert.NotEqual(DonerMeat.Beef, gyro.Meat);
            Assert.False(gyro.Tomato);
            Assert.False(gyro.Eggplant);          
            Assert.False(gyro.Tzatziki);
            Assert.False(gyro.MintChutney);
        }

        /// <summary>
        /// Checks the price.
        /// </summary>
        [Fact]
        public void PriceShouldBeCorrect()
        {
            ScorpioSpicyGyro gyro = new();
            Assert.Equal(6.20m, gyro.Price);
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
        /// <param name="Calories">The amount of calories.</param>
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
            ScorpioSpicyGyro gyro = new()
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
        [InlineData(DonerMeat.Beef, true, false, true, false, true, true, false, true, false, new string[] { "Use beef" })]
        [InlineData(DonerMeat.Pork, true, false, true, false, true, true, false, true, false, new string[] { "Use pork" })]
        [InlineData(DonerMeat.Lamb, true, false, true, false, true, true, false, true, false, new string[] { "Use lamb" })]
        [InlineData(DonerMeat.Chicken, false, false, true, false, true, true, false, true, false, new string[] { "Hold pita" })]
        [InlineData(DonerMeat.Chicken, true, false, false, false, true, true, false, true, false, new string[] { "Hold peppers" })]
        [InlineData(DonerMeat.Chicken, true, false, true, false, false, true, false, true, false, new string[] { "Hold onion" })]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, false, false, true, false, new string[] { "Hold lettuce" })]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, false, false, new string[] { "Hold wing sauce" })]
        [InlineData(DonerMeat.Chicken, true, true, true, false, true, true, false, true, false, new string[] { "Add tomato" })]
        [InlineData(DonerMeat.Chicken, true, false, true, true, true, true, false, true, false, new string[] { "Add eggplant" })]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, true, true, false, new string[] { "Add tzatziki" })]
        [InlineData(DonerMeat.Chicken, true, false, true, false, true, true, false, true, true, new string[] { "Add mint chutney" })]
        public void SpecialInstructionsShouldReflectIngredients(DonerMeat meat, bool pita, bool tomato, bool peppers,
                                            bool eggplant, bool onion, bool lettuce, bool tzatziki,
                                            bool wingSauce, bool mintChutney, string[] expected)
        {
            ScorpioSpicyGyro gyro = new()
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
