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
	/// <summary>
	/// Public class representing the Smokehouse Skeleton
	/// </summary>
	public class SmokehouseSkeleton : Entree
	{
		// Default Properties
		/// <summary>
		/// Price of this entree
		/// </summary>
		public override double Price { get; } = 5.62;
		/// <summary>
		/// Calories of this entree
		/// </summary>
		public override uint Calories { get; } = 602;
		// Private backing variable for the SpecialInstructions property
		private List<string> specialInstructions = new List<string>();
		/// <summary>
		/// Stores the special instructions for this entree
		/// </summary>
		public override List<string> SpecialInstructions
		{
			get => new List<string>(specialInstructions);
		}

		// Private Backing Variables for Ingredients
		private bool _sausageLink = true;
		private bool _egg = true;
		private bool _hashbrowns = true;
		private bool _pancake = true;

		// Ingredient Properties
		/// <summary>
		/// If this entree has sausage links
		/// </summary>
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
		/// <summary>
		/// If this entree has eggs
		/// </summary>
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
		/// <summary>
		/// If this entree has hashbrowns
		/// </summary>
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
		/// <summary>
		/// If this entree has pancakes
		/// </summary>
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
		/// <summary>
		/// Returns a description of this entree
		/// </summary>
		/// <returns>A string describing this entree</returns>
		public override string ToString()
		{
			return ("Smokehouse Skeleton");
		}
	}
}
