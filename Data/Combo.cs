/*
* Author: Samuel McGowan
* Class name: Combo.cs
* Purpose: To hold information for a combo 
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.Data
{
	/// <summary>
	/// The public class representing a combo
	/// </summary>
	public class Combo : IOrderItem, INotifyPropertyChanged
	{
		/// <summary>
		/// Event handler that handles when a property changes
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		private Entree entree;
		/// <summary>
		/// The entree of the combo
		/// </summary>
		public Entree Entree
		{
			get
			{
				return (entree);
			}
			set
			{
				if(value != entree)
				{
					if(entree != null)
					{
						entree.PropertyChanged -= OnSpecialInstructionsChanged;
					}
					entree = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
					entree.PropertyChanged += OnSpecialInstructionsChanged;
				}
			}
		}

		private Side side;
		/// <summary>
		/// The side of the combo
		/// </summary>
		public Side Side
		{
			get
			{
				return (side);
			}
			set
			{
				if(value != side)
				{
					if(side != null)
					{
						side.PropertyChanged -= OnSpecialInstructionsChanged;
						side.PropertyChanged -= OnPriceChanged;
						side.PropertyChanged -= OnCaloriesChanged;
					}
					side = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
					side.PropertyChanged += OnPriceChanged;
					side.PropertyChanged += OnCaloriesChanged;
					side.PropertyChanged += OnSpecialInstructionsChanged;
				}
			}
		}

		private Drink drink;
		/// <summary>
		/// The drink of the combo
		/// </summary>
		public Drink Drink
		{
			get
			{
				return (drink);
			}
			set
			{
				if (value != drink)
				{ 
					if(drink != null)
					{
						drink.PropertyChanged -= OnSpecialInstructionsChanged;
						drink.PropertyChanged -= OnPriceChanged;
						drink.PropertyChanged -= OnCaloriesChanged;
					}
					drink = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
					drink.PropertyChanged += OnPriceChanged;
					drink.PropertyChanged += OnCaloriesChanged;
					drink.PropertyChanged += OnSpecialInstructionsChanged;
				}
			}
		}

		/// <summary>
		/// The total price of the combo
		/// </summary>
		public double Price
		{
			get
			{
				return (Entree.Price + Side.Price + Drink.Price);
			}
		}

		/// <summary>
		/// The total amount of calories of the combo
		/// </summary>
		public uint Calories
		{
			get
			{
				return (Entree.Calories + Side.Calories + Drink.Calories);
			}
		}

		/// <summary>
		/// The different special instructions for the combo
		/// </summary>
		public List<string> SpecialInstructions
		{
			get
			{
				List<string> list = new List<string>();
				// Entree special instructions
				list.Add(Entree.ToString());
				foreach(string s in Entree.SpecialInstructions)
				{
					list.Add("*" + s);
				}

				//Drink special instructions
				list.Add(Drink.ToString());
				foreach(string s in Drink.SpecialInstructions)
				{
					list.Add("*" + s);
				}
				return (list);
			}
		}

		/// <summary>
		/// Event handler for when the price of a menu item changes
		/// </summary>
		/// <param name="sender">The menu item</param>
		/// <param name="e">The property that has changed</param>
		void OnPriceChanged(object sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == "Price")
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
			}
		}

		/// <summary>
		/// Event handler for when the calories of a menu item changes
		/// </summary>
		/// <param name="sender">The menu item</param>
		/// <param name="e">The property that has changed</param>
		void OnCaloriesChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Calories")
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
			}
		}

		/// <summary>
		/// Event handler for when the SpecialInstructions of a menu item changes
		/// </summary>
		/// <param name="sender">The menu item</param>
		/// <param name="e">The property that has changed</param>
		void OnSpecialInstructionsChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "SpecialInstructions")
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
			}
		}
	}
}
