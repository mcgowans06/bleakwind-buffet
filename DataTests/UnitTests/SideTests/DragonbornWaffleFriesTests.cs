/*
 * Author: Zachery Brunner
 * Modified by: Samuel McGowan
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(dwf);
        }

        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dwf);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, dwf.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = Size.Large;
            Assert.Equal(Size.Large, dwf.Size);
            dwf.Size = Size.Medium;
            Assert.Equal(Size.Medium, dwf.Size);
            dwf.Size = Size.Small;
            Assert.Equal(Size.Small, dwf.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            Assert.Empty(dwf.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Assert.Equal(price, dwf.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Assert.Equal(calories, dwf.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dwf = new DragonbornWaffleFries();
            dwf.Size = size;
            Assert.Equal(name, dwf.ToString());
        }

        [Fact]
        public void ChangingSizeNotifiesSizePriceAndCalorieProperties()
        {
            var dwf = new DragonbornWaffleFries();
            dwf.Size = Size.Large;

            Assert.PropertyChanged(dwf, "Size", () =>
            {
                dwf.Size = Size.Small;
            });

            Assert.PropertyChanged(dwf, "Size", () =>
            {
                dwf.Size = Size.Medium;
            });

            Assert.PropertyChanged(dwf, "Size", () =>
            {
                dwf.Size = Size.Large;
            });

            Assert.PropertyChanged(dwf, "Price", () =>
            {
                dwf.Size = Size.Small;
            });

            Assert.PropertyChanged(dwf, "Price", () =>
            {
                dwf.Size = Size.Medium;
            });

            Assert.PropertyChanged(dwf, "Price", () =>
            {
                dwf.Size = Size.Large;
            });

            Assert.PropertyChanged(dwf, "Name", () =>
            {
                dwf.Size = Size.Small;
            });

            Assert.PropertyChanged(dwf, "Name", () =>
            {
                dwf.Size = Size.Medium;
            });

            Assert.PropertyChanged(dwf, "Name", () =>
            {
                dwf.Size = Size.Large;
            });

            Assert.PropertyChanged(dwf, "Calories", () =>
            {
                dwf.Size = Size.Small;
            });

            Assert.PropertyChanged(dwf, "Calories", () =>
            {
                dwf.Size = Size.Medium;
            });

            Assert.PropertyChanged(dwf, "Calories", () =>
            {
                dwf.Size = Size.Large;
            });
        }

        [Fact]
        public void NamePropertyGetsToString()
        {
            DragonbornWaffleFries bb = new DragonbornWaffleFries();
            Assert.Equal(bb.ToString(), bb.Name);
        }
    }
}