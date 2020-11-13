/*
* Author: Samuel McGowan
* Class name: AretinoAppleJuice.cs
* Purpose: To hold information for the Aretino Apple Juice
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
	/// Public class for representing an Aretino Apple Juice
	/// </summary>
	public class AretinoAppleJuice : Drink
	{
		/// <summary>
		/// Event handler that handles whenever a property is changed
		/// </summary>
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

		/* Properties */
		/// <summary>
		/// The price of this Aretino Apple Juice
		/// </summary>
		public override double Price
		{
			get 
			{
				switch (Size)
				{
					case Size.Small: return (.62);
					case Size.Medium: return (.87);
					case Size.Large: return (1.01);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		/// <summary>
		/// The calories of this Aretino Apple Juice
		/// </summary>
		public override uint Calories
		{
			get
			{
				switch (Size)
				{
					case Size.Small: return (44);
					case Size.Medium: return (88);
					case Size.Large: return (132);
					default: throw new NotImplementedException("Should never be reached");
				}
			}
		}
		
		// Private backer variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions of the Aretino Apple Juice
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get
			{
				return(new List<string>(specialInstructions));
			}
		}

		// Private Backing Variables
		private Boolean _ice = false;
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
						if(specialInstructions.Contains("Add ice")) specialInstructions.Remove("Add ice");
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
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
				}

			}
		}

		/// <summary>
		/// The description of this drink
		/// </summary>
		public override string Description { get; } = "Fresh squeezed apple juice.";

		// ToString Override
		/// <summary>
		/// Returns a description of this drink
		/// </summary>
		/// <returns>A string describing this drink</returns>
		public override string ToString()
		{
			return ($"{Size} Aretino Apple Juice");
		}
	}
}
