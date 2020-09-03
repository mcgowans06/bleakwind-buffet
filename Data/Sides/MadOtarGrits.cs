/*
* Author: Samuel McGowan
* Class name: MadOtarGrits.cs
* Purpose: To hold information for the Mad Otar Grits
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
	public class MadOtarGrits
	{
		// Properties
		public double Price { get; set; } = 1.22;
		public uint Calories { get; set; } = 105;
		public List<string> SpecialInstructions
		{
			get => new List<string>();
		}

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
					Price = 1.22;
					Calories = 105;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 1.58;
					Calories = 142;
				}
				else
				{
					Price = 1.93;
					Calories = 179;
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Mad Otar Grits");
		}
	}
}
