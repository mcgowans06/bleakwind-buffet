/*
* Author: Samuel McGowan
* Class name: DragonbornWaffleFries.cs
* Purpose: To hold information for the Dragonborn Waffle Fries
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
	class DragonbornWaffleFries
	{
		// Properties
		public double Price { get; set; } = 0.42;
		public uint Calories { get; set; } = 77;
		public List<string> SpecialInstructions { get; set; }

		private Size _size = Size.Small;

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
					Price = 0.42;
					Calories = 77;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 0.76;
					Calories = 89;
				}
				else
				{
					Price = 0.96;
					Calories = 100;
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Dragonborn Waffle Fries");
		}
	}
}
