/*
* Author: Samuel McGowan
* Class name: BriarheartBurger.cs
* Purpose: To hold information for the Briarheart Burger
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	class BriarheartBurger
	{
		// Default Properties
		public double Price { get; private set; } = 6.32;
		public uint Calories { get; private set; } = 743;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables for Ingredients
		private bool _bun = true;
		private bool _ketchup = true;
		private bool _mustard = true;
		private bool _pickle = true;
		private bool _cheese = true;

		// Ingredient Properties
		public bool Bun
		{
			get
			{
				return (_bun);
			}
			set
			{
				_bun = value;
				if (value == false)
				{
					specialInstructions.Add("Hold bun");
				}
				else
				{
					specialInstructions.Remove("Hold bun");
				}
			}
		}
		public bool Ketchup
		{
			get
			{
				return (_ketchup);
			}
			set
			{
				_ketchup = value;
				if (value == false)
				{
					specialInstructions.Add("Hold ketchup");
				}
				else
				{
					specialInstructions.Remove("Hold ketchup");
				}
			}
		}
		public bool Mustard
		{
			get
			{
				return (_mustard);
			}
			set
			{
				_mustard = value;
				if (value == false)
				{
					specialInstructions.Add("Hold mustard");
				}
				else
				{
					specialInstructions.Remove("Hold mustard");
				}
			}
		}
		public bool Pickle
		{
			get
			{
				return (_pickle);
			}
			set
			{
				_pickle = value;
				if (value == false)
				{
					specialInstructions.Add("Hold pickle");
				}
				else
				{
					specialInstructions.Remove("Hold pickle");
				}
			}
		}
		public bool Cheese
		{
			get
			{
				return (_cheese);
			}
			set
			{
				_cheese = value;
				if (value == false)
				{
					specialInstructions.Add("Hold cheese");
				}
				else
				{
					specialInstructions.Remove("Hold cheese");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return("Briarheart Burger");
		}
	}
}
