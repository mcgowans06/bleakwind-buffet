﻿/*
 * Author: Zachery Brunner
 * Modified by: Samuel McGowan
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<IOrderItem>(tt);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(tt);
        }

        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = false;
            Assert.False(tt.Bun);
            tt.Bun = true;
            Assert.True(tt.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Ketchup = false;
            Assert.False(tt.Ketchup);
            tt.Ketchup = true;
            Assert.True(tt.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mustard = false;
            Assert.False(tt.Mustard);
            tt.Mustard = true;
            Assert.True(tt.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Pickle = false;
            Assert.False(tt.Pickle);
            tt.Pickle = true;
            Assert.True(tt.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Cheese = false;
            Assert.False(tt.Cheese);
            tt.Cheese = true;
            Assert.True(tt.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Tomato = false;
            Assert.False(tt.Tomato);
            tt.Tomato = true;
            Assert.True(tt.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Lettuce = false;
            Assert.False(tt.Lettuce);
            tt.Lettuce = true;
            Assert.True(tt.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Mayo = false;
            Assert.False(tt.Mayo);
            tt.Mayo = true;
            Assert.True(tt.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bacon = false;
            Assert.False(tt.Bacon);
            tt.Bacon = true;
            Assert.True(tt.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Egg = false;
            Assert.False(tt.Egg);
            tt.Egg = true;
            Assert.True(tt.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(8.32, tt.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple tt = new ThalmorTriple();
            uint x = 943;
            Assert.Equal(x, tt.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple tt = new ThalmorTriple();
            tt.Bun = includeBun;
            if (!includeBun) Assert.Contains("Hold bun", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Ketchup = includeKetchup;
            if (!includeKetchup) Assert.Contains("Hold ketchup", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Mustard = includeMustard;
            if (!includeMustard) Assert.Contains("Hold mustard", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Pickle = includePickle;
            if (!includePickle) Assert.Contains("Hold pickle", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Cheese = includeCheese;
            if (!includeCheese) Assert.Contains("Hold cheese", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Tomato = includeTomato;
            if (!includeTomato) Assert.Contains("Hold tomato", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Lettuce = includeLettuce;
            if (!includeLettuce) Assert.Contains("Hold lettuce", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Mayo = includeMayo;
            if (!includeMayo) Assert.Contains("Hold mayo", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Bacon = includeBacon;
            if (!includeBacon) Assert.Contains("Hold bacon", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);

            tt = new ThalmorTriple();
            tt.Egg = includeEgg;
            if (!includeEgg) Assert.Contains("Hold egg", tt.SpecialInstructions);
            else Assert.Empty(tt.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", tt.ToString());
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = false;
            });

            Assert.PropertyChanged(tt, "Bun", () =>
            {
                tt.Bun = true;
            });
        }

        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = false;
            });

            Assert.PropertyChanged(tt, "Ketchup", () =>
            {
                tt.Ketchup = true;
            });
        }

        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = false;
            });

            Assert.PropertyChanged(tt, "Mustard", () =>
            {
                tt.Mustard = true;
            });
        }

        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = false;
            });

            Assert.PropertyChanged(tt, "Pickle", () =>
            {
                tt.Pickle = true;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = false;
            });

            Assert.PropertyChanged(tt, "Cheese", () =>
            {
                tt.Cheese = true;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = false;
            });

            Assert.PropertyChanged(tt, "Tomato", () =>
            {
                tt.Tomato = true;
            });
        }

        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = false;
            });

            Assert.PropertyChanged(tt, "Lettuce", () =>
            {
                tt.Lettuce = true;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = false;
            });

            Assert.PropertyChanged(tt, "Mayo", () =>
            {
                tt.Mayo = true;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = false;
            });

            Assert.PropertyChanged(tt, "Bacon", () =>
            {
                tt.Bacon = true;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            ThalmorTriple tt = new ThalmorTriple();

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = false;
            });

            Assert.PropertyChanged(tt, "Egg", () =>
            {
                tt.Egg = true;
            });
        }

        [Fact]
        public void NamePropertyGetsToString()
        {
            ThalmorTriple tt = new ThalmorTriple();
            Assert.Equal(tt.ToString(), tt.Name);
        }
    }
}