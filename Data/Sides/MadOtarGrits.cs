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
	/// <summary>
	/// Public class representing the Mad Otar Grits
	/// </summary>
	public class MadOtarGrits
	{
		// Properties
		/// <summary>
		/// Price of this side. Set initially to small
		/// </summary>
		public double Price { get; set; } = 1.22;
		/// <summary>
		/// Calories of this side. Set initially to small
		/// </summary>
		public uint Calories { get; set; } = 105;
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
			return ($"{Size} Mad Otar Grits");
		}
	}
}
