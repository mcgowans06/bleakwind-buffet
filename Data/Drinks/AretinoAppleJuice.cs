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
	/// <summary>
	/// Public class for representing an Aretino Apple Juice
	/// </summary>
	public class AretinoAppleJuice
	{
		/* Properties */
		/// <summary>
		/// The price of this Aretino Apple Juice
		/// </summary>
		public double Price { get; set; } = 0.62;
		/// <summary>
		/// The calories of this Aretino Apple Juice
		/// </summary>
		public uint Calories { get; set; } = 44;
		
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions of the Aretino Apple Juice
		/// </summary>
		public List<string> SpecialInstructions
		{
			get
			{
				return(new List<string>(specialInstructions));
			}
		}

		// Private Backing Variables
		private Size _size = Size.Small;
		private Boolean _ice = false;
		/// <summary>
		/// Stores the size of the drink and sets the price and calories accordingly
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
					if(specialInstructions.Contains("Add ice")) specialInstructions.Remove("Add ice");
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
			return ($"{Size} Aretino Apple Juice");
		}
	}
}
