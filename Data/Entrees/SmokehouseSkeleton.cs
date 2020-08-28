/*
* Author: Samuel McGowan
* Class name: SmokehouseSkeleton.cs
* Purpose: To hold information for the Smokehouse Skeleton
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
	class SmokehouseSkeleton
	{
		// Default Properties
		public double Price { get; private set; } = 5.62;
		public uint Calories { get; private set; } = 602;
		private List<string> specialInstructions = new List<string>();
		public List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables for Ingredients
		private bool _sausageLink = true;
		private bool _egg = true;
		private bool _hashbrowns = true;
		private bool _pancake = true;

		// Ingredient Properties
		public bool SausageLink
		{
			get
			{
				return (_sausageLink);
			}
			set
			{
				_sausageLink = value;
				if (value == false)
				{
					specialInstructions.Add("Hold sausage");
				}
				else
				{
					specialInstructions.Remove("Hold sausage");
				}
			}
		}
		public bool Egg
		{
			get
			{
				return (_egg);
			}
			set
			{
				_egg = value;
				if (value == false)
				{
					specialInstructions.Add("Hold eggs");
				}
				else
				{
					specialInstructions.Remove("Hold eggs");
				}
			}
		}
		public bool HashBrowns
		{
			get
			{
				return (_hashbrowns);
			}
			set
			{
				_hashbrowns = value;
				if (value == false)
				{
					specialInstructions.Add("Hold hash browns");
				}
				else
				{
					specialInstructions.Remove("Hold hash browns");
				}
			}
		}
		public bool Pancake
		{
			get
			{
				return (_pancake);
			}
			set
			{
				_pancake = value;
				if (value == false)
				{
					specialInstructions.Add("Hold pancakes");
				}
				else
				{
					specialInstructions.Remove("Hold pancakes");
				}
			}
		}

		// ToString Override
		public override string ToString()
		{
			return ("Smokehouse Skeleton");
		}
	}
}
