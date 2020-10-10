/*
* Author: Samuel McGowan
* Class name: ThalmorTriple.cs
* Purpose: To hold information for the Thalmor Triple
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Thalmor Triple
	/// </summary>
	public class ThalmorTriple : Entree, INotifyPropertyChanged
	{
		public override event PropertyChangedEventHandler PropertyChanged;

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

		// Default Properties
		/// <summary>
		/// Price of this entree
		/// </summary>
		public override double Price { get; } = 8.32;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public override uint Calories { get; } = 943;
		// The private backing variable for the SpecialInstructions property
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
				if (value != _bun)
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
				if (value != _ketchup)
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
				if (value != _mustard)
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
				if (value != _pickle)
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
				if (value != _cheese)
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
				if (value != _tomato)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if (value != _lettuce)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if (value != _mayo)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _bacon)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bacon"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _egg)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
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
			return ("Thalmor Triple");
		}
	}
}
