﻿/*
 * Author: Zachery Brunner
 * Modified by: Samuel McGowan
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(cof);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(cof);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.False(cof.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            Assert.Equal(Size.Small, cof.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = true;
            Assert.True(cof.Ice);
            cof.Ice = false;
            Assert.False(cof.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Decaf = true;
            Assert.True(cof.Decaf);
            cof.Decaf = false;
            Assert.False(cof.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.RoomForCream = true;
            Assert.True(cof.RoomForCream);
            cof.RoomForCream = false;
            Assert.False(cof.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = Size.Large;
            Assert.Equal(Size.Large, cof.Size);
            cof.Size = Size.Medium;
            Assert.Equal(Size.Medium, cof.Size);
            cof.Size = Size.Small;
            Assert.Equal(Size.Small, cof.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(price, cof.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Size = size;
            Assert.Equal(cal, cof.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", cof.SpecialInstructions);
            else Assert.Empty(cof.SpecialInstructions);

            cof = new CandlehearthCoffee();
            cof.RoomForCream = includeCream;
            if (includeCream) Assert.Contains("Add cream", cof.SpecialInstructions);
            else Assert.Empty(cof.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee cof = new CandlehearthCoffee();
            cof.Decaf = decaf;
            cof.Size = size;
            Assert.Equal(name, cof.ToString());
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var cc = new CandlehearthCoffee();

            Assert.PropertyChanged(cc, "Ice", () =>
            {
                cc.Ice = true;
            });

            Assert.PropertyChanged(cc, "Ice", () =>
            {
                cc.Ice = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            var cc = new CandlehearthCoffee();

            Assert.PropertyChanged(cc, "RoomForCream", () =>
            {
                cc.RoomForCream = true;
            });

            Assert.PropertyChanged(cc, "RoomForCream", () =>
            {
                cc.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizePriceAndCalorieProperties()
        {
            var cc = new CandlehearthCoffee();
            cc.Size = Size.Large;

            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Small;
            });

            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Medium;
            });

            Assert.PropertyChanged(cc, "Size", () =>
            {
                cc.Size = Size.Large;
            });

            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Small;
            });

            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Medium;
            });

            Assert.PropertyChanged(cc, "Price", () =>
            {
                cc.Size = Size.Large;
            });

            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Small;
            });

            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Medium;
            });

            Assert.PropertyChanged(cc, "Calories", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesNameProperty()
        {
            var cc = new CandlehearthCoffee();
            cc.Size = Size.Large;

            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Size = Size.Small;
            });

            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Size = Size.Medium;
            });

            Assert.PropertyChanged(cc, "Name", () =>
            {
                cc.Size = Size.Large;
            });
        }

        [Fact]
        public void NamePropertyGetsToString()
        {
            CandlehearthCoffee cc = new CandlehearthCoffee();
            Assert.Equal(cc.ToString(), cc.Name);
        }
    }
}
