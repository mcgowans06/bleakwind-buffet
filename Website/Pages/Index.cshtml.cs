/*
* Author: Samuel McGowan
* Class name: IndexModel.cs
* Purpose: The model for the Index.cshtml website page
* Last Modified: 11/5/20
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
		private IEnumerable<IOrderItem> MenuList { get; set; }

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
			MenuList = Menu.FilterByCategory(Menu.Search(SearchTerms), Categories);
			MenuList = Menu.FilterByCalories(MenuList, CalorieMin, CalorieMax);
			MenuList = Menu.FilterByPrice(MenuList, PriceMin, PriceMax);
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
					listOfEntrees += entree.ToString();
					listOfEntrees += " $" + entree.Price;
					listOfEntrees += " Calories: " + entree.Calories + "\n";
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
			string listOfEntrees = "";
			foreach (IOrderItem drink in MenuList)
			{
				if(drink is Drink)
				{
					// Display Name
					listOfEntrees += drink.ToString();
					listOfEntrees += " $" + drink.Price;
					listOfEntrees += " Calories: " + drink.Calories + "\n";
				}
			}
			return (listOfEntrees);
		}

		/// <summary>
		/// Display all the sides along with their price and calorie count
		/// </summary>
		/// <returns>A string with all of the sides</returns>
		public string DisplaySides()
		{
			string listOfEntrees = "";
			foreach (IOrderItem side in MenuList)
			{
				if(side is Side)
				{
					// Display Name
					listOfEntrees += side.ToString();
					listOfEntrees += " $" + side.Price;
					listOfEntrees += " Calories: " + side.Calories + "\n";
				}
			}
			return (listOfEntrees);
		}
	}
}
