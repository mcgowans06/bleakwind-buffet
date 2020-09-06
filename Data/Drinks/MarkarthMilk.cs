/*
* Author: Samuel McGowan
* Class name: MarkarthMilk.cs
* Purpose: To hold information for the Markarth Milk
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Public class representing the Markarth Milk
	/// </summary>
	public class MarkarthMilk
	{
		// Properties
		/// <summary>
		/// The price of this drink. Set to small by default
		/// </summary>
		public double Price { get; set; } = 1.05;
		/// <summary>
		/// The calories of this drink. Set to small by default
		/// </summary>
		public uint Calories { get; set; } = 56;
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = false;
		/// <summary>
		/// The size of this drink. Sets the price and calories accordingly
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

		// ToString Override
		/// <summary>
		/// Returns a description of this drink
		/// </summary>
		/// <returns>A string describing this drink</returns>
		public override string ToString()
		{
			return ($"{Size} Markarth Milk");
		}
	}
}
