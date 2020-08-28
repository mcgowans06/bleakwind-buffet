/*
* Author: Samuel McGowan
* Class name: ThalmorTriple.cs
* Purpose: To hold information for the Thalmor Triple
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	class ThalmorTriple
	{
		// Default Properties
		public double Price { get; private set; } = 8.32;
		public uint Calories { get; private set; } = 943;
		public List<String> SpecialInstructions { get; set; }

		// Private Backing Variables for Ingredients
		private bool _bun = true;
		private bool _ketchup = true;
		private bool _mustard = true;
		private bool _pickle = true;
		private bool _cheese = true;
		private bool _tomato = true;
		private bool _lettuce = true;
		private bool _mayo = true;
		private bool _bacon = true;
		private bool _egg = true;

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
					SpecialInstructions.Add("Hold bun");
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
					SpecialInstructions.Add("Hold ketchup");
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
					SpecialInstructions.Add("Hold mustard");
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
					SpecialInstructions.Add("Hold pickle");
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
					SpecialInstructions.Add("Hold cheese");
				}
			}
		}
		public bool Tomato
		{
			get
			{
				return (_tomato);
			}
			set
			{
				_tomato = value;
				if (value == false)
				{
					SpecialInstructions.Add("Hold tomato");
				}
			}
		}
		public bool Lettuce
		{
			get
			{
				return (_lettuce);
			}
			set
			{
				_lettuce = value;
				if (value == false)
				{
					SpecialInstructions.Add("Hold lettuce");
				}
			}
		}
		public bool Mayo
		{
			get
			{
				return (_mayo);
			}
			set
			{
				_mayo = value;
				if (value == false)
				{
					SpecialInstructions.Add("Hold mayo");
				}
			}
		}
		public bool Bacon
		{
			get
			{
				return (_bacon);
			}
			set
			{
				_bacon = value;
				if (value == false)
				{
					SpecialInstructions.Add("Hold bacon");
				}
			}
		}
		public bool Egg
		{
			get
			{
				return (_egg);
			}
			set
			{
				_egg = value;
				if (value == false)
				{
					SpecialInstructions.Add("Hold egg");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ("Thalmor Triple");
		}
	}
}
