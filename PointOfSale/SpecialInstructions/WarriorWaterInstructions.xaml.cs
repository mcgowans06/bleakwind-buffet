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
	/// Interaction logic for WarriorWaterInstructions.xaml
	/// </summary>
	public partial class WarriorWaterInstructions : UserControl
	{
		public WarriorWaterInstructions()
		{
			InitializeComponent();
			this.DataContext = new WarriorWater();
		}
	}
}
