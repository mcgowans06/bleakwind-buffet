/*
* Author: Samuel McGowan
* Class name: Menu.cs
* Purpose: To hold information for the static class Menu
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;

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
	}
}
