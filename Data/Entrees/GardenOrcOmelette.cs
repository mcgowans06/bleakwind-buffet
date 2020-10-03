/*
* Author: Samuel McGowan
* Class name: GardenOrcOmelette.cs
* Purpose: To hold information for the Garden Orc Omelette
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Garden Orc Omelette
	/// </summary>
	public class GardenOrcOmelette : Entree, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		// Default Properties
		/// <summary>
		/// Prive of this entree
		/// </summary>
		public override double Price { get; } = 4.57;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public override uint Calories { get; } = 404;
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
		private bool _broccoli = true;
		private bool _mushrooms = true;
		private bool _tomato = true;
		private bool _cheddar = true;

		// Ingredient Properties
		/// <summary>
		/// If this entree has broccoli
		/// </summary>
		public bool Broccoli
		{
			get
			{
				return (_broccoli);
			}
			set
			{
				if (value != _broccoli)
				{
					_broccoli = value;
					if (value == false)
					{
						specialInstructions.Add("Hold broccoli");
					}
					else
					{
						specialInstructions.Remove("Hold broccoli");
					}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Broccoli"));
			}
		}
		/// <summary>
		/// If this entree has mushrooms
		/// </summary>
		public bool Mushrooms
		{
			get
			{
				return (_mushrooms);
			}
			set
			{
				if(value != _mushrooms)
				{
					_mushrooms = value;
					if (value == false)
					{
						specialInstructions.Add("Hold mushrooms");
					}
					else
					{
						specialInstructions.Remove("Hold mushrooms");
					}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mushrooms"));
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
				if(value != _tomato)
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
			}
		}
		/// <summary>
		/// If this entree has cheddar
		/// </summary>
		public bool Cheddar
		{
			get
			{
				return (_cheddar);
			}
			set
			{
				if(value != _cheddar)
				{
				_cheddar = value;
				if (value == false)
				{
					specialInstructions.Add("Hold cheddar");
				}
				else
				{
					specialInstructions.Remove("Hold cheddar");
				}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheddar"));
			}
		}

		// ToString Override
		/// <summary>
		/// Returns a description of this entree
		/// </summary>
		/// <returns>A string describing this entree</returns>
		public override string ToString()
		{
			return ("Garden Orc Omelette");
		}
	}
}
