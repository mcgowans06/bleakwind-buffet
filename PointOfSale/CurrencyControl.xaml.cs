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
	/// Interaction logic for CurrencyControl.xaml
	/// </summary>
	public partial class CurrencyControl : UserControl
	{
		/// <summary>
		/// A dependency property representing the currency value this control represents
		/// </summary>
		public static DependencyProperty CurrencyValueProperty = DependencyProperty.Register("CurrencyValue", typeof(string), typeof(CurrencyControl), new FrameworkPropertyMetadata("", FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

		public static DependencyProperty CurrencyTypeProperty = DependencyProperty.Register("CurrencyType", typeof(char), typeof(CurrencyControl));

		/// <summary>
		/// The type of the currency that this control represents
		/// </summary>
		public char CurrencyType
		{
			get { return ((char)GetValue(CurrencyTypeProperty)); }
			set { SetValue(CurrencyTypeProperty, value); }
		}

		/// <summary>
		/// The value of the currency that this control represents
		/// </summary>
		public string CurrencyValue
		{
			get { return ((string)GetValue(CurrencyValueProperty)); }
			set 
			{ 
				SetValue(CurrencyValueProperty, value);
			}
		}

		/// <summary>
		/// The amount of currency that the customer is paying with
		/// </summary>
		public int CustomerQuantity
		{
			get { return ((int)GetValue(CustomerQuantityProperty)); }
			set { SetValue(CustomerQuantityProperty, value); }
		}

		/// <summary>
		/// The amount of change that the customer is getting back
		/// </summary>
		public int ChangeQuantity
		{
			get { return ((int)GetValue(ChangeQuantityProperty)); }
			set { SetValue(ChangeQuantityProperty, value); }
		}

		public CurrencyControl()
		{
			InitializeComponent();
		}

		void PlusButtonClick(object sender, RoutedEventArgs e)
		{
			CustomerQuantity++;
			e.Handled = true;
		}

		void MinusButtonClick(object sender, RoutedEventArgs e)
		{
			if(CustomerQuantity > 0) CustomerQuantity--;
			e.Handled = true;
		}
	}
}
