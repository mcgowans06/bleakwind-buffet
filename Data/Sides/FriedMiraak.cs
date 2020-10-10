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
	public class FriedMiraak : Side
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
					case Size.Small: return (1.78);
					case Size.Medium: return (2.01);
					case Size.Large: return (2.88);
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
					case Size.Small: return (151);
					case Size.Medium: return (236);
					case Size.Large: return (306);
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
			return ($"{Size} Fried Miraak");
		}
	}
}
