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
	/// <summary>
	/// Public class representing the Briarheart Burger
	/// </summary>
	public class BriarheartBurger : Entree
	{
		// Default Properties
		/// <summary>
		/// The price of this entree
		/// </summary>
		public override double Price { get; } = 6.32;
		/// <summary>
		/// The calories of this entree
		/// </summary>
		public override uint Calories { get; } = 743;

		// The private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this entree
		/// </summary>
		public override List<string> SpecialInstructions
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

		// ToString Override
		/// <summary>
		/// Returns a description of this entree
		/// </summary>
		/// <returns>A string describing this entree</returns>
		public override string ToString()
		{
			return("Briarheart Burger");
		}
	}
}
