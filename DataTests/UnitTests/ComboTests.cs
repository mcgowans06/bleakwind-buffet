/*
 * Author: Samuel McGowan
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
 * Last Modified: 10/9/20
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests
{
	public class ComboTests
	{
        [Fact]
        public void AddingDrinkToOrderNotifiesDrinkProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = aa;
            });
        }

        [Fact]
        public void AddingDrinkToOrderNotifiesPriceProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink = aa;
            });
        }

        [Fact]
        public void AddingDrinkToOrderNotifiesCaloriesProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink = aa;
            });
        }

        [Fact]
        public void AddingDrinkToOrderNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Drink = aa;
            });
        }

        [Fact]
        public void AddingEntreeToOrderNotifiesEntreeProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = bb;
            });
        }

        [Fact]
        public void AddingEntreeToOrderNotifiesPriceProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Entree = bb;
            });
        }

        [Fact]
        public void AddingEntreeToOrderNotifiesCaloriesProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Entree = bb;
            });
        }

        [Fact]
        public void AddingEntreeToOrderNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Entree = bb;
            });
        }

        [Fact]
        public void AddingSideToOrderNotifiesSideProperty()
        {
            Combo combo = new Combo();
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = vs;
            });
        }

        [Fact]
        public void AddingSideToOrderNotifiesPriceProperty()
        {
            Combo combo = new Combo();
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side = vs;
            });
        }

        [Fact]
        public void AddingSideToOrderNotifiesCaloriesProperty()
        {
            Combo combo = new Combo();
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side = vs;
            });
        }

        [Fact]
        public void AddingSideToOrderNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo();
            VokunSalad vs = new VokunSalad();

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                combo.Side = vs;
            });
        }

        [Fact]
        public void ChangingPriceNotifiesPriceProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            combo.Drink = aa;
            combo.Side = vs;

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Side.Size = Size.Large;
            });

            Assert.PropertyChanged(combo, "Price", () =>
            {
                combo.Drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingCaloriesNotifiesCaloriesProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            VokunSalad vs = new VokunSalad();
            combo.Drink = aa;
            combo.Side = vs;

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Side.Size = Size.Large;
            });

            Assert.PropertyChanged(combo, "Calories", () =>
            {
                combo.Drink.Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingSpecialInstructionsNotifiesSpecialInstructionsProperty()
        {
            Combo combo = new Combo();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            combo.Drink = aa;
            combo.Entree = bb;

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                ((AretinoAppleJuice)combo.Drink).Ice = true;
            });

            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                ((BriarheartBurger)combo.Entree).Bun = false;
            });
        }

        [Fact]
        public void GetsCorrectCalories()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            combo.Entree = bb;
            AretinoAppleJuice aa = new AretinoAppleJuice();
            combo.Drink = aa;
            VokunSalad vs = new VokunSalad();
            combo.Side = vs;
            Assert.Equal(bb.Calories+aa.Calories+vs.Calories, combo.Calories);
        }

        [Fact]
        public void GetsCorrectPrices()
        {
            Combo combo = new Combo();
            BriarheartBurger bb = new BriarheartBurger();
            combo.Entree = bb;
            AretinoAppleJuice aa = new AretinoAppleJuice();
            combo.Drink = aa;
            VokunSalad vs = new VokunSalad();
            combo.Side = vs;
            Assert.Equal(bb.Price + aa.Price + vs.Price, combo.Price);
        }
    }
}
