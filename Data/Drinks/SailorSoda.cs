/*
* Author: Samuel McGowan
* Class name: SailorSoda.cs
* Purpose: To hold information for the Sailor Soda
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	class SailorSoda
	{
		// Properties
		public double Price { get; set; } = 1.42;
		public uint Calories { get; set; } = 117;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = true;
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
					Price = 1.42;
					Calories = 117;
				}
				else if (value.Equals(Size.Medium))
				{
					Price = 1.74;
					Calories = 153;
				}
				else
				{
					Price = 2.07;
					Calories = 205;
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
				if(value == false)
				{
					specialInstructions.Add("Hold ice");
				}
				else
				{
					specialInstructions.Remove("Hold ice");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} {Flavor} Sailor Soda");
		}
	}
}
