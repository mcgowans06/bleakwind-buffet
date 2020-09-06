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
	/// <summary>
	/// Public class representing the Sailor Soda
	/// </summary>
	public class SailorSoda
	{
		// Properties
		/// <summary>
		/// The price of this drink. Set to small initially
		/// </summary>
		public double Price { get; set; } = 1.42;
		/// <summary>
		/// The calories of this drink. Set to small initially
		/// </summary>
		public uint Calories { get; set; } = 117;
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		/// <summary>
		/// The flavor of this drink
		/// </summary>
		public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = true;
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
		/// <summary>
		/// Returns a description of this drink
		/// </summary>
		/// <returns>A string describing this drink</returns>
		public override string ToString()
		{
			return ($"{Size} {Flavor} Sailor Soda");
		}
	}
}
