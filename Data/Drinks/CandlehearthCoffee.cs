/*
* Author: Samuel McGowan
* Class name: CandlehearthCoffee.cs
* Purpose: To hold information for the Candlehearth Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Public class that represents a CandleHearthCoffee
	/// </summary>
	public class CandlehearthCoffee
	{
		// Properties
		/// <summary>
		/// The price of this drink, set to the value of a small by default
		/// </summary>
		public double Price { get; set; } = 0.75;
		/// <summary>
		/// The calories of this drink, set to the value of a small by default
		/// </summary>
		public uint Calories { get; set; } = 7;
		//Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		/// <summary>
		/// If this drink is decaf
		/// </summary>
		public Boolean Decaf { get; set; } = false;

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = false;
		private Boolean _roomForCream = false;

		/// <summary>
		/// The size of the drink. Sets the price and calories accordingly
		/// </summary>
		public Size Size
		{
			get
			{
				return (_size);
			}
			set
			{
				if (value.Equals(Size.Small))
				{
					Price = 0.75;
					Calories = 7;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 1.25;
					Calories = 10;
				}
				else
				{
					Price = 1.75;
					Calories = 20;
				}
				_size = value;
			}
		}
		/// <summary>
		/// If this drink has ice
		/// </summary>
		public Boolean Ice
		{
			get
			{
				return (_ice);
			}
			set
			{
				_ice = value;
				if (value == true)
				{
					specialInstructions.Add("Add ice");
				}
				else
				{
					specialInstructions.Remove("Add ice");
				}
			}
		}
		/// <summary>
		/// If this drink has room for cream
		/// </summary>
		public Boolean RoomForCream
		{
			get
			{
				return (_roomForCream);
			}
			set
			{
				_roomForCream = value;
				if (value == true)
				{
					specialInstructions.Add("Add cream");
				}
			}
		}

		// ToString Override
		/// <summary>
		/// Returns a description of this drink
		/// </summary>
		/// <returns>A string describing this drink</returns>
		public override string ToString()
		{
			if(Decaf == true)
			{
				return ($"{Size} Decaf Candlehearth Coffee");
			}
			else
			{
				return ($"{Size} Candlehearth Coffee");
			}
		}
	}
}
