/*
 * Author: Samuel McGowan
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
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
	public class MenuTests
	{ 
		[Fact]
		public void ShouldContainAllEntrees()
		{
			Assert.Collection<IOrderItem>(Menu.Entrees(),
												x => Assert.IsType<BriarheartBurger>(x),
												x => Assert.IsType<DoubleDraugr>(x),
												x => Assert.IsType<GardenOrcOmelette>(x),
												x => Assert.IsType<PhillyPoacher>(x),
												x => Assert.IsType<SmokehouseSkeleton>(x),
												x => Assert.IsType<ThalmorTriple>(x),
												x => Assert.IsType<ThugsTBone>(x));
		}

		[Fact]
		public void ShouldContainAllSides()
		{
			Assert.Collection<IOrderItem>(Menu.Sides(),
												x => Assert.Equal("Small Dragonborn Waffle Fries", x.ToString()),
												x => Assert.Equal("Medium Dragonborn Waffle Fries", x.ToString()),
												x => Assert.Equal("Large Dragonborn Waffle Fries", x.ToString()),
												x => Assert.Equal("Small Fried Miraak", x.ToString()),
												x => Assert.Equal("Medium Fried Miraak", x.ToString()),
												x => Assert.Equal("Large Fried Miraak", x.ToString()),
												x => Assert.Equal("Small Mad Otar Grits", x.ToString()),
												x => Assert.Equal("Medium Mad Otar Grits", x.ToString()),
												x => Assert.Equal("Large Mad Otar Grits", x.ToString()),
												x => Assert.Equal("Small Vokun Salad", x.ToString()),
												x => Assert.Equal("Medium Vokun Salad", x.ToString()),
												x => Assert.Equal("Large Vokun Salad", x.ToString()));
		}

		[Fact]
		public void ShouldContainAllDrinks()
		{
			Assert.Collection<IOrderItem>(Menu.Drinks(),
												x => Assert.Equal("Small Aretino Apple Juice", x.ToString()),
												x => Assert.Equal("Medium Aretino Apple Juice", x.ToString()),
												x => Assert.Equal("Large Aretino Apple Juice", x.ToString()),
												x => Assert.Equal("Small Candlehearth Coffee", x.ToString()),
												x => Assert.Equal("Medium Candlehearth Coffee", x.ToString()),
												x => Assert.Equal("Large Candlehearth Coffee", x.ToString()),
												x => Assert.Equal("Small Markarth Milk", x.ToString()),
												x => Assert.Equal("Medium Markarth Milk", x.ToString()),
												x => Assert.Equal("Large Markarth Milk", x.ToString()),
												x => Assert.Equal("Small Blackberry Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Blackberry Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Blackberry Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Cherry Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Cherry Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Cherry Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Grapefruit Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Grapefruit Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Grapefruit Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Lemon Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Lemon Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Lemon Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Peach Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Peach Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Peach Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Watermelon Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Watermelon Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Watermelon Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Warrior Water", x.ToString()),
												x => Assert.Equal("Medium Warrior Water", x.ToString()),
												x => Assert.Equal("Large Warrior Water", x.ToString()));
			
		}

		[Fact]
		public void ShouldContainAllMenuItems()
		{
			Assert.Collection<IOrderItem>(Menu.FullMenu(),
												x => Assert.IsType<BriarheartBurger>(x),
												x => Assert.IsType<DoubleDraugr>(x),
												x => Assert.IsType<GardenOrcOmelette>(x),
												x => Assert.IsType<PhillyPoacher>(x),
												x => Assert.IsType<SmokehouseSkeleton>(x),
												x => Assert.IsType<ThalmorTriple>(x),
												x => Assert.IsType<ThugsTBone>(x),
												x => Assert.Equal("Small Dragonborn Waffle Fries", x.ToString()),
												x => Assert.Equal("Medium Dragonborn Waffle Fries", x.ToString()),
												x => Assert.Equal("Large Dragonborn Waffle Fries", x.ToString()),
												x => Assert.Equal("Small Fried Miraak", x.ToString()),
												x => Assert.Equal("Medium Fried Miraak", x.ToString()),
												x => Assert.Equal("Large Fried Miraak", x.ToString()),
												x => Assert.Equal("Small Mad Otar Grits", x.ToString()),
												x => Assert.Equal("Medium Mad Otar Grits", x.ToString()),
												x => Assert.Equal("Large Mad Otar Grits", x.ToString()),
												x => Assert.Equal("Small Vokun Salad", x.ToString()),
												x => Assert.Equal("Medium Vokun Salad", x.ToString()),
												x => Assert.Equal("Large Vokun Salad", x.ToString()),
												x => Assert.Equal("Small Aretino Apple Juice", x.ToString()),
												x => Assert.Equal("Medium Aretino Apple Juice", x.ToString()),
												x => Assert.Equal("Large Aretino Apple Juice", x.ToString()),
												x => Assert.Equal("Small Candlehearth Coffee", x.ToString()),
												x => Assert.Equal("Medium Candlehearth Coffee", x.ToString()),
												x => Assert.Equal("Large Candlehearth Coffee", x.ToString()),
												x => Assert.Equal("Small Markarth Milk", x.ToString()),
												x => Assert.Equal("Medium Markarth Milk", x.ToString()),
												x => Assert.Equal("Large Markarth Milk", x.ToString()),
												x => Assert.Equal("Small Blackberry Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Blackberry Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Blackberry Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Cherry Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Cherry Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Cherry Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Grapefruit Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Grapefruit Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Grapefruit Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Lemon Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Lemon Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Lemon Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Peach Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Peach Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Peach Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Watermelon Sailor Soda", x.ToString()),
												x => Assert.Equal("Medium Watermelon Sailor Soda", x.ToString()),
												x => Assert.Equal("Large Watermelon Sailor Soda", x.ToString()),
												x => Assert.Equal("Small Warrior Water", x.ToString()),
												x => Assert.Equal("Medium Warrior Water", x.ToString()),
												x => Assert.Equal("Large Warrior Water", x.ToString()));

		}

		[Fact]
		public void AllMenuItemsImplementsINotifyPropertyChanged()
		{
			Assert.Collection<IOrderItem>(Menu.FullMenu(),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x),
												x => Assert.IsAssignableFrom<INotifyPropertyChanged>(x)); 

		}
	}
}
