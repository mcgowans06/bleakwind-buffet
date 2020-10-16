/*
* Author: Samuel McGowan
* Class name: EntreeMenu.xaml.cs
* Purpose: To initialize the EntreeMenu component
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

namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for EntreeMenu.xaml
	/// </summary>
	public partial class EntreeMenu : UserControl
	{
		/// <summary>
		/// vool that represents whether or not we entered the menu from a combo
		/// </summary>
		public bool FromCombo { get; set; } = false;

		public EntreeMenu()
		{
			InitializeComponent();
		}
	}
}
