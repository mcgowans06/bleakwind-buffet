/*
* Author: Samuel McGowan
* Class name: AretinoAppleJuice.cs
* Purpose: To hold information for the Aretino Apple Juice
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	class AretinoAppleJuice
	{
		// Properties
		public double Price { get; set; } = 0.62;
		public uint Calories { get; set; } = 44;
		public List<string> SpecialInstructions { get; set; }

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
					Price = 0.62;
					Calories = 44;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 0.87;
					Calories = 88;
				}
				else
				{
					Price = 1.01;
					Calories = 132;
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
					SpecialInstructions.Add("Add ice");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Aretino Apple Juice");
		}
	}
}
