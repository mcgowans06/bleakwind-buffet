/*
 * Author: Samuel McGowan
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<IOrderItem>(ww);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater ww = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(ww);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.True(ww.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater ww = new WarriorWater();
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = true;
            Assert.True(ww.Ice);
            ww.Ice = false;
            Assert.False(ww.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater ww = new WarriorWater();
            ww.Lemon = true;
            Assert.True(ww.Lemon);
            ww.Lemon = false;
            Assert.False(ww.Lemon);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            WarriorWater ww = new WarriorWater();
            Assert.Equal(0, ww.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            WarriorWater ww = new WarriorWater();
            uint x = 0;
            Assert.Equal(x, ww.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater ww = new WarriorWater();
            ww.Ice = includeIce;
            if (!includeIce) Assert.Contains("Hold ice", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);

            ww = new WarriorWater();
            ww.Lemon = includeLemon;
            if (includeLemon) Assert.Contains("Add lemon", ww.SpecialInstructions);
            else Assert.Empty(ww.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater ww = new WarriorWater();
            ww.Size = size;
            Assert.Equal(name, ww.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = true;
            });

            Assert.PropertyChanged(ww, "Ice", () =>
            {
                ww.Ice = false;
            });
        }

        [Fact]
        public void ChangingLemonNotifiesLemonProperty()
        {
            var ww = new WarriorWater();

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = true;
            });

            Assert.PropertyChanged(ww, "Lemon", () =>
            {
                ww.Lemon = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizePriceAndCalorieProperties()
        {
            var ww = new WarriorWater();
            ww.Size = Size.Large;

            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Small;
            });

            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Size", () =>
            {
                ww.Size = Size.Large;
            });

            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Small;
            });

            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Price", () =>
            {
                ww.Size = Size.Large;
            });

            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Small;
            });

            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Medium;
            });

            Assert.PropertyChanged(ww, "Calories", () =>
            {
                ww.Size = Size.Large;
            });
        }
    }
}
