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

		public string Name
		{
			get
			{
				return ("Combo:");
			}
		}

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
						entree.PropertyChanged -= OnPriceChanged;
						entree.PropertyChanged -= OnCaloriesChanged;
					}
					entree = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
					entree.PropertyChanged += OnSpecialInstructionsChanged;
					entree.PropertyChanged += OnCaloriesChanged;
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
				double price = 0;
				if (Entree != null) price += Entree.Price;
				if (Drink != null) price += Drink.Price;
				if (Side != null) price += Side.Price;
				return (Math.Round(price, 2));
			}
		}

		/// <summary>
		/// The total amount of calories of the combo
		/// </summary>
		public uint Calories
		{
			get
			{
				if (Entree != null && Side != null && Drink != null)
					return (Entree.Calories + Side.Calories + Drink.Calories);
				return (0);
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
				if (Entree != null)
				{
					// Entree special instructions
					list.Add(Entree.ToString());
					foreach (string s in Entree.SpecialInstructions)
					{
						list.Add("*" + s);
					}
				}
				else
				{
					list.Add("Click Me To Add Entree");
				}
				
				if(Drink != null)
				{
					//Drink special instructions
					list.Add(Drink.ToString());
					foreach(string s in Drink.SpecialInstructions)
					{
						list.Add("*" + s);
					}
				}
				else
				{
					list.Add("Click Me To Add Drink");
				}

				if(Side != null)
				{
					// Side special instructions
					list.Add(Side.ToString());
				}
				else
				{
					list.Add("Click Me To Add Side");
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
