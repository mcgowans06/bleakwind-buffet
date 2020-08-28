/*
* Author: Samuel McGowan
* Class name: VokunSalad.cs
* Purpose: To hold information for the Vokun Salad
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
	class VokunSalad
	{
		// Properties
		public double Price { get; set; } = 0.93;
		public uint Calories { get; set; } = 41;
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
					Price = 0.93;
					Calories = 41;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 1.28;
					Calories = 52;
				}
				else
				{
					Price = 1.82;
					Calories = 73;
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Vokun Salad");
		}
	}
}
