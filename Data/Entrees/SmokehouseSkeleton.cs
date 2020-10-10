/*
* Author: Samuel McGowan
* Class name: SmokehouseSkeleton.cs
* Purpose: To hold information for the Smokehouse Skeleton
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Entrees
{
	/// <summary>
	/// Public class representing the Smokehouse Skeleton
	/// </summary>
	public class SmokehouseSkeleton : Entree, INotifyPropertyChanged
	{
		public override event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// Property that returns the ToString method
		/// </summary>
		public string Name
		{
			get
			{
				return (ToString());
			}
		}

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
				if(value != _sausageLink)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SausageLink"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _egg)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Egg"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _hashbrowns)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HashBrowns"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
				if(value != _pancake)
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
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pancake"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
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
