/*
* Author: Samuel McGowan
* Class name: SideSpecialInstructions.xaml.cs
* Purpose: To initialize the SideSpecialInstructions component
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
using BleakwindBuffet.Data.Sides;

namespace PointOfSale.SpecialInstructions
{
	/// <summary>
	/// Interaction logic for SideSpecialInstructions.xaml
	/// </summary>
	public partial class SideSpecialInstructions : UserControl
	{
		public SideSpecialInstructions(string side)
		{
			InitializeComponent();
			switch (side)
			{
				case "dragonborn":
					this.DataContext = new DragonbornWaffleFries();
					break;
				case "miraak":
					this.DataContext = new FriedMiraak();
					break;
				case "salad":
					this.DataContext = new VokunSalad();
					break;
				case "grits":
					this.DataContext = new MadOtarGrits();
					break;
				default:
					throw new NotImplementedException("Should never be reached");
			}
		}
	}
}
