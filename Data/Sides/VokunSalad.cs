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
	public class VokunSalad : Side
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
					case Size.Small: return (.93);
					case Size.Medium: return (1.28);
					case Size.Large: return (1.82);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The description of this side
		/// </summary>
		public override string Description { get; } = "Crispy fried potato waffle fries.";
		/// <summary>
		/// Calories of this side. Set initially to small
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (41);
					case Size.Medium: return (52);
					case Size.Large: return (73);
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
			return ($"{Size} Vokun Salad");
		}
	}
}
