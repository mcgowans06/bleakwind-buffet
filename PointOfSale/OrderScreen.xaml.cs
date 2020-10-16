/*
* Author: Samuel McGowan
* Class name: OrderScreen.xaml.cs
* Purpose: To initialize the OrderScreen component
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
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for OrderScreen.xaml
	/// </summary>
	public partial class OrderScreen : UserControl
	{
		ListView specialInstructions;
		public ListView SpecialInstructions
		{
			get { return (specialInstructions); }
		}

		public OrderScreen()
		{
			InitializeComponent();
		}

		void ListSelectionLoaded(object sender, RoutedEventArgs e)
		{
			if(sender is ListView lw)
			{
				DependencyObject parent = this;
				do
				{
					parent = LogicalTreeHelper.GetParent(parent);
				}
				while(!(parent is null || parent is MainGrid));
				if(parent is MainGrid mainGrid)
				{
					lw.SelectionChanged += mainGrid.ComboSelection;
				}
			}
		}

		void RemoveButtonClick(object sender, RoutedEventArgs e)
		{
			if (((Button)sender).DataContext is Combo combo)
			{
				((Order)this.DataContext).Remove(combo);
			}
			else if (((Button)sender).DataContext is BriarheartBurger bb)
			{
				((Order)this.DataContext).Remove(bb);
			}
			else if (((Button)sender).DataContext is DoubleDraugr dd)
			{
				((Order)this.DataContext).Remove(dd);
			}
			else if (((Button)sender).DataContext is GardenOrcOmelette goo)
			{
				((Order)this.DataContext).Remove(goo);
			}
			else if (((Button)sender).DataContext is PhillyPoacher pp)
			{
				((Order)this.DataContext).Remove(pp);
			}
			else if (((Button)sender).DataContext is SmokehouseSkeleton ss)
			{
				((Order)this.DataContext).Remove(ss);
			}
			else if (((Button)sender).DataContext is ThalmorTriple tt)
			{
				((Order)this.DataContext).Remove(tt);
			}
			else if (((Button)sender).DataContext is ThugsTBone ttb)
			{
				((Order)this.DataContext).Remove(ttb);
			}
			else if (((Button)sender).DataContext is AretinoAppleJuice aa)
			{
				((Order)this.DataContext).Remove(aa);
			}
			else if (((Button)sender).DataContext is CandlehearthCoffee cc)
			{
				((Order)this.DataContext).Remove(cc);
			}
			else if (((Button)sender).DataContext is MarkarthMilk mm)
			{
				((Order)this.DataContext).Remove(mm);
			}
			else if (((Button)sender).DataContext is SailorSoda sss)
			{
				((Order)this.DataContext).Remove(sss);
			}
			else if (((Button)sender).DataContext is WarriorWater ww)
			{
				((Order)this.DataContext).Remove(ww);
			}
			else if (((Button)sender).DataContext is DragonbornWaffleFries dwf)
			{
				((Order)this.DataContext).Remove(dwf);
			}
			else if (((Button)sender).DataContext is FriedMiraak fm)
			{
				((Order)this.DataContext).Remove(fm);
			}
			else if (((Button)sender).DataContext is MadOtarGrits mog)
			{
				((Order)this.DataContext).Remove(mog);
			}
			else if (((Button)sender).DataContext is VokunSalad vs)
			{
				((Order)this.DataContext).Remove(vs);
			}
		}
	}
}
