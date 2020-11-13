/*
* Author: Samuel McGowan
* Class name: IOrderItem.cs
* Purpose: To hold information for the base interface IOrderItem
* Last Modified: 11/12/20
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
	/// <summary>
	/// An interface represeting the basic properties of an order item
	/// </summary>
	public interface IOrderItem
	{
		/// <summary>
		/// The price of the item
		/// </summary>
		/// <value>
		/// In US dollars
		/// </value>
		double Price { get; }
		/// <summary>
		/// The calories of the item
		/// </summary>
		uint Calories { get; }
		/// <summary>
		/// The special instructions to prepare the item
		/// </summary>
		List<string> SpecialInstructions { get; }

		/// <summary>
		/// The description of the item
		/// </summary>
		string Description { get; }
	}
}
