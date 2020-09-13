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
	public class SailorSoda : Drink
	{
		// Properties
		/// <summary>
		/// The price of this drink. Set to small initially
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (1.42);
					case Size.Medium: return (1.74);
					case Size.Large: return (2.07);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The calories of this drink. Set to small initially
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (117);
					case Size.Medium: return (153);
					case Size.Large: return (205);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		/// <summary>
		/// The flavor of this drink
		/// </summary>
		public SodaFlavor Flavor { get; set; } = SodaFlavor.Cherry;

		// Private Backing Variables
		private Boolean _ice = true;
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
