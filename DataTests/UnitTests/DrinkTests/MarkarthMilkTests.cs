﻿/*
 * Author: Zachery Brunner
 * Modified by: Samuel McGowan
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<IOrderItem>(mm);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(mm);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(Size.Small, mm.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = true;
            Assert.True(mm.Ice);
            mm.Ice = false;
            Assert.False(mm.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = Size.Large;
            Assert.Equal(Size.Large, mm.Size);
            mm.Size = Size.Medium;
            Assert.Equal(Size.Medium, mm.Size);
            mm.Size = Size.Small;
            Assert.Equal(Size.Small, mm.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(price, mm.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(cal, mm.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", mm.SpecialInstructions);
            else Assert.Empty(mm.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk mm = new MarkarthMilk();
            mm.Size = size;
            Assert.Equal(name, mm.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var mm = new MarkarthMilk();

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = true;
            });

            Assert.PropertyChanged(mm, "Ice", () =>
            {
                mm.Ice = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizePriceAndCalorieProperties()
        {
            var mm = new MarkarthMilk();
            mm.Size = Size.Large;

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Small;
            });

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Size", () =>
            {
                mm.Size = Size.Large;
            });

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Small;
            });

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Price", () =>
            {
                mm.Size = Size.Large;
            });

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Small;
            });

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Calories", () =>
            {
                mm.Size = Size.Large;
            });

            Assert.PropertyChanged(mm, "Name", () =>
            {
                mm.Size = Size.Small;
            });

            Assert.PropertyChanged(mm, "Name", () =>
            {
                mm.Size = Size.Medium;
            });

            Assert.PropertyChanged(mm, "Name", () =>
            {
                mm.Size = Size.Large;
            });

        }

        [Fact]
        public void NamePropertyGetsToString()
        {
            MarkarthMilk mm = new MarkarthMilk();
            Assert.Equal(mm.ToString(), mm.Name);
        }
    }
}