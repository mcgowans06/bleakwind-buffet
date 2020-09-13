﻿/*
* Author: Samuel McGowan
* Class name: WarriorWater.cs
* Purpose: To hold information for the Warrior Water
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
	/// <summary>
	/// Public class representing the Warrior Water
	/// </summary>
	public class WarriorWater : Drink
	{
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
