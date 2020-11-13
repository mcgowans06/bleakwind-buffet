/*
* Author: Samuel McGowan
* Class name: Drink.cs
* Purpose: To hold information for the base class Drink
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
	/// A base class representing the common properties of drinks
	/// </summary>
	public abstract class Drink : IOrderItem, INotifyPropertyChanged
	{
		public virtual event PropertyChangedEventHandler PropertyChanged;

		private Size _size = Size.Small;
		/// <summary>
		/// The size of the drink
		/// </summary>
		public virtual Size Size
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
				}

			}
		}

		/// <summary>
		/// The description of this item
		/// </summary>
		public abstract string Description { get; }

		/// <summary>
		/// The price of the drink
		/// </summary>
		/// <value>
		/// In US dollars
		/// </value>
		public abstract double Price { get; }
		/// <summary>
		/// The calories of the drink
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// Special instructions to prepare the drink
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }
	}
}
