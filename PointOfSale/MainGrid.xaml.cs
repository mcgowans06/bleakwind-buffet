/*
* Author: Samuel McGowan
* Class name: MainGrid.xaml.cs
* Purpose: To hold information for the partial MainGrid partial class and to assign event handlers to all buttons
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
		CandlehearthCoffeeInstructions candlehearthCoffee = new CandlehearthCoffeeInstructions();
		SailorSodaInstructions sailorSoda = new SailorSodaInstructions();
		DrinkSpecialInstructions drinkInstructions = new DrinkSpecialInstructions();
		SideSpecialInstructions sideInstructions = new SideSpecialInstructions();

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
			candlehearthCoffee.doneButton.Click += DoneButtonClick;
			sailorSoda.doneButton.Click += DoneButtonClick;
			drinkInstructions.doneButton.Click += DoneButtonClick;
			sideInstructions.doneButton.Click += DoneButtonClick;

			// Entree menu event handlers to go to special instructions
			entreeMenu.briarheartButton.Click += GoToBriarheartInstructions;
			entreeMenu.draugrButton.Click += GoToDraugrInstructions;
			entreeMenu.thalmorButton.Click += GoToThalmorInstructions;
			entreeMenu.smokehouseButton.Click += GoToSmokehouseInstructions;
			entreeMenu.orcButton.Click += GoToGardenOrcInstructions;

			// Drink menu event handlers to go to the special instructions
			drinkMenu.sodaButton.Click += GoToSailorSodaInstructions;
			drinkMenu.coffeeButton.Click += GoToCandlehearthInstructions;
			drinkMenu.milkButton.Click += GoToDrinkInstructions;
			drinkMenu.applejuiceButton.Click += GoToDrinkInstructions;
			drinkMenu.waterButton.Click += GoToDrinkInstructions;

			// Side menu event handlers to go to the special instructions
			sideMenu.saladButton.Click += GoToSideInstructions;
			sideMenu.miraakButton.Click += GoToSideInstructions;
			sideMenu.gritsButton.Click += GoToSideInstructions;
			sideMenu.friesButton.Click += GoToSideInstructions;

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
		/// Event handler that Goes to the side special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSideInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(sideInstructions);
		}

		/// <summary>
		/// Event handler that Goes to the briarheart burger special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToBriarheartInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(briarheartBurger);
		}

		/// <summary>
		/// Event handler that goes to the double draugr special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToDraugrInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(doubleDraugr);
		}

		/// <summary>
		/// Event handler that goes to the thalmor triple special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToThalmorInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(thalmorTriple);
		}

		/// <summary>
		/// Event handler that goes to the smokehouse skeleton special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSmokehouseInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(smokehouseSkeleton);
		}

		/// <summary>
		/// Event handler that goes to the garden orc omelette special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToGardenOrcInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(gardenOrcOmelette);
		}

		/// <summary>
		/// Event handler that goes to the sailor soda special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToSailorSodaInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(sailorSoda);
		}

		/// <summary>
		/// Event handler that goes to the candlehearth coffee special instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToCandlehearthInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(candlehearthCoffee);
		}

		/// <summary>
		/// Event handler that goes to the drink instructions
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void GoToDrinkInstructions(object sender, RoutedEventArgs e)
		{
			mainGrid.Children.RemoveAt(1);
			mainGrid.Children.Add(drinkInstructions);
		}

	}
}
