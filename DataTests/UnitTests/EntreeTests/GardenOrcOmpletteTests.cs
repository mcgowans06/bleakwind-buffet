﻿/*
 * Author: Zachery Brunner
 * Modified by: Samuel McGowan
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(goo);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(goo);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = false;
            Assert.False(goo.Broccoli);
            goo.Broccoli = true;
            Assert.True(goo.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Mushrooms = false;
            Assert.False(goo.Mushrooms);
            goo.Mushrooms = true;
            Assert.True(goo.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Tomato = false;
            Assert.False(goo.Tomato);
            goo.Tomato = true;
            Assert.True(goo.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Cheddar = false;
            Assert.False(goo.Cheddar);
            goo.Cheddar = true;
            Assert.True(goo.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal(4.57, goo.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            uint x = 404;
            Assert.Equal(x, goo.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            goo.Broccoli = includeBroccoli;
            if (!includeBroccoli) Assert.Contains("Hold broccoli", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);

            goo = new GardenOrcOmelette();
            goo.Mushrooms = includeMushrooms;
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);

            goo = new GardenOrcOmelette();
            goo.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);

            goo = new GardenOrcOmelette();
            goo.Cheddar = includeCheddar;
            if (!includeCheddar) Assert.Contains("Hold cheddar", goo.SpecialInstructions);
            else Assert.Empty(goo.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette goo = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", goo.ToString());
        }
    }
}