/*
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
	public class WarriorWater
	{
		// Properties
		public double Price { get; set; } = 0.00;
		public uint Calories { get; set; } = 0;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}
		public Size Size { get; set; }

		// Private Backing Variables
		private Boolean _ice = true;
		private Boolean _lemon = false;

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
					SpecialInstructions.Add("Add lemon");
				}
				else
				{
					SpecialInstructions.Remove("Remove lemon");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ($"{Size} Warrior Water");
		}
	}
}
