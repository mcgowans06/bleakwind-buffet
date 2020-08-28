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
	class CandlehearthCoffee
	{
		// Properties
		public double Price { get; set; } = 0.75;
		public uint Calories { get; set; } = 7;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		public Boolean Decaf { get; set; } = false;

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = false;
		private Boolean _roomForCream = false;

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
			}
		}
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
					SpecialInstructions.Add("Add Cream");
				}
			}
		}

		// ToString Override
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
