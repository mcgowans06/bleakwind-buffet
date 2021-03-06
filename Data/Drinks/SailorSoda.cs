﻿/*
* Author: Samuel McGowan
* Class name: SailorSoda.cs
* Purpose: To hold information for the Sailor Soda
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
	/// Public class representing the Sailor Soda
	/// </summary>
	public class SailorSoda : Drink
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
		/// The price of this drink. Set to small initially
		/// </summary>
		public override double Price
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (1.42);
					case Size.Medium: return (1.74);
					case Size.Large: return (2.07);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The calories of this drink. Set to small initially
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (117);
					case Size.Medium: return (153);
					case Size.Large: return (205);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this drink
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		private SodaFlavor _flavor = SodaFlavor.Cherry;
		/// <summary>
		/// The flavor of this drink
		/// </summary>
		public SodaFlavor Flavor
		{
			get { return (_flavor); }
			set
			{
				if(value != _flavor)
				{
					_flavor = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}
			}
		}

		/// <summary>
		/// The description of this drink
		/// </summary>
		public override string Description { get; } = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

		// Private Backing Variables
		private Boolean _ice = true;
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
					if(value == false)
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
			return ($"{Size} {Flavor} Sailor Soda");
		}
	}
}
