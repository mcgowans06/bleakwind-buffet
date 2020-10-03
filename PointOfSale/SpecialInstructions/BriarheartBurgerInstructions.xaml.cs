/*
* Author: Samuel McGowan
* Class name: BriarheartBurgerInstructions.xaml.cs
* Purpose: To initialize the BriarheartBurgerInstructions component
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
using BleakwindBuffet.Data.Entrees;

namespace PointOfSale.SpecialInstructions
{
	/// <summary>
	/// Interaction logic for BriarheartBurgerInstructions.xaml
	/// </summary>
	public partial class BriarheartBurgerInstructions : UserControl
	{
		public BriarheartBurgerInstructions()
		{
			InitializeComponent();
			this.DataContext = new BriarheartBurger();
		}
	}
}
