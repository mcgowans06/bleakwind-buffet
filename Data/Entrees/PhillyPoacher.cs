/*
* Author: Samuel McGowan
* Class name: PhillyPoacher.cs
* Purpose: To hold information for the Philly Poacher	
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Philly Poacher
	/// </summary>
	public class PhillyPoacher : Entree
	{
		// Default Properties
		/// <summary>
		/// Price of this entree
		/// </summary>
		public override double Price { get; } = 7.23;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public override uint Calories { get; } = 784;
		// Private backing variable of the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this entree
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables for Ingredients
		private bool _sirloin = true;
		private bool _onion = true;
		private bool _roll = true;

		// Ingredient Properties
		/// <summary>
		/// If this entree has sirloin
		/// </summary>
		public bool Sirloin
		{
			get
			{
				return (_sirloin);
			}
			set
			{
				_sirloin = value;
				if (value == false)
				{
					specialInstructions.Add("Hold sirloin");
				}
				else
				{
					specialInstructions.Remove("Hold sirloin");
				}
			}
		}
		/// <summary>
		/// If this entree has onions
		/// </summary>
		public bool Onion
		{
			get
			{
				return (_onion);
			}
			set
			{
				_onion = value;
				if (value == false)
				{
					specialInstructions.Add("Hold onions");
				}
				else
				{
					specialInstructions.Remove("Hold onions");
				}
			}
		}
		/// <summary>
		/// if this entree has rolls
		/// </summary>
		public bool Roll
		{
			get
			{
				return (_roll);
			}
			set
			{
				_roll = value;
				if (value == false)
				{
					specialInstructions.Add("Hold roll");
				}
				else
				{
					specialInstructions.Remove("Hold roll");
				}
			}
		}

		// ToString Override
		/// <summary>
		/// Returns a description of this entree
		/// </summary>
		/// <returns>A string describing this entree</returns>
		public override string ToString()
		{
			return ("Philly Poacher");
		}
	}
}
