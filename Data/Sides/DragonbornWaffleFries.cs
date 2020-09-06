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
	/// <summary>
	/// Public class representing the Dragonborn Waffle Fries
	/// </summary>
	public class DragonbornWaffleFries
	{
		// Properties
		/// <summary>
		/// Price of this side. Initially set to small
		/// </summary>
		public double Price { get; set; } = 0.42;
		/// <summary>
		/// Calories of this side. Initially set to small
		/// </summary>
		public uint Calories { get; set; } = 77;
		/// <summary>
		/// Stores the special instructions for this side
		/// </summary>
		public List<string> SpecialInstructions
		{
			get => new List<string>();
		}

		private Size _size = Size.Small;
		
		/// <summary>
		/// Stores the size of this entree. Sets the price and calories accordingly
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
				_size = value;
			}
		}

		// ToString Override
		/// <summary>
		/// Returns a description of this side
		/// </summary>
		/// <returns>A string describing this side</returns>
		public override string ToString()
		{
			return ($"{Size} Dragonborn Waffle Fries");
		}
	}
}
