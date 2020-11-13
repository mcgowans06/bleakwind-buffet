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
	public class MadOtarGrits : Side
	{
		/// <summary>
		/// Property that returns the ToString method
		/// </summary>
		public string Name
		{
			get
			{
				return (ToString());
			}
		}
		/// <summary>
		/// The description of this side
		/// </summary>
		public override string Description { get; } = "Cheesey Grits.";
		// Properties
		/// <summary>
		/// Price of this side. Set initially to small
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (1.22);
					case Size.Medium: return (1.58);
					case Size.Large: return (1.93);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// Calories of this side. Set initially to small
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (105);
					case Size.Medium: return (142);
					case Size.Large: return (179);
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
			return ($"{Size} Mad Otar Grits");
		}
	}
}
