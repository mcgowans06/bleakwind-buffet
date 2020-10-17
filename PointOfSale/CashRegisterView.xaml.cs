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

namespace PointOfSale
{
	/// <summary>
	/// Interaction logic for CashRegisterView.xaml
	/// </summary>
	public partial class CashRegisterView : UserControl
	{

		public CashRegisterView(Order order)
		{
			InitializeComponent();
			DataContext = new CashRegisterModelView(order);
		}

		/// <summary>
		/// Event handler for when the finalize button is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void FinalizeButtonClick(object sender, RoutedEventArgs e)
		{
			new ReceiptMaker(((CashRegisterModelView)this.DataContext).Order, ((CashRegisterModelView)this.DataContext).ChangeDue);
			((CashRegisterModelView)this.DataContext).OpenDrawer();
			((CashRegisterModelView)this.DataContext).MakeChange(((CashRegisterModelView)this.DataContext).ChangeDue);
		}
	}
}
