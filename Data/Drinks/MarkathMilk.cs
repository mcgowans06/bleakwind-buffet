/*
* Author: Samuel McGowan
* Class name: MarkathMilk.cs
* Purpose: To hold information for the Markath Milk
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	class MarkathMilk
	{
		// Properties
		public double Price { get; set; } = 1.05;
		public uint Calories { get; set; } = 56;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = false;
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
					Price = 1.05;
					Calories = 56;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 1.11;
					Calories = 72;
				}
				else
				{
					Price = 1.22;
					Calories = 93;
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

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Markath Milk");
		}
	}
}
