/*
* Author: Samuel McGowan
* Class name: Menu.cs
* Purpose: To hold information for the static class Menu
* Last Modified: 11/5/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System.Linq;

namespace BleakwindBuffet.Data
{
	/// <summary>
	/// A static class representing the menu of Bleakwind Buffet
	/// </summary>
	public static class Menu
	{
		/// <summary>
		/// Returns a collection of all the entrees on the menu
		/// </summary>
		/// <returns>an IEnumerable that represents all the entrees on the menu</returns>
		public static IEnumerable<IOrderItem> Entrees()
		{
			yield return (new BriarheartBurger());
			yield return (new DoubleDraugr());
			yield return (new GardenOrcOmelette());
			yield return (new PhillyPoacher());
			yield return (new SmokehouseSkeleton());
			yield return (new ThalmorTriple());
			yield return (new ThugsTBone());
		}

		/// <summary>
		/// Returns a collection of all the sides on the menu with 3 of each side to represent the sizes
		/// </summary>
		/// <returns>an IEnumerable that represents all the sides on the menu</returns>
		public static IEnumerable<IOrderItem> Sides()
		{
			yield return (new DragonbornWaffleFries() { Size = Enums.Size.Small });
			yield return (new DragonbornWaffleFries() { Size = Enums.Size.Medium });
			yield return (new DragonbornWaffleFries() { Size = Enums.Size.Large });

			yield return (new FriedMiraak() { Size = Enums.Size.Small });
			yield return (new FriedMiraak() { Size = Enums.Size.Medium });
			yield return (new FriedMiraak() { Size = Enums.Size.Large });

			yield return (new MadOtarGrits() { Size = Enums.Size.Small });
			yield return (new MadOtarGrits() { Size = Enums.Size.Medium });
			yield return (new MadOtarGrits() { Size = Enums.Size.Large });

			yield return (new VokunSalad() { Size = Enums.Size.Small });
			yield return (new VokunSalad() { Size = Enums.Size.Medium });
			yield return (new VokunSalad() { Size = Enums.Size.Large });
		}

		/// <summary>
		/// Returns a collection of all the sides on the menu with 3 of each drink to represent the sizes and all the flavors of sailor soda
		/// </summary>
		/// <returns>an IEnumerable that represents all the drinks on the menu</returns>
		public static IEnumerable<IOrderItem> Drinks()
		{
			yield return (new AretinoAppleJuice() { Size = Enums.Size.Small });
			yield return (new AretinoAppleJuice() { Size = Enums.Size.Medium });
			yield return (new AretinoAppleJuice() { Size = Enums.Size.Large });

			yield return (new CandlehearthCoffee() { Size = Enums.Size.Small });
			yield return (new CandlehearthCoffee() { Size = Enums.Size.Medium });
			yield return (new CandlehearthCoffee() { Size = Enums.Size.Large });

			yield return (new MarkarthMilk() { Size = Enums.Size.Small });
			yield return (new MarkarthMilk() { Size = Enums.Size.Medium });
			yield return (new MarkarthMilk() { Size = Enums.Size.Large });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Blackberry });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Blackberry });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Blackberry });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Cherry });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Cherry });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Cherry });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Grapefruit });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Grapefruit });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Grapefruit });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Lemon });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Lemon });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Lemon });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Peach });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Peach });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Peach });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Watermelon });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Watermelon });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Watermelon });

			yield return (new WarriorWater() { Size = Enums.Size.Small });
			yield return (new WarriorWater() { Size = Enums.Size.Medium });
			yield return (new WarriorWater() { Size = Enums.Size.Large });
		}

		/// <summary>
		/// Returns a collection of everything on the menu
		/// </summary>
		/// <returns>an IEnumerable that represents everything on the menu</returns>
		public static IEnumerable<IOrderItem> FullMenu()
		{
			// Entrees
			yield return (new BriarheartBurger());
			yield return (new DoubleDraugr());
			yield return (new GardenOrcOmelette());
			yield return (new PhillyPoacher());
			yield return (new SmokehouseSkeleton());
			yield return (new ThalmorTriple());
			yield return (new ThugsTBone());

			// Sides
			yield return (new DragonbornWaffleFries() { Size = Enums.Size.Small });
			yield return (new DragonbornWaffleFries() { Size = Enums.Size.Medium });
			yield return (new DragonbornWaffleFries() { Size = Enums.Size.Large });

			yield return (new FriedMiraak() { Size = Enums.Size.Small });
			yield return (new FriedMiraak() { Size = Enums.Size.Medium });
			yield return (new FriedMiraak() { Size = Enums.Size.Large });

			yield return (new MadOtarGrits() { Size = Enums.Size.Small });
			yield return (new MadOtarGrits() { Size = Enums.Size.Medium });
			yield return (new MadOtarGrits() { Size = Enums.Size.Large });

			yield return (new VokunSalad() { Size = Enums.Size.Small });
			yield return (new VokunSalad() { Size = Enums.Size.Medium });
			yield return (new VokunSalad() { Size = Enums.Size.Large });

			// Drinks
			yield return (new AretinoAppleJuice() { Size = Enums.Size.Small });
			yield return (new AretinoAppleJuice() { Size = Enums.Size.Medium });
			yield return (new AretinoAppleJuice() { Size = Enums.Size.Large });

			yield return (new CandlehearthCoffee() { Size = Enums.Size.Small });
			yield return (new CandlehearthCoffee() { Size = Enums.Size.Medium });
			yield return (new CandlehearthCoffee() { Size = Enums.Size.Large });

			yield return (new MarkarthMilk() { Size = Enums.Size.Small });
			yield return (new MarkarthMilk() { Size = Enums.Size.Medium });
			yield return (new MarkarthMilk() { Size = Enums.Size.Large });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Blackberry });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Blackberry });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Blackberry });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Cherry });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Cherry });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Cherry });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Grapefruit });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Grapefruit });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Grapefruit });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Lemon });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Lemon });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Lemon });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Peach });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Peach });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Peach });

			yield return (new SailorSoda() { Size = Enums.Size.Small, Flavor = Enums.SodaFlavor.Watermelon });
			yield return (new SailorSoda() { Size = Enums.Size.Medium, Flavor = Enums.SodaFlavor.Watermelon });
			yield return (new SailorSoda() { Size = Enums.Size.Large, Flavor = Enums.SodaFlavor.Watermelon });

			yield return (new WarriorWater() { Size = Enums.Size.Small });
			yield return (new WarriorWater() { Size = Enums.Size.Medium });
			yield return (new WarriorWater() { Size = Enums.Size.Large });
		}

		/// <summary>
		/// Filters the provided collection of menu items
		/// to those of the given categories
		/// </summary>
		/// <param name="menu">The collection of to filter</param>
		/// <param name="category">The categories to filter</param>
		/// <returns>The filtered collection</returns>
		public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> menu, IEnumerable<string> category)
		{
			// If no category is specified, just return the provided collection
			if (category == null || category.Count() == 0) return menu;

			// Filter the supplied collection of items
			List<IOrderItem> results = new List<IOrderItem>();
			foreach (IOrderItem item in menu)
			{
				if (item is Entree && category.Contains("Entree"))
				{
					results.Add(item);
				}
				else if (item is Side && category.Contains("Side"))
				{
					results.Add(item);
				}
				else if (item is Drink && category.Contains("Drink"))
				{
					results.Add(item);
				}
			}
			return results;
		}

		/// <summary>
		/// Filters the provided collection of menu items
		/// to those of the given min and max calories
		/// </summary>
		/// <param name="menu">The collection of to filter</param>
		/// <param name="min">The minimum number of calories to filter</param>
		/// <param name="max">The maximum number of calories to filter</param>
		/// <returns>The filtered collection</returns>
		public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> menu, int? min, int? max)
		{
			if (min == null && max == null) return menu;

			var results = new List<IOrderItem>();

			// only a maximum specified
			if (min == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Calories <= max) results.Add(item);
				}
				return results;
			}

			// only a minimum specified
			if (max == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Calories >= min) results.Add(item);
				}
				return results;
			}

			// Both minimum and maximum specified
			foreach (IOrderItem item in menu)
			{
				if (item.Calories >= min && item.Calories <= max)
				{
					results.Add(item);
				}
			}
			return results;
		}

		/// <summary>
		/// Filters the provided collection of menu items
		/// to those of the given min and max price
		/// </summary>
		/// <param name="menu">The collection of to filter</param>
		/// <param name="min">The minimum number of calories to filter</param>
		/// <param name="max">The maximum number of calories to filter</param>
		/// <returns>The filtered collection</returns>
		public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> menu, double? min, double? max)
		{
			if (min == null && max == null) return menu;

			var results = new List<IOrderItem>();

			// only a maximum specified
			if (min == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Price <= max) results.Add(item);
				}
				return results;
			}

			// only a minimum specified
			if (max == null)
			{
				foreach (IOrderItem item in menu)
				{
					if (item.Price >= min) results.Add(item);
				}
				return results;
			}

			// Both minimum and maximum specified
			foreach (IOrderItem item in menu)
			{
				if (item.Price >= min && item.Price <= max)
				{
					results.Add(item);
				}
			}
			return results;
		}

		/// <summary>
		/// Searches the menu for matches
		/// </summary>
		/// <param name="terms">The name to search for</param>
		/// <returns>The results of the search</returns>
		public static IEnumerable<IOrderItem> Search(string name)
		{
			List<IOrderItem> results = new List<IOrderItem>();

			// Null check
			if (name == null)
			{
				return (FullMenu());
			}

			foreach (IOrderItem item in FullMenu())
			{
				// Add the item if the name is a match
				if (item.ToString() != null && item.ToString().Contains(name))
				{
					results.Add(item);
				}
			}

			return (results);
		}
	}
}
