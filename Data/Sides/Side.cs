/*
* Author: Samuel McGowan
* Class name: Side.cs
* Purpose: To hold information for the base class Side
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
	/// <summary>
	/// A base class representing the common properties of sides
	/// </summary>
	public abstract class Side : IOrderItem, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private Size _size = Size.Small;
		/// <summary>
		/// The size of the side
		/// </summary>
		public virtual Size Size
		{
			get { return (_size); }
			set
			{
				if(value != _size)
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

		/// <summary>
		/// The price of the side
		/// </summary>
		/// <value>
		/// In US dollars
		/// </value>
		public abstract double Price { get; }
		/// <summary>
		/// The calories of the side
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// The special instructions to prepare the side
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }
	}
}
