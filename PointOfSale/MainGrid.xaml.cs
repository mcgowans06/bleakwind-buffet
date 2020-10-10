/*
* Author: Samuel McGowan
* Class name: MainGrid.xaml.cs
* Purpose: To hold information for the partial MainGrid partial class and to assign event handlers to all buttons
* Last Modified: 10/2/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PointOfSale.SpecialInstructions;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;


namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for MainGrid.xaml
	/// </summary>
	public partial class MainGrid : UserControl
	{
		// Create all the various user controls 
		MenuSelectionScreen menuSelect = new MenuSelectionScreen();
		EntreeMenu entreeMenu = new EntreeMenu();
		DrinkMenu drinkMenu = new DrinkMenu();
		SideMenu sideMenu = new SideMenu();
		BriarheartBurgerInstructions briarheartBurger = new BriarheartBurgerInstructions();
		DoubleDraugrInstructions doubleDraugr = new DoubleDraugrInstructions();
		ThalmorTripleInstructions thalmorTriple = new ThalmorTripleInstructions();
		SmokehouseSkeletonInstructions smokehouseSkeleton = new SmokehouseSkeletonInstructions();
		GardenOrcOmeletteInstructions gardenOrcOmelette = new GardenOrcOmeletteInstructions();
		PhillyPoacherInstructions phillyPoacher = new PhillyPoacherInstructions();
		CandlehearthCoffeeInstructions candlehearthCoffee = new CandlehearthCoffeeInstructions();
		SailorSodaInstructions sailorSoda = new SailorSodaInstructions();
		DrinkSpecialInstructions milkInstructions = new DrinkSpecialInstructions("milk");
		DrinkSpecialInstructions applejuiceInstructions = new DrinkSpecialInstructions("applejuice");
		WarriorWaterInstructions waterInstructions = new WarriorWaterInstructions();
		SideSpecialInstructions dragonbornInstructions = new SideSpecialInstructions("dragonborn");
		SideSpecialInstructions miraakInstructions = new SideSpecialInstructions("miraak");
		SideSpecialInstructions saladInstructions = new SideSpecialInstructions("salad");
		SideSpecialInstructions gritsInstructions = new SideSpecialInstructions("grits");

		public MainGrid()
		{
			InitializeComponent();
			// Start with the main menu
			mainGrid.Children.Add(menuSelect);

			// I just want to mention that i accidentally created a perfect diagonal here. Am i awesome at naming things or what
			// Add event handlers to buttons
			menuSelect.entreesButton.Click += GoToEntreeMenu;
			menuSelect.drinksButton.Click += GoToDrinkMenu;
			menuSelect.sidesButton.Click += GoToSideMenu;
			entreeMenu.backButton.Click += BackButtonClick;
			drinkMenu.backButton.Click += BackButtonClick;
			sideMenu.backButton.Click += BackButtonClick;

			// Done button event handlers for the special instructions user controls
			briarheartBurger.doneButton.Click += DoneButtonClick;
			doubleDraugr.doneButton.Click += DoneButtonClick;
			thalmorTriple.doneButton.Click += DoneButtonClick;
			smokehouseSkeleton.doneButton.Click += DoneButtonClick;
			gardenOrcOmelette.doneButton.Click += DoneButtonClick;
			phillyPoacher.doneButton.Click += DoneButtonClick;
			candlehearthCoffee.doneButton.Click += DoneButtonClick;
			sailorSoda.doneButton.Click += DoneButtonClick;
			milkInstructions.doneButton.Click += DoneButtonClick;
			applejuiceInstructions.doneButton.Click += DoneButtonClick;
			waterInstructions.doneButton.Click += DoneButtonClick;
			dragonbornInstructions.doneButton.Click += DoneButtonClick;
			miraakInstructions.doneButton.Click += DoneButtonClick;
			saladInstructions.doneButton.Click += DoneButtonClick;
			gritsInstructions.doneButton.Click += DoneButtonClick;

			orderScreen.cancelButton.Click += CancelButtonClick;

			// Entree menu event handlers to go to special instructions
			entreeMenu.briarheartButton.Click += GoToBriarheartInstructions;
			entreeMenu.draugrButton.Click += GoToDraugrInstructions;
			entreeMenu.thalmorButton.Click += GoToThalmorInstructions;
			entreeMenu.smokehouseButton.Click += GoToSmokehouseInstructions;
			entreeMenu.orcButton.Click += GoToGardenOrcInstructions;
			entreeMenu.phillyButton.Click += GoToPhillyPoacherInstructions;
			entreeMenu.tboneButton.Click += AddThugsTBone;

			// Drink menu event handlers to go to the special instructions
			drinkMenu.sodaButton.Click += GoToSailorSodaInstructions;
			drinkMenu.coffeeButton.Click += GoToCandlehearthInstructions;
			drinkMenu.milkButton.Click += GoToMarkarthMilkInstructions;
			drinkMenu.applejuiceButton.Click += GoToAretinoAppleJuiceInstructions;
			drinkMenu.waterButton.Click += GoToWarriorWaterInstructions;

			// Side menu event handlers to go to the special instructions
			sideMenu.saladButton.Click += GoToVokunSaladInstructions;
			sideMenu.miraakButton.Click += GoToFriedMiraakInstructions;
			sideMenu.gritsButton.Click += GoToMadOtarGritsInstructions;
			sideMenu.friesButton.Click += GoToDragonbornWaffleFriesInstructions;

			orderScreen.orderList.SelectionChanged += GoToSelectedScreen;

			this.DataContext = new Order();
		}

		/// <summary>
		/// Cancels the current order and creates a new order
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void CancelButtonClick(object sender, RoutedEventArgs e)
		{
			this.DataContext = new Order();
		}

		/// <summary>
		/// Event handler for the back buttons
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void BackButtonClick(object sender, RoutedEventArgs e)
		{
			GoToMenuSelection();
		}

		/// <summary>
		/// Event handler for the done buttons
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void DoneButtonClick(object sender, RoutedEventArgs e)
		{
			GoToMenuSelection();
		}

		/// <summary>
		/// Go to the selected screen
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSelectedScreen(object sender, SelectionChangedEventArgs e)
		{
			if(((ListView)sender).SelectedItem is BriarheartBurger)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(briarheartBurger);
			}
			else if (((ListView)sender).SelectedItem is DoubleDraugr)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(doubleDraugr);
			}
			else if (((ListView)sender).SelectedItem is GardenOrcOmelette)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(gardenOrcOmelette);
			}
			else if (((ListView)sender).SelectedItem is PhillyPoacher)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(phillyPoacher);
			}
			else if (((ListView)sender).SelectedItem is SmokehouseSkeleton)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(smokehouseSkeleton);
			}
			else if (((ListView)sender).SelectedItem is ThalmorTriple)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(thalmorTriple);
			}
			else if (((ListView)sender).SelectedItem is AretinoAppleJuice)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(applejuiceInstructions);
			}
			else if (((ListView)sender).SelectedItem is CandlehearthCoffee)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(candlehearthCoffee);
			}
			else if (((ListView)sender).SelectedItem is MarkarthMilk)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(milkInstructions);
			}
			else if (((ListView)sender).SelectedItem is SailorSoda)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(sailorSoda);
			}
			else if (((ListView)sender).SelectedItem is WarriorWater)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(waterInstructions);
			}
			else if (((ListView)sender).SelectedItem is DragonbornWaffleFries)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(dragonbornInstructions);
			}
			else if (((ListView)sender).SelectedItem is FriedMiraak)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(miraakInstructions);
			}
			else if (((ListView)sender).SelectedItem is MadOtarGrits)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(gritsInstructions);
			}
			else if (((ListView)sender).SelectedItem is VokunSalad)
			{
				mainGrid.Children.RemoveAt(1);
				mainGrid.Children.Add(saladInstructions);
			}
		}

		/// <summary>
		/// Goes to the main menu
		/// </summary>
		void GoToMenuSelection()
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(menuSelect);
		}

		/// <summary>
		/// Event handler that goes to the entree menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToEntreeMenu(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(entreeMenu);
		}

		/// <summary>
		/// Event handler that Goes to the drink menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToDrinkMenu(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(drinkMenu);
		}

		/// <summary>
		/// Event handler that Goes to the side menu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSideMenu(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(sideMenu);
		}
		
		/// <summary>
		/// Event handler that Goes to the Dragonborn Waffle Fries instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToDragonbornWaffleFriesInstructions(object sender, RoutedEventArgs e)
		{
			DragonbornWaffleFries dwf = new DragonbornWaffleFries();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(dragonbornInstructions);
			dragonbornInstructions.DataContext = dwf;
			((Order)this.DataContext).Add(dwf);
		}
		/// <summary>
		/// Event handler that Goes to the Fried Miraak special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToFriedMiraakInstructions(object sender, RoutedEventArgs e)
		{
			FriedMiraak fm = new FriedMiraak();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(miraakInstructions);
			miraakInstructions.DataContext = fm;
			((Order)this.DataContext).Add(fm);
		}
		/// <summary>
		/// Event handler that Goes to the Vokun Salad special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToVokunSaladInstructions(object sender, RoutedEventArgs e)
		{
			VokunSalad vs = new VokunSalad();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(saladInstructions);
			saladInstructions.DataContext = vs;
			((Order)this.DataContext).Add(vs);
		}
		/// <summary>
		/// Event handler that Goes to the Mad Otar Grits special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToMadOtarGritsInstructions(object sender, RoutedEventArgs e)
		{
			MadOtarGrits mog = new MadOtarGrits();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(gritsInstructions);
			gritsInstructions.DataContext = mog;
			((Order)this.DataContext).Add(mog);
		}

		void AddThugsTBone(object sender, RoutedEventArgs e)
		{
			((Order)this.DataContext).Add(new ThugsTBone());
			GoToMenuSelection();
		}

		/// <summary>
		/// Event handler that Goes to the briarheart burger special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToBriarheartInstructions(object sender, RoutedEventArgs e)
		{
			BriarheartBurger bb = new BriarheartBurger();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(briarheartBurger);
			briarheartBurger.DataContext = bb;
			((Order)this.DataContext).Add(bb);
		}

		/// <summary>
		/// Event handler that goes to the double draugr special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToDraugrInstructions(object sender, RoutedEventArgs e)
		{
			DoubleDraugr dd = new DoubleDraugr();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(doubleDraugr);
			doubleDraugr.DataContext = dd;
			((Order)this.DataContext).Add(dd);
		}

		/// <summary>
		/// Event handler that goes to the thalmor triple special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToThalmorInstructions(object sender, RoutedEventArgs e)
		{
			ThalmorTriple tt = new ThalmorTriple();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(thalmorTriple);
			thalmorTriple.DataContext = tt;
			((Order)this.DataContext).Add(tt);
		}

		/// <summary>
		/// Event handler that goes to the smokehouse skeleton special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSmokehouseInstructions(object sender, RoutedEventArgs e)
		{
			SmokehouseSkeleton ss = new SmokehouseSkeleton();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(smokehouseSkeleton);
			smokehouseSkeleton.DataContext = ss;
			((Order)this.DataContext).Add(ss);
		}

		/// <summary>
		/// Event handler that goes to the garden orc omelette special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToGardenOrcInstructions(object sender, RoutedEventArgs e)
		{
			GardenOrcOmelette goo = new GardenOrcOmelette();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(gardenOrcOmelette);
			gardenOrcOmelette.DataContext = goo;
			((Order)this.DataContext).Add(goo);
		}

		/// <summary>
		/// Event handler that goes to the philly poacher special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToPhillyPoacherInstructions(object sender, RoutedEventArgs e)
		{
			PhillyPoacher pp = new PhillyPoacher();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(phillyPoacher);
			phillyPoacher.DataContext = pp;
			((Order)this.DataContext).Add(pp);
		}

		/// <summary>
		/// Event handler that goes to the sailor soda special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSailorSodaInstructions(object sender, RoutedEventArgs e)
		{
			SailorSoda ss = new SailorSoda();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(sailorSoda);
			sailorSoda.DataContext = ss;
			((Order)this.DataContext).Add(ss);
		}

		/// <summary>
		/// Event handler that goes to the candlehearth coffee special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToCandlehearthInstructions(object sender, RoutedEventArgs e)
		{
			CandlehearthCoffee cc = new CandlehearthCoffee();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(candlehearthCoffee);
			candlehearthCoffee.DataContext = cc;
			((Order)this.DataContext).Add(cc);
		}

		/// <summary>
		/// Event handler that goes to the Markarth Milk instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToMarkarthMilkInstructions(object sender, RoutedEventArgs e)
		{
			MarkarthMilk mm = new MarkarthMilk();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(milkInstructions);
			milkInstructions.DataContext = mm;
			((Order)this.DataContext).Add(mm);
		}

		/// <summary>
		/// Event handler that goes to the Aretino Apple Juice instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToAretinoAppleJuiceInstructions(object sender, RoutedEventArgs e)
		{
			AretinoAppleJuice aa = new AretinoAppleJuice();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(applejuiceInstructions);
			applejuiceInstructions.DataContext = aa;
			((Order)this.DataContext).Add(aa);
		}

		/// <summary>
		/// Event handler that goes to the Warrior Water instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToWarriorWaterInstructions(object sender, RoutedEventArgs e)
		{
			WarriorWater ww = new WarriorWater();
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(waterInstructions);
			waterInstructions.DataContext = ww;
			((Order)this.DataContext).Add(ww);
		}

	}
}
