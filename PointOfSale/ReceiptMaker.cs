/*
* Author: Samuel McGowan
* Class name: ReceiptMaker.cs
* Purpose: To print out a receipt given an order
* Last Modified: 10/16/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.Runtime;
using System.Globalization;

namespace PointOfSale
{
	/// <summary>
	/// This class prints out the receipt given an order
	/// </summary>
	public class ReceiptMaker
	{
		/// <summary>
		/// Constructor that creates a receipt for the given order if paid with card
		/// </summary>
		/// <param name="order">the order to print a receipt for</param>
		public ReceiptMaker(Order order)
		{
			// Print out order number
			RoundRegister.RecieptPrinter.PrintLine("Order #" + order.Number);

			// Print out the date and time
			RoundRegister.RecieptPrinter.PrintLine(DateTime.Now.ToString(new CultureInfo("en-US")));

			// Print out every item in the order and its special instructions
			foreach(IOrderItem item in order)
			{
				if(!(item is Combo)) RoundRegister.RecieptPrinter.PrintLine(item.ToString());
				foreach(string s in item.SpecialInstructions)
				{
					if(item is Combo) RoundRegister.RecieptPrinter.PrintLine(s);
					else RoundRegister.RecieptPrinter.PrintLine("*" + s);
				}
			}

			// Print out cost of order
			RoundRegister.RecieptPrinter.PrintLine("Subtotal: $" + order.Subtotal);
			RoundRegister.RecieptPrinter.PrintLine("Tax: $" + order.Tax);
			RoundRegister.RecieptPrinter.PrintLine("Total: $" + order.Total);

			// Print out payment type
			RoundRegister.RecieptPrinter.PrintLine("Payment type: Card");

			RoundRegister.RecieptPrinter.CutTape();
		}

		/// <summary>
		/// Constructor that creates a receipt for the given order if paid in cash
		/// </summary>
		/// <param name="order">the order to print a receipt for</param>
		public ReceiptMaker(Order order, double changeOwed)
		{
			// Print out order number
			RoundRegister.RecieptPrinter.PrintLine("Order #" + order.Number);

			// Print out the date and time
			RoundRegister.RecieptPrinter.PrintLine(DateTime.Now.ToString(new CultureInfo("en-US")));

			// Print out every item in the order and its special instructions
			foreach (IOrderItem item in order)
			{
				if (!(item is Combo)) RoundRegister.RecieptPrinter.PrintLine(item.ToString());
				foreach (string s in item.SpecialInstructions)
				{
					if (item is Combo) RoundRegister.RecieptPrinter.PrintLine(s);
					else RoundRegister.RecieptPrinter.PrintLine("*" + s);
				}
			}

			// Print out cost of order
			RoundRegister.RecieptPrinter.PrintLine("Subtotal: $" + order.Subtotal);
			RoundRegister.RecieptPrinter.PrintLine("Tax: $" + order.Tax);
			RoundRegister.RecieptPrinter.PrintLine("Total: $" + order.Total);

			// Print out payment type
			RoundRegister.RecieptPrinter.PrintLine("Payment type: Cash");

			// Print out amount
			RoundRegister.RecieptPrinter.PrintLine("Change Owed: $" + changeOwed);

			RoundRegister.RecieptPrinter.CutTape();
		}
	}
}
