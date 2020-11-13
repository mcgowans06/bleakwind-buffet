/*
* Author: Samuel McGowan
* Class name: WarriorWater.cs
* Purpose: To hold information for the Warrior Water
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Public class representing the Warrior Water
	/// </summary>
	public class WarriorWater : Drink
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

		// Properties
		/// <summary>
		/// The price of this drink. Initially set to small
		/// </summary>
		public override double Price { get;} = 0.00;
		/// <summary>
		/// The calories of this drink. Initially set to small
		/// </summary>
		public override uint Calories { get; } = 0;
		// Private back variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		/// <summary>
		/// The description of this drink
		/// </summary>
		public override string Description { get; } = "It’s water. Just water.";
		// Private Backing Variables
		private Boolean _ice = true;
		private Boolean _lemon = false;
		/// <summary>
		/// If this drink has ice
		/// </summary>
		public Boolean Ice
		{
			get
			{
				return (_ice);
			}
			set
			{
				if(value != _ice)
				{
					_ice = value;
					if (value == false)
					{
						specialInstructions.Add("Hold ice");
					}
					else
					{
						specialInstructions.Remove("Hold ice");
					}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
			}
		}
		/// <summary>
		/// If this drink has lemon 
		/// </summary>
		public Boolean Lemon
		{
			get
			{
				return (_lemon);
			}
			set
			{
				if(value != _lemon)
				{
					_lemon = value;
					if (value == true)
					{
						specialInstructions.Add("Add lemon");
					}
					else
					{
						specialInstructions.Remove("Add lemon");
					}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
			}
		}

		private Size _size = Size.Small;
		/// <summary>
		/// The size of the drink
		/// </summary>
		public override Size Size
		{
			get { return (_size); }
			set
			{
				if (value != _size)
				{
					_size = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}

			}
		}

		// ToString Override
		/// <summary>
		/// Returns a description of this drink
		/// </summary>
		/// <returns>A string describing this drink</returns>
		public override string ToString()
		{
			return ($"{Size} Warrior Water");
		}
	}
}
