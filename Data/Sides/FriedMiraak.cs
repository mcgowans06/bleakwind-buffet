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
	/// <summary>
	/// Public class representing the Fried Miraak
	/// </summary>
	public class FriedMiraak
	{
		// Properties
		/// <summary>
		/// Price of this side. Set initially to small
		/// </summary>
		public double Price { get; set; } = 1.78;
		/// <summary>
		/// Calories of this side. Set initially to small
		/// </summary>
		public uint Calories { get; set; } = 151;
		/// <summary>
		/// Stores the special instructions for this side
		/// </summary>
		public List<string> SpecialInstructions
		{
			get => new List<string>();
		}

		private Size _size = Size.Small;
		
		/// <summary>
		/// The size of this side. Sets the price and calories accordingly
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
			return ($"{Size} Fried Miraak");
		}
	}
}
