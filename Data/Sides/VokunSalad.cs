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
	/// <summary>
	/// Public class representing the Vokun Salad
	/// </summary>
	public class VokunSalad
	{
		// Properties
		/// <summary>
		/// Price of this side. Set initially to small
		/// </summary>
		public double Price { get; set; } = 0.93;
		/// <summary>
		/// Calories of this side. Set initially to small
		/// </summary>
		public uint Calories { get; set; } = 41;
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
			return ($"{Size} Vokun Salad");
		}
	}
}
