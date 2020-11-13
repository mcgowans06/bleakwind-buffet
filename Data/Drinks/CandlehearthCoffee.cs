/*
* Author: Samuel McGowan
* Class name: CandlehearthCoffee.cs
* Purpose: To hold information for the Candlehearth Coffee
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Public class that represents a CandleHearthCoffee
	/// </summary>
	public class CandlehearthCoffee : Drink
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
		/// The price of this drink
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (.75);
					case Size.Medium: return (1.25);
					case Size.Large: return (1.75);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The description of this drink
		/// </summary>
		public override string Description { get; } = "Fair trade, fresh ground dark roast coffee.";
		/// <summary>
		/// The calories of this drink, set to the value of a small by default
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (7);
					case Size.Medium: return (10);
					case Size.Large: return (20);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		//Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		private Boolean _decaf = false;
		/// <summary>
		/// If this drink is decaf
		/// </summary>
		public Boolean Decaf
		{
			get
			{
				return (_decaf);
			}
			set
			{
				if(value != _decaf)
				{
					_decaf = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		// Private Backing Variables
		private Boolean _ice = false;
		private Boolean _roomForCream = false;

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
					if (value == true)
					{
						specialInstructions.Add("Add ice");
					}
					else
					{
						specialInstructions.Remove("Add ice");
					}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
			}
		}
		/// <summary>
		/// If this drink has room for cream
		/// </summary>
		public Boolean RoomForCream
		{
			get
			{
				return (_roomForCream);
			}
			set
			{
				if(value != _roomForCream)
				{
					_roomForCream = value;
					if (value == true)
					{
						specialInstructions.Add("Add cream");
					}
				}
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
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
			if(Decaf == true)
			{
				return ($"{Size} Decaf Candlehearth Coffee");
			}
			else
			{
				return ($"{Size} Candlehearth Coffee");
			}
		}
	}
}
