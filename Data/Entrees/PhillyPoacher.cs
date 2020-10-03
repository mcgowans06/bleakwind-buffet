/*
* Author: Samuel McGowan
* Class name: PhillyPoacher.cs
* Purpose: To hold information for the Philly Poacher	
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Philly Poacher
	/// </summary>
	public class PhillyPoacher : Entree, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

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
				if(value != _sirloin)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sirloin"));
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
				if(value != _onion)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Onion"));
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
				if(value != _roll)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Roll"));
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
