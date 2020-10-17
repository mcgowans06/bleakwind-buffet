/*
* Author: Samuel McGowan
* Class name: Ordero.cs
* Purpose: To hold information for an order
* Last Modified: 10/2/20
*/


using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.Data
{
	/// <summary>
	/// Public class that represents an order
	/// </summary>
	public class Order : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
	{
		/// <summary>
		/// The list of items in the order
		/// </summary>
		List<IOrderItem> orderItems = new List<IOrderItem>();

		/// <summary>
		/// The next order number
		/// </summary>
		static uint nextOrderNumber = 1;

		/// <summary>
		/// Event handler for collection changed
		/// </summary>
		public event NotifyCollectionChangedEventHandler CollectionChanged;

		/// <summary>
		/// Event handler for property changed
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		/// <summary>
		/// The sales tax rate
		/// </summary>
		public double SalesTaxRate { get; set; } = .12;

		/// <summary>
		/// The subtotal
		/// </summary>
		public double Subtotal
		{
			get
			{
				double subtotal = 0;
				foreach(IOrderItem item in orderItems)
				{
					subtotal += item.Price;
				}
				subtotal = Math.Round(subtotal, 2);
				return (subtotal);
			}
		}

		/// <summary>
		/// The tax
		/// </summary>
		public double Tax
		{
			get
			{
				double tax = Subtotal * SalesTaxRate;
				tax = Math.Round(tax, 2);
				return (tax);
			}
		}

		/// <summary>
		/// The total cost of the order
		/// </summary>
		public double Total
		{
			get
			{
				double total = Subtotal + Tax;
				total = Math.Round(total, 2);
				return (total);
			}
		}

		/// <summary>
		/// The total calories of the order
		/// </summary>
		public uint Calories
		{
			get
			{
				uint calories = 0;
				foreach (IOrderItem item in orderItems)
				{
					calories += item.Calories;
				}
				return (calories);
			}
		}

		public List<IOrderItem> OrderItems
		{
			get
			{
				return (new List<IOrderItem>(orderItems));
			}
		}

		/// <summary>
		/// The unique order number
		/// </summary>
		public uint Number { get; private set; }

		/// <summary>
		/// Get the number of items currently in the order
		/// </summary>
		public int Count => orderItems.Count;

		public bool IsReadOnly => throw new NotImplementedException();

		/// <summary>
		/// Adds an item to the order list
		/// </summary>
		/// <param name="item">the item to add</param>
		public void Add(IOrderItem item)
		{
			if(!orderItems.Contains(item))
			{
				orderItems.Add(item);
				CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
				if(orderItems[Count-1] is Drink)
				{
					((Drink)orderItems[Count - 1]).PropertyChanged += OnPriceChanged;
					((Drink)orderItems[Count - 1]).PropertyChanged += OnCaloriesChanged;
				}
				else if (orderItems[Count - 1] is Side)
				{
					((Side)orderItems[Count - 1]).PropertyChanged += OnPriceChanged;
					((Side)orderItems[Count - 1]).PropertyChanged += OnCaloriesChanged;
				}
				else if(item is Combo)
				{
					((Combo)item).PropertyChanged += OnPriceChanged;
				}
			}
		}

		/// <summary>
		/// Removes an item from the order list
		/// </summary>
		/// <param name="item">the item to remove</param>
		public void Remove(IOrderItem item)
		{
			if (orderItems.Contains(item))
			{
				if (orderItems[orderItems.IndexOf(item)] is Drink)
				{
					((Drink)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnPriceChanged;
					((Drink)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnCaloriesChanged;
				}
				else if (orderItems[orderItems.IndexOf(item)] is Side)
				{
					((Side)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnPriceChanged;
					((Side)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnCaloriesChanged;
				}
				else if (item is Combo)
				{
					((Combo)item).PropertyChanged -= OnPriceChanged;
				}
				CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item, orderItems.IndexOf(item)));
				orderItems.Remove(item);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
			}
		}

		/// <summary>
		/// Clear the order
		/// </summary>
		public void Clear()
		{
			foreach(IOrderItem item in orderItems)
			{
				if (orderItems[orderItems.IndexOf(item)] is Drink)
				{
					((Drink)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnPriceChanged;
					((Drink)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnCaloriesChanged;
				}
				else if (orderItems[orderItems.IndexOf(item)] is Side)
				{
					((Side)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnPriceChanged;
					((Side)orderItems[orderItems.IndexOf(item)]).PropertyChanged -= OnCaloriesChanged;
				}
				else if (item is Combo)
				{
					((Combo)item).PropertyChanged -= OnPriceChanged;
				}
			}
			orderItems.Clear();
			CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
		}

		/// <summary>
		/// Check to see if the order contains the item
		/// </summary>
		/// <param name="item">the item to check for</param>
		/// <returns>true if contains, false if not in list</returns>
		public bool Contains(IOrderItem item)
		{
			return (orderItems.Contains(item));
		}

		public void CopyTo(IOrderItem[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Removes the item from the list
		/// </summary>
		/// <param name="item">The item to be removed</param>
		/// <returns>true if removed, false if not</returns>
		bool ICollection<IOrderItem>.Remove(IOrderItem item)
		{
			if (orderItems.Contains(item))
			{
				orderItems.Remove(item);
				return (true);
			}
			return (false);
		}

		/// <summary>
		/// Returns everything in the order list
		/// </summary>
		/// <returns>an IEnumerable that represents everything in the order</returns>
		public IEnumerator<IOrderItem> GetEnumerator()
		{
			return (orderItems.GetEnumerator());
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (orderItems.GetEnumerator());
		}

		/// <summary>
		/// Constructor for the order
		/// </summary>
		public Order()
		{
			Number = nextOrderNumber;
			nextOrderNumber++;
		}

		/// <summary>
		/// Event handler for when the price of a menu item changes
		/// </summary>
		/// <param name="sender">The menu item</param>
		/// <param name="e">The property that has changed</param>
		void OnPriceChanged(object sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "Price")
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
			}
		}

		/// <summary>
		/// Event handler for when the price of a menu item changes
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

		
	}
}
