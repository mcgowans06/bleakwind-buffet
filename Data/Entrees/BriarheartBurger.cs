/*
* Author: Samuel McGowan
* Class name: BriarheartBurger.cs
* Purpose: To hold information for the Briarheart Burger
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Briarheart Burger
	/// </summary>
	public class BriarheartBurger : Entree, INotifyPropertyChanged
	{
		public override event PropertyChangedEventHandler PropertyChanged;

		// Default Properties
		/// <summary>
		/// The price of this entree
		/// </summary>
		public override double Price { get; } = 6.32;
		/// <summary>
		/// The calories of this entree
		/// </summary>
		public override uint Calories { get; } = 743;

		/// <summary>
		/// Property that returns the ToString method
		/// </summary>
		public string Name
		{
			get
			{
				return (ToString());
			}
		}

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
				if(value != _bun)
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _ketchup)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _mustard)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _pickle)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _cheese)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
