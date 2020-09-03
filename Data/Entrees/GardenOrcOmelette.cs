/*
* Author: Samuel McGowan
* Class name: GardenOrcOmelette.cs
* Purpose: To hold information for the Garden Orc Omelette
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	public class GardenOrcOmelette
	{
		// Default Properties
		public double Price { get; private set; } = 4.57;
		public uint Calories { get; private set; } = 404;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables for Ingredients
		private bool _broccoli = true;
		private bool _mushrooms = true;
		private bool _tomato = true;
		private bool _cheddar = true;

		// Ingredient Properties
		public bool Broccoli
		{
			get
			{
				return (_broccoli);
			}
			set
			{
				_broccoli = value;
				if (value == false)
				{
					specialInstructions.Add("Hold broccoli");
				}
				else
				{
					specialInstructions.Remove("Hold broccoli");
				}
			}
		}
		public bool Mushrooms
		{
			get
			{
				return (_mushrooms);
			}
			set
			{
				_mushrooms = value;
				if (value == false)
				{
					specialInstructions.Add("Hold mushrooms");
				}
				else
				{
					specialInstructions.Remove("Hold mushrooms");
				}
			}
		}
		public bool Tomato
		{
			get
			{
				return (_tomato);
			}
			set
			{
				_tomato = value;
				if (value == false)
				{
					specialInstructions.Add("Hold tomato");
				}
				else
				{
					specialInstructions.Remove("Hold tomato");
				}
			}
		}
		public bool Cheddar
		{
			get
			{
				return (_cheddar);
			}
			set
			{
				_cheddar = value;
				if (value == false)
				{
					specialInstructions.Add("Hold cheddar");
				}
				else
				{
					specialInstructions.Remove("Hold cheddar");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ("Garden Orc Omelette");
		}
	}
}
