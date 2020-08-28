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
		public List<String> SpecialInstructions { get; set; }

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
					SpecialInstructions.Add("Hold sausage");
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
					SpecialInstructions.Add("Hold eggs");
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
					SpecialInstructions.Add("Hold hash browns");
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
					SpecialInstructions.Add("Hold pancakes");
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
