/*
* Author: Samuel McGowan
* Class name: FriedMiraak.cs
* Purpose: To hold information for the Fried Miraak
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
	class FriedMiraak
	{
		// Properties
		public double Price { get; set; } = 1.78;
		public uint Calories { get; set; } = 151;
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
					Price = 1.78;
					Calories = 151;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 2.01;
					Calories = 236;
				}
				else
				{
					Price = 2.88;
					Calories = 306;
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Fried Miraak");
		}
	}
}
