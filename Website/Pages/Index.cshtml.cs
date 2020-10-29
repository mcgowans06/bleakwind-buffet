/*
* Author: Samuel McGowan
* Class name: IndexModel.cs
* Purpose: The model for the Index.cshtml website page
* Last Modified: 10/29/20
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

		public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{

		}

		/// <summary>
		/// Display all the entrees along with their price and calorie count
		/// </summary>
		/// <returns>A string with all of the entrees</returns>
		public string DisplayEntrees()
		{
			string listOfEntrees = "";
			foreach(Entree entree in Menu.Entrees())
			{
				// Display Name
				listOfEntrees += entree.ToString();
				listOfEntrees += " $" + entree.Price;
				listOfEntrees += " Calories: " + entree.Calories + "\n";
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
			foreach (Drink drink in Menu.Drinks())
			{
				// Display Name
				listOfEntrees += drink.ToString();
				listOfEntrees += " $" + drink.Price;
				listOfEntrees += " Calories: " + drink.Calories + "\n";
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
			foreach (Side side in Menu.Sides())
			{
				// Display Name
				listOfEntrees += side.ToString();
				listOfEntrees += " $" + side.Price;
				listOfEntrees += " Calories: " + side.Calories + "\n";
			}
			return (listOfEntrees);
		}
	}
}
