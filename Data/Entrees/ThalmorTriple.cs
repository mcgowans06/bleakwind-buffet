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
	/// <summary>
	/// Public class representing the Thalmor Triple
	/// </summary>
	public class ThalmorTriple
	{
		// Default Properties
		/// <summary>
		/// Price of this entree
		/// </summary>
		public double Price { get; private set; } = 8.32;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public uint Calories { get; private set; } = 943;
		// The private backing variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this entree
		/// </summary>
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
		private bool _bacon = true;
		private bool _egg = true;

		// Ingredient Properties
		/// <summary>
		/// If this entree has a bun
		/// </summary>
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
		/// <summary>
		/// If this entree has ketchup
		/// </summary>
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
		/// <summary>
		/// If this entree has mustard
		/// </summary>
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
		/// <summary>
		/// If this entree has pickles
		/// </summary>
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
		/// <summary>
		/// If this entree has cheese
		/// </summary>
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
		/// <summary>
		/// If this entree has tomatoes
		/// </summary>
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
		/// <summary>
		/// If this entree has lettuce
		/// </summary>
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
		/// <summary>
		/// If this entree has mayo
		/// </summary>
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
		/// <summary>
		/// If this entree has bacon
		/// </summary>
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
					specialInstructions.Add("Hold bacon");
				}
				else
				{
					specialInstructions.Remove("Hold bacon");
				}
			}
		}
		/// <summary>
		/// If this entree has an egg
		/// </summary>
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
					specialInstructions.Add("Hold egg");
				}
				else
				{
					specialInstructions.Remove("Hold egg");
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
			return ("Thalmor Triple");
		}
	}
}
