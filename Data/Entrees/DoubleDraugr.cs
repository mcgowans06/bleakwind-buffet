/*
* Author: Samuel McGowan
* Class name: DoubleDraugr.cs
* Purpose: To hold information for the Double Draugr
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	class DoubleDraugr
	{
		// Default Properties
		public double Price { get; private set; } = 7.32;
		public uint Calories { get; private set; } = 843;
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
		private bool _tomato = true;
		private bool _lettuce = true;
		private bool _mayo = true;

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
					specialInstructions.Add("Hold tomato");
				}
				else
				{
					specialInstructions.Remove("Hold tomato");
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
					specialInstructions.Add("Hold lettuce");
				}
				else
				{
					specialInstructions.Remove("Hold lettuce");
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
					specialInstructions.Add("Hold mayo");
				}
				else
				{
					specialInstructions.Remove("Hold mayo");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ("Double Draugr");
		}
	}
}
