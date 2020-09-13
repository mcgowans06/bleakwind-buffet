/*
* Author: Samuel McGowan
* Class name: CandlehearthCoffee.cs
* Purpose: To hold information for the Candlehearth Coffee
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Public class that represents a CandleHearthCoffee
	/// </summary>
	public class CandlehearthCoffee : Drink
	{
		// Properties
		/// <summary>
		/// The price of this drink
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (.75);
					case Size.Medium: return (1.25);
					case Size.Large: return (1.75);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The calories of this drink, set to the value of a small by default
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (7);
					case Size.Medium: return (10);
					case Size.Large: return (20);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		//Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		/// <summary>
		/// If this drink is decaf
		/// </summary>
		public Boolean Decaf { get; set; } = false;

		// Private Backing Variables
		private Boolean _ice = false;
		private Boolean _roomForCream = false;

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
					specialInstructions.Remove("Add ice");
				}
			}
		}
		/// <summary>
		/// If this drink has room for cream
		/// </summary>
		public Boolean RoomForCream
		{
			get
			{
				return (_roomForCream);
			}
			set
			{
				_roomForCream = value;
				if (value == true)
				{
					specialInstructions.Add("Add cream");
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
			if(Decaf == true)
			{
				return ($"{Size} Decaf Candlehearth Coffee");
			}
			else
			{
				return ($"{Size} Candlehearth Coffee");
			}
		}
	}
}
