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
	public class AretinoAppleJuice : Drink 
	{
		/* Properties */
		/// <summary>
		/// The price of this Aretino Apple Juice
		/// </summary>
		public override double Price
		{
			get 
			{
				switch (Size)
				{
					case Size.Small: return (.62);
					case Size.Medium: return (.87);
					case Size.Large: return (1.01);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The calories of this Aretino Apple Juice
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (44);
					case Size.Medium: return (88);
					case Size.Large: return (132);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions of the Aretino Apple Juice
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get
			{
				return(new List<string>(specialInstructions));
			}
		}

		// Private Backing Variables
		private Boolean _ice = false;
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
