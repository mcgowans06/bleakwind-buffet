/*
* Author: Samuel McGowan
* Class name: Entree.cs
* Purpose: To hold information for the base class Entree
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// A base class representing the common properties of entrees
	/// </summary>
	public abstract class Entree : IOrderItem, INotifyPropertyChanged
	{
		public abstract event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// The price of the entree
		/// </summary>
		/// <value>
		/// In US dollars
		/// </value>
		public abstract double Price { get; }
		/// <summary>
		/// The calories of the entree
		/// </summary>
		public abstract uint Calories { get; }
		/// <summary>
		/// The special instructions to prepare the entree
		/// </summary>
		public abstract List<string> SpecialInstructions { get; }
		/// <summary>
		/// The description of the entree
		/// </summary>
		public abstract string Description { get; }
	}
}
