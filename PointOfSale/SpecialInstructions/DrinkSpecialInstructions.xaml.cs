/*
* Author: Samuel McGowan
* Class name: DrinkSpecialInstructions.xaml.cs
* Purpose: To initialize the DrinkSpecialInstructions component
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
using BleakwindBuffet.Data.Drinks;

namespace PointOfSale.SpecialInstructions
{
	/// <summary>
	/// Interaction logic for DrinkSpecialInstructions.xaml
	/// </summary>
	public partial class DrinkSpecialInstructions : UserControl
	{
		public DrinkSpecialInstructions(string drink)
		{
			InitializeComponent();
			switch(drink)
			{
				case "milk":
					this.DataContext = new MarkarthMilk();
					break;
				case "applejuice":
					this.DataContext = new AretinoAppleJuice();
					break;
				case "water":
					this.DataContext = new WarriorWater();
					break;
				default:
					throw new NotImplementedException("Should never be reached");
			}
		}
	}
}
