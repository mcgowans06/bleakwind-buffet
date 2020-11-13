/*
* Author: Samuel McGowan
* Class name: IndexModel.cs
* Purpose: The model for the Index.cshtml website page
* Last Modified: 11/13/20
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

namespace Website.Pages
{
	/// <summary>
	/// The model for the Index website page
	/// </summary>
	public class IndexModel : PageModel
	{
		private readonly ILogger<IndexModel> _logger;

		/// <summary>
		/// The current filtered menu list
		/// </summary>
		public IEnumerable<IOrderItem> MenuList { get; set; } = Menu.FullMenu();

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		/// <summary>
		/// The terms to serach for
		/// </summary>
		[FromQuery(Name = "SearchTerms")]
		public string SearchTerms { get; set; }

		/// <summary>
		/// The filtered categories
		/// </summary>
		[FromQuery(Name = "Category")]
		public string[] Categories { get; set; }

		/// <summary>
		/// The minimum price to filter for
		/// </summary>
		[FromQuery(Name = "PriceMin")]
		public double? PriceMin { get; set; }

		/// <summary>
		/// The maximum price to filter for
		/// </summary>
		[FromQuery(Name = "PriceMax")]
		public double? PriceMax { get; set; }

		/// <summary>
		/// The minimum calorie to filter for
		/// </summary>
		[FromQuery(Name = "CalorieMin")]
		public int? CalorieMin { get; set; }

		/// <summary>
		/// The maximum calorie to filter for
		/// </summary>
		[FromQuery(Name = "CalorieMax")]
		public int? CalorieMax { get; set; }

		public void OnGet()
		{
			// Filter by search terms
			if (SearchTerms != null)
			{		
				MenuList = Menu.FullMenu().Where(item => (item.ToString() != null && item.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)) || (item.Description != null && item.Description.Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase)));
				if(MenuList.Count() == 0)
				{
					string[] terms = SearchTerms.Split(' ');
					foreach (string s in terms)
					{
						if(MenuList.Count() > 0)
						{
							IEnumerable<IOrderItem> newList = Menu.FullMenu().Where(item => (item.ToString() != null && item.ToString().Contains(s, StringComparison.InvariantCultureIgnoreCase)) || (item.Description != null && item.Description.Contains(s, StringComparison.InvariantCultureIgnoreCase)));
							MenuList = MenuList.Concat(newList);
						}
						else
						{
							MenuList = Menu.FullMenu().Where(item => (item.ToString() != null && item.ToString().Contains(s, StringComparison.InvariantCultureIgnoreCase)) || (item.Description != null && item.Description.Contains(s, StringComparison.InvariantCultureIgnoreCase)));
						}
					}
				}
			}
			// Filter by category
			if(!(Categories == null || Categories.Count() == 0))
			{
				MenuList = MenuList.Where(item => (item is Entree && Categories.Contains("Entree")) || (item is Drink && Categories.Contains("Drink")) || (item is Side && Categories.Contains("Side")));
			}
			// Filter by calories
			if (CalorieMin != null || CalorieMax != null)
			{
				if (CalorieMin == null)
				{
					MenuList = MenuList.Where(item => item.Calories <= CalorieMax);
				}
				else if (CalorieMax == null)
				{
					MenuList = MenuList.Where(item => item.Calories >= CalorieMin);
				}
				else
				{
					MenuList = MenuList.Where(item => item.Calories >= CalorieMin && item.Calories <= CalorieMax);
				}
			}
			// Filter by price
			if (PriceMin != null || PriceMax != null)
			{
				if (PriceMin == null)
				{
					MenuList = MenuList.Where(item => item.Price <= PriceMax);
				}
				else if (PriceMax == null)
				{
					MenuList = MenuList.Where(item => item.Price >= PriceMin);
				}
				else
				{
					MenuList = MenuList.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
				}
			}
			//MenuList = Menu.FilterByCategory(Menu.Search(SearchTerms), Categories);
			//MenuList = Menu.FilterByCalories(MenuList, CalorieMin, CalorieMax);
			//MenuList = Menu.FilterByPrice(MenuList, PriceMin, PriceMax);
		}

		/// <summary>
		/// Display all the entrees along with their price and calorie count
		/// </summary>
		/// <returns>A string with all of the entrees</returns>
		public string DisplayEntrees()
		{
			string listOfEntrees = "";
			foreach(IOrderItem entree in MenuList)
			{
				if(entree is Entree)
				{
					// Display Name
					listOfEntrees += "<b>" + entree.ToString() + "</b>";
					listOfEntrees += " \n$" + entree.Price;
					listOfEntrees += " Calories: " + entree.Calories + "\n";
					listOfEntrees += "<i>" + entree.Description + "</i>\n\n";
				}
			}
			return (listOfEntrees);
		}

		/// <summary>
		/// Display all the drinks along with their price and calorie count
		/// </summary>
		/// <returns>A string with all of the drinks</returns>
		public string DisplayDrinks()
		{
			string listOfDrinks = "";
			foreach (IOrderItem drink in MenuList)
			{
				if(drink is Drink)
				{
					// Display Name
					listOfDrinks += "<b>" + drink.ToString() + "</b>";
					listOfDrinks += " \n$" + drink.Price;
					listOfDrinks += " Calories: " + drink.Calories + "\n";
					listOfDrinks += "<i>" + drink.Description + "</i>\n\n";
				}
			}
			return (listOfDrinks);
		}

		/// <summary>
		/// Display all the sides along with their price and calorie count
		/// </summary>
		/// <returns>A string with all of the sides</returns>
		public string DisplaySides()
		{
			string listOfSides = "";
			foreach (IOrderItem side in MenuList)
			{
				if(side is Side)
				{
					// Display Name
					listOfSides += "<b>" + side.ToString() + "</b>";
					listOfSides += " \n$" + side.Price;
					listOfSides += " Calories: " + side.Calories + "\n";
					listOfSides += "<i>" + side.Description + "</i>\n\n";
				}
			}
			return (listOfSides);
		}
	}
}
