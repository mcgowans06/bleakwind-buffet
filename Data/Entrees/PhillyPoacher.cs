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
	class PhillyPoacher
	{
		// Default Properties
		public double Price { get; private set; } = 7.23;
		public uint Calories { get; private set; } = 784;
		public List<String> SpecialInstructions { get; set; }

		// Private Backing Variables for Ingredients
		private bool _sirloin = true;
		private bool _onion = true;
		private bool _roll = true;

		// Ingredient Properties
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
					SpecialInstructions.Add("Hold sirloin");
				}
			}
		}
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
					SpecialInstructions.Add("Hold onions");
				}
			}
		}
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
					SpecialInstructions.Add("Hold roll");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ("Philly Poacher");
		}
	}
}
