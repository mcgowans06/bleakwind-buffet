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
	public class DragonbornWaffleFries : Side
	{
		// Properties
		/// <summary>
		/// Price of this side. Initially set to small
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (.42);
					case Size.Medium: return (.76);
					case Size.Large: return (.96);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// Calories of this side. Initially set to small
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (77);
					case Size.Medium: return (89);
					case Size.Large: return (100);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}

		/// <summary>
		/// Stores the special instructions for this side
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>();
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
