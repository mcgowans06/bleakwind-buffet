/*
 * Author: Samuel McGowan
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 * Last Modified: 19/9/20
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
	public class OrderTests
	{
        [Fact]
        public void OrderNumberIsIncrementedWhenCreatingNewOrder()
        {
            Order order = new Order();
            uint x = 12; // Start at 12 because by the time the tests get to this fact 11 orders have already been made
            Assert.Equal(x, order.Number);
            order = new Order();
            x++;
            Assert.Equal(x, order.Number);
        }

        [Fact]
        public void AddingItemNotifiesSubtotalProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Add(aa);
            });
        }

        [Fact]
        public void AddingItemNotifiesTotalProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(aa);
            });
        }

        [Fact]
        public void AddingItemNotifiesTaxProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(aa);
            });
        }

        [Fact]
        public void AddingItemNotifiesCaloriesProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(aa);
            });
        }

        [Fact]
        public void RemovingItemNotifiesSubtotalProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                order.Remove(aa);
            });
        }

        [Fact]
        public void RemovingItemNotifiesTotalProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(aa);
            });
        }

        [Fact]
        public void RemovingItemNotifiesTaxProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(aa);
            });
        }

        [Fact]
        public void RemovingItemNotifiesCaloriesProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(aa);
            });
        }

        [Fact]
        public void ChangingItemInOrderCaloriesNotifiesCaloriesProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                ((Drink)order.OrderItems[0]).Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingItemInOrderPriceNotifiesTotalProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Total", () =>
            {
                ((Drink)order.OrderItems[0]).Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingItemInOrderPriceNotifiesSubtotalProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Subtotal", () =>
            {
                ((Drink)order.OrderItems[0]).Size = Size.Large;
            });
        }

        [Fact]
        public void ChangingItemInOrderPriceNotifiesTaxProperty()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);

            Assert.PropertyChanged(order, "Tax", () =>
            {
                ((Drink)order.OrderItems[0]).Size = Size.Large;
            });
        }

        [Fact]
        public void ClearingOrderClearsList()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(aa);
            order.Add(bb);
            order.Clear();

            Assert.DoesNotContain<IOrderItem>(aa, order);
            Assert.DoesNotContain<IOrderItem>(bb, order);
        }

        [Fact]
        public void RemovingFromOrderRemovesItem()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(aa);
            order.Add(bb);

            order.Remove(aa);
            Assert.DoesNotContain<IOrderItem>(aa, order);

            order.Remove(bb);
            Assert.DoesNotContain<IOrderItem>(bb, order);
        }

        [Fact]
        public void AddingToOrderAddsItem()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            order.Add(aa);
            Assert.Contains<IOrderItem>(aa, order);
        }

        [Fact]
        public void NothingHappensIfItemToRemoveIsNotInList()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            order.Remove(aa);
            Assert.Contains<IOrderItem>(bb, order);
        }

        [Fact]
        public void CountReturnsProperCountOfItemsInList()
        {
            Order order = new Order();
            AretinoAppleJuice aa = new AretinoAppleJuice();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            order.Add(aa);
            Assert.Equal(2, order.Count);
        }

        [Fact]
        public void SetCorrectSalesTaxRate()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
            order.SalesTaxRate = .5;
            Assert.Equal(.5, order.SalesTaxRate);
        }

        [Fact]
        public void GetsCorrectSalesTaxRate()
        {
            Order order = new Order();
            Assert.Equal(.12, order.SalesTaxRate);
        }

        [Fact]
        public void GetsCorrectSubtotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            order.Add(dd);
            Assert.Equal(13.64, order.Subtotal);
        }

        [Fact]
        public void GetsCorrectTax()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            order.Add(dd);
            Assert.Equal(1.64, order.Tax);
        }

        [Fact]
        public void GetsCorrectTotal()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            order.Add(dd);
            Assert.Equal(15.28, order.Total);
        }

        [Fact]
        public void GetsCorrectCalories()
        {
            Order order = new Order();
            BriarheartBurger bb = new BriarheartBurger();
            order.Add(bb);
            DoubleDraugr dd = new DoubleDraugr();
            order.Add(dd);
            Assert.Equal(dd.Calories + bb.Calories, order.Calories);
        }
    }
}
