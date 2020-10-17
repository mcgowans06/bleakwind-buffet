/*
* Author: Samuel McGowan
* Class name: CashRegisterModelView.cs
* Purpose: The model view class for the cash register
* Last Modified: 10/16/20
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data;

namespace PointOfSale
{
	/// <summary>
	/// The model view class for the cash register
	/// </summary>
	public class CashRegisterModelView : INotifyPropertyChanged
	{
		/// <summary>
		/// Event handler that handles when a property changes
		/// </summary>
		public event PropertyChangedEventHandler PropertyChanged;

		public CashRegisterModelView(Order order)
		{
			Total = order.Total;
			this.order = order;
		}

		private Order order;
		public Order Order => order;

		/// <summary>
		/// Property for the amount due
		/// </summary>
		public double AmountDue
		{
			get
			{
				double moneyReceived = 0;
				moneyReceived += HundredsFromCustomer * 100;
				moneyReceived += FiftiesFromCustomer * 50;
				moneyReceived += TwentiesFromCustomer * 20;
				moneyReceived += TensFromCustomer * 10;
				moneyReceived += FivesFromCustomer * 5;
				moneyReceived += TwosFromCustomer * 2;
				moneyReceived += OnesFromCustomer * 1;
				moneyReceived += DollarCoinsFromCustomer * 1;
				moneyReceived += HalfDollarCoinsFromCustomer * .5;
				moneyReceived += QuartersFromCustomer * .25;
				moneyReceived += DimesFromCustomer * .1;
				moneyReceived += NickelsFromCustomer * .05;
				moneyReceived += PenniesFromCustomer * .01;
				if (Total - moneyReceived >= 0) return (Math.Round(Total - moneyReceived, 2));
				else return (0);
			}
		}

		/// <summary>
		/// Property for the change due
		/// </summary>
		public double ChangeDue
		{
			get
			{
				double moneyReceived = 0;
				moneyReceived += HundredsFromCustomer * 100;
				moneyReceived += FiftiesFromCustomer * 50;
				moneyReceived += TwentiesFromCustomer * 20;
				moneyReceived += TensFromCustomer * 10;
				moneyReceived += FivesFromCustomer * 5;
				moneyReceived += TwosFromCustomer * 2;
				moneyReceived += OnesFromCustomer * 1;
				moneyReceived += DollarCoinsFromCustomer * 1;
				moneyReceived += HalfDollarCoinsFromCustomer * .5;
				moneyReceived += QuartersFromCustomer * .25;
				moneyReceived += DimesFromCustomer * .1;
				moneyReceived += NickelsFromCustomer * .05;
				moneyReceived += PenniesFromCustomer * .01;
				if (moneyReceived > Total)
				{
					double change = Math.Round(moneyReceived - Total, 2);
					MakeChange(change);
					return (change);
				}
				else
				{
					MakeChange(0);
					return 0;
				}
			}
		}

		double total = 0;
		/// <summary>
		/// Property for the total amount of the order
		/// </summary>
		public double Total
		{
			get { return (total); }
			set
			{
				if(value != total)
				{
					total = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
				}
			}
		}

		/// <summary>
		/// The amount of hundred dollar bills in the drawer
		/// </summary>
		public int HundredsInDrawer 
		{
			get { return (RoundRegister.CashDrawer.Hundreds); }
			set
			{
				if(value != RoundRegister.CashDrawer.Hundreds)
				{
					RoundRegister.CashDrawer.Hundreds = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of fifties dollar bills in the drawer
		/// </summary>
		public int FiftiesInDrawer
		{
			get { return (RoundRegister.CashDrawer.Fifties); }
			set
			{
				if (value != RoundRegister.CashDrawer.Fifties)
				{
					RoundRegister.CashDrawer.Fifties = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of twenties dollar bills in the drawer
		/// </summary>
		public int TwentiesInDrawer
		{
			get { return (RoundRegister.CashDrawer.Twenties); }
			set
			{
				if (value != RoundRegister.CashDrawer.Twenties)
				{
					RoundRegister.CashDrawer.Twenties = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of tens dollar bills in the drawer
		/// </summary>
		public int TensInDrawer
		{
			get { return (RoundRegister.CashDrawer.Tens); }
			set
			{
				if (value != RoundRegister.CashDrawer.Tens)
				{
					RoundRegister.CashDrawer.Tens = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of fives dollar bills in the drawer
		/// </summary>
		public int FivesInDrawer
		{
			get { return (RoundRegister.CashDrawer.Fives); }
			set
			{
				if (value != RoundRegister.CashDrawer.Fives)
				{
					RoundRegister.CashDrawer.Fives = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of fives dollar bills in the drawer
		/// </summary>
		public int TwosInDrawer
		{
			get { return (RoundRegister.CashDrawer.Twos); }
			set
			{
				if (value != RoundRegister.CashDrawer.Twos)
				{
					RoundRegister.CashDrawer.Twos = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of ones dollar bills in the drawer
		/// </summary>
		public int OnesInDrawer
		{
			get { return (RoundRegister.CashDrawer.Ones); }
			set
			{
				if (value != RoundRegister.CashDrawer.Ones)
				{
					RoundRegister.CashDrawer.Ones = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of dollar coins in the drawer
		/// </summary>
		public int DollarCoinsInDrawer
		{
			get { return (RoundRegister.CashDrawer.Dollars); }
			set
			{
				if (value != RoundRegister.CashDrawer.Dollars)
				{
					RoundRegister.CashDrawer.Dollars = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of half dollar coins in the drawer
		/// </summary>
		public int HalfDollarCoinsInDrawer
		{
			get { return (RoundRegister.CashDrawer.HalfDollars); }
			set
			{
				if (value != RoundRegister.CashDrawer.HalfDollars)
				{
					RoundRegister.CashDrawer.HalfDollars = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinsInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of quarters in the drawer
		/// </summary>
		public int QuartersInDrawer
		{
			get { return (RoundRegister.CashDrawer.Quarters); }
			set
			{
				if (value != RoundRegister.CashDrawer.Quarters)
				{
					RoundRegister.CashDrawer.Quarters = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of dimes in the drawer
		/// </summary>
		public int DimesInDrawer
		{
			get { return (RoundRegister.CashDrawer.Dimes); }
			set
			{
				if (value != RoundRegister.CashDrawer.Dimes)
				{
					RoundRegister.CashDrawer.Dimes = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of nickels in the drawer
		/// </summary>
		public int NickelsInDrawer
		{
			get { return (RoundRegister.CashDrawer.Nickels); }
			set
			{
				if (value != RoundRegister.CashDrawer.Nickels)
				{
					RoundRegister.CashDrawer.Nickels = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsInDrawer"));
				}
			}
		}

		/// <summary>
		/// The amount of pennies in the drawer
		/// </summary>
		public int PenniesInDrawer
		{
			get { return (RoundRegister.CashDrawer.Pennies); }
			set
			{
				if (value != RoundRegister.CashDrawer.Pennies)
				{
					RoundRegister.CashDrawer.Pennies = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesInDrawer"));
				}
			}
		}

		int hundredsFromCustomer = 0;
		/// <summary>
		/// The amount of hundred dollar bills from the customer
		/// </summary>
		public int HundredsFromCustomer
		{
			get { return (hundredsFromCustomer); }
			set
			{
				if(value != hundredsFromCustomer)
				{
					hundredsFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsFromCustomer"));
				}
			}
		}

		int fiftiesFromCustomer = 0;
		/// <summary>
		/// The amount of fifty dollar bills from the customer
		/// </summary>
		public int FiftiesFromCustomer
		{
			get { return (fiftiesFromCustomer); }
			set
			{
				if (value != fiftiesFromCustomer)
				{
					fiftiesFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesFromCustomer"));
					
				}
			}
		}

		int twentiesFromCustomer = 0;
		/// <summary>
		/// The amount of twenty dollar bills from the customer
		/// </summary>
		public int TwentiesFromCustomer
		{
			get { return (twentiesFromCustomer); }
			set
			{
				if (value != twentiesFromCustomer)
				{
					twentiesFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesFromCustomer"));
					
				}
			}
		}

		int tensFromCustomer = 0;
		/// <summary>
		/// The amount of ten dollar bills from the customer
		/// </summary>
		public int TensFromCustomer
		{
			get { return (tensFromCustomer); }
			set
			{
				if (value != tensFromCustomer)
				{
					tensFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensFromCustomer"));
					
				}
			}
		}

		int fivesFromCustomer = 0;
		/// <summary>
		/// The amount of five dollar bills from the customer
		/// </summary>
		public int FivesFromCustomer
		{
			get { return (fivesFromCustomer); }
			set
			{
				if (value != fivesFromCustomer)
				{
					fivesFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesFromCustomer"));
					
				}
			}
		}

		int twosFromCustomer = 0;
		/// <summary>
		/// The amount of five dollar bills from the customer
		/// </summary>
		public int TwosFromCustomer
		{
			get { return (twosFromCustomer); }
			set
			{
				if (value != twosFromCustomer)
				{
					twosFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosFromCustomer"));

				}
			}
		}

		int onesFromCustomer = 0;
		/// <summary>
		/// The amount of one dollar bills from the customer
		/// </summary>
		public int OnesFromCustomer
		{
			get { return (onesFromCustomer); }
			set
			{
				if (value != onesFromCustomer)
				{
					onesFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesFromCustomer"));
					
				}
			}
		}

		int dollarCoinsFromCustomer = 0;
		/// <summary>
		/// The amount of one dollar coins from the customer
		/// </summary>
		public int DollarCoinsFromCustomer
		{
			get { return (dollarCoinsFromCustomer); }
			set
			{
				if (value != dollarCoinsFromCustomer)
				{
					dollarCoinsFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsFromCustomer"));
					
				}
			}
		}

		int halfDollarCoinsFromCustomer = 0;
		/// <summary>
		/// The amount of half dollar coins from the customer
		/// </summary>
		public int HalfDollarCoinsFromCustomer
		{
			get { return (halfDollarCoinsFromCustomer); }
			set
			{
				if (value != halfDollarCoinsFromCustomer)
				{
					halfDollarCoinsFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinsFromCustomer"));
					
				}
			}
		}

		int quartersFromCustomer = 0;
		/// <summary>
		/// The amount of quarters from the customer
		/// </summary>
		public int QuartersFromCustomer
		{
			get { return (quartersFromCustomer); }
			set
			{
				if (value != quartersFromCustomer)
				{
					quartersFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersFromCustomer"));
					
				}
			}
		}

		int dimesFromCustomer = 0;
		/// <summary>
		/// The amount of dimes from the customer
		/// </summary>
		public int DimesFromCustomer
		{
			get { return (dimesFromCustomer); }
			set
			{
				if (value != dimesFromCustomer)
				{
					dimesFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesFromCustomer"));
				}
			}
		}

		int nickelsFromCustomer = 0;
		/// <summary>
		/// The amount of nickels from the customer
		/// </summary>
		public int NickelsFromCustomer
		{
			get { return (nickelsFromCustomer); }
			set
			{
				if (value != nickelsFromCustomer)
				{
					nickelsFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsFromCustomer"));
				}
			}
		}

		int penniesFromCustomer = 0;
		/// <summary>
		/// The amount of pennies from the customer
		/// </summary>
		public int PenniesFromCustomer
		{
			get { return (penniesFromCustomer); }
			set
			{
				if (value != penniesFromCustomer)
				{
					penniesFromCustomer = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDue"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesFromCustomer"));
				}
			}
		}

		int hundredsAsChange = 0;
		/// <summary>
		/// The amount of hundred dollar bills as change to give back
		/// </summary>
		public int HundredsAsChange
		{
			get { return (hundredsAsChange); }
			set
			{
				if (value != hundredsAsChange)
				{
					hundredsAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsAsChange"));
				}
			}
		}

		int fiftiesAsChange = 0;
		/// <summary>
		/// The amount of fifty dollar bills as change to give back
		/// </summary>
		public int FiftiesAsChange
		{
			get { return (fiftiesAsChange); }
			set
			{
				if (value != fiftiesAsChange)
				{
					fiftiesAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesAsChange"));
				}
			}
		}

		int twentiesAsChange = 0;
		/// <summary>
		/// The amount of twenty dollar bills as change to give back
		/// </summary>
		public int TwentiesAsChange
		{
			get { return (twentiesAsChange); }
			set
			{
				if (value != twentiesAsChange)
				{
					twentiesAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesAsChange"));
				}
			}
		}

		int tensAsChange = 0;
		/// <summary>
		/// The amount of ten dollar bills as change to give back
		/// </summary>
		public int TensAsChange
		{
			get { return (tensAsChange); }
			set
			{
				if (value != tensAsChange)
				{
					tensAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensAsChange"));
				}
			}
		}

		int fivesAsChange = 0;
		/// <summary>
		/// The amount of five dollar bills as change to give back
		/// </summary>
		public int FivesAsChange
		{
			get { return (fivesAsChange); }
			set
			{
				if (value != fivesAsChange)
				{
					fivesAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesAsChange"));
				}
			}
		}

		int twosAsChange = 0;
		/// <summary>
		/// The amount of five dollar bills as change to give back
		/// </summary>
		public int TwosAsChange
		{
			get { return (twosAsChange); }
			set
			{
				if (value != twosAsChange)
				{
					twosAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosAsChange"));
				}
			}
		}

		int onesAsChange = 0;
		/// <summary>
		/// The amount of one dollar bills as change to give back
		/// </summary>
		public int OnesAsChange
		{
			get { return (onesAsChange); }
			set
			{
				if (value != onesAsChange)
				{
					onesAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesAsChange"));
				}
			}
		}

		int dollarCoinsAsChange = 0;
		/// <summary>
		/// The amount of one dollar coins as change to give back
		/// </summary>
		public int DollarCoinsAsChange
		{
			get { return (dollarCoinsAsChange); }
			set
			{
				if (value != dollarCoinsAsChange)
				{
					dollarCoinsAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsAsChange"));
				}
			}
		}

		int halfDollarCoinsAsChange = 0;
		/// <summary>
		/// The amount of half dollar coins as change to give back
		/// </summary>
		public int HalfDollarCoinsAsChange
		{
			get { return (halfDollarCoinsAsChange); }
			set
			{
				if (value != halfDollarCoinsAsChange)
				{
					halfDollarCoinsAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinsAsChange"));
				}
			}
		}

		int quartersAsChange = 0;
		/// <summary>
		/// The amount of quarters as change to give back
		/// </summary>
		public int QuartersAsChange
		{
			get { return (quartersAsChange); }
			set
			{
				if (value != quartersAsChange)
				{
					quartersAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersAsChange"));
				}
			}
		}

		int dimesAsChange = 0;
		/// <summary>
		/// The amount of dimes as change to give back
		/// </summary>
		public int DimesAsChange
		{
			get { return (dimesAsChange); }
			set
			{
				if (value != dimesAsChange)
				{
					dimesAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesAsChange"));
				}
			}
		}

		int nickelsAsChange = 0;
		/// <summary>
		/// The amount of nickels as change to give back
		/// </summary>
		public int NickelsAsChange
		{
			get { return (nickelsAsChange); }
			set
			{
				if (value != nickelsAsChange)
				{
					nickelsAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsAsChange"));
				}
			}
		}

		int penniesAsChange = 0;
		/// <summary>
		/// The amount of pennies as change to give back
		/// </summary>
		public int PenniesAsChange
		{
			get { return (penniesAsChange); }
			set
			{
				if (value != penniesAsChange)
				{
					penniesAsChange = value;
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOwed"));
					PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesAsChange"));
				}
			}
		}

		/// <summary>
		/// Invokes CashDrawer.OpenDrawer() and adds all the money from the customer to the drawer
		/// </summary>
		public void OpenDrawer()
		{
			RoundRegister.CashDrawer.OpenDrawer();
			RoundRegister.CashDrawer.Hundreds += HundredsFromCustomer;
			RoundRegister.CashDrawer.Fifties += FiftiesFromCustomer;
			RoundRegister.CashDrawer.Twenties += TwentiesFromCustomer;
			RoundRegister.CashDrawer.Tens += TensFromCustomer;
			RoundRegister.CashDrawer.Fives += FivesFromCustomer;
			RoundRegister.CashDrawer.Ones += OnesFromCustomer;
			RoundRegister.CashDrawer.Dollars += DollarCoinsFromCustomer;
			RoundRegister.CashDrawer.HalfDollars += HalfDollarCoinsFromCustomer;
			RoundRegister.CashDrawer.Quarters += QuartersFromCustomer;
			RoundRegister.CashDrawer.Dimes += DimesFromCustomer;
			RoundRegister.CashDrawer.Nickels += NickelsFromCustomer;
			RoundRegister.CashDrawer.Pennies += PenniesFromCustomer;

			HundredsFromCustomer = 0;
			FiftiesFromCustomer = 0;
			TwentiesFromCustomer = 0;
			TensFromCustomer = 0;
			FivesFromCustomer = 0;
			OnesFromCustomer = 0;
			DollarCoinsFromCustomer = 0;
			HalfDollarCoinsFromCustomer = 0;
			QuartersFromCustomer = 0;
			DimesFromCustomer = 0;
			NickelsFromCustomer = 0;
			PenniesFromCustomer = 0;
		}

		/// <summary>
		/// Sets the "AsChange" properties according to the amount of change needed to be made
		/// </summary>
		/// <param name="amount">The amount of change needed to be made</param>
		public void MakeChange(double amount)
		{
			HundredsAsChange = 0;
			FiftiesAsChange = 0;
			TwentiesAsChange = 0;
			TensAsChange = 0;
			FivesAsChange = 0;
			TwosAsChange = 0;
			OnesAsChange = 0;
			DollarCoinsAsChange = 0;
			HalfDollarCoinsAsChange = 0;
			QuartersAsChange = 0;
			DimesAsChange = 0;
			NickelsAsChange = 0;
			PenniesAsChange = 0;

			int hundredsNeeded = (int)Math.Floor(amount / 100);
			// If the amount of twenties in the drawer is greater than the amount of twenties needed
			if (HundredsInDrawer >= hundredsNeeded)
			{
				HundredsAsChange += hundredsNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsAsChange"));
			}
			// If there are some twenties in the drawer but not enough for all the change
			else if (HundredsInDrawer > 0)
			{
				HundredsAsChange += HundredsInDrawer;
				hundredsNeeded -= HundredsAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HundredsAsChange"));
			}
			amount -= HundredsAsChange * 100;

			int fiftiesNeeded = (int)Math.Floor(amount / 50);
			// If the amount of fifties in the drawer is greater than the amount of fifties needed
			if (FiftiesInDrawer >= fiftiesNeeded)
			{
				FiftiesAsChange += fiftiesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesAsChange"));
			}
			// If there are some fifties in the drawer but not enough for all the change
			else if (FiftiesInDrawer > 0)
			{
				FiftiesAsChange += FiftiesInDrawer;
				fiftiesNeeded -= FiftiesAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FiftiesAsChange"));
			}
			amount -= FiftiesAsChange * 50;

			int twentiesNeeded = (int)Math.Floor(amount / 20);
			// If the amount of twenties in the drawer is greater than the amount of twenties needed
			if (TwentiesInDrawer >= twentiesNeeded)
			{
				TwentiesAsChange += twentiesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesAsChange"));
			}
			// If there are some twenties in the drawer but not enough for all the change
			else if (TwentiesInDrawer > 0)
			{
				TwentiesAsChange += TwentiesInDrawer;
				twentiesNeeded -= TwentiesAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwentiesAsChange"));
			}
			amount -= TwentiesAsChange * 20;

			int tensNeeded = (int)Math.Floor(amount / 10);
			// If the amount of tens in the drawer is greater than the amount of tens needed
			if (TensInDrawer >= tensNeeded)
			{
				TensAsChange += tensNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensAsChange"));
			}
			// If there are some tens in the drawer but not enough for all the change
			else if (TensInDrawer > 0)
			{
				TensAsChange += TensInDrawer;
				tensNeeded -= TensAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TensAsChange"));
			}
			amount -= TensAsChange * 10;

			int fivesNeeded = (int)Math.Floor(amount / 5);
			// If the amount of fives in the drawer is greater than the amount of fives needed
			if (FivesInDrawer >= fivesNeeded)
			{
				FivesAsChange += fivesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesAsChange"));
			}
			// If there are some fives in the drawer but not enough for all the change
			else if (FivesInDrawer > 0)
			{
				FivesAsChange += FivesInDrawer;
				fivesNeeded -= FivesAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("FivesAsChange"));
			}
			amount -= FivesAsChange * 5;

			int twosNeeded = (int)Math.Floor(amount / 2);
			// If the amount of twos in the drawer is greater than the amount of twos needed
			if (TwosInDrawer >= twosNeeded)
			{
				TwosAsChange += twosNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosAsChange"));
			}
			// If there are some twos in the drawer but not enough for all the change
			else if (TwosInDrawer > 0)
			{
				TwosAsChange += TwosInDrawer;
				twosNeeded -= TwosAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TwosAsChange"));
			}
			amount -= TwosAsChange * 2;

			int onesNeeded = (int)Math.Floor(amount / 1);
			// If the amount of ones in the drawer is greater than the amount of ones needed
			if (OnesInDrawer >= onesNeeded)
			{
				OnesAsChange += onesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesAsChange"));
			}
			// If there are some ones in the drawer but not enough for all the change
			else if (OnesInDrawer > 0)
			{
				OnesAsChange += OnesInDrawer;
				onesNeeded -= OnesAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnesAsChange"));
			}
			amount -= OnesAsChange * 1;

			// If the amount of ones in the drawer is greater than the amount of ones needed
			if (DollarCoinsInDrawer >= onesNeeded)
			{
				DollarCoinsAsChange += onesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsAsChange"));
			}
			// If there are some ones in the drawer but not enough for all the change
			else if (DollarCoinsInDrawer > 0)
			{
				DollarCoinsAsChange += DollarCoinsInDrawer;
				onesNeeded -= DollarCoinsAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DollarCoinsAsChange"));
			}
			amount -= DollarCoinsAsChange * 1;

			int halfDollarsNeeded = (int)Math.Floor(amount / .5);
			// If the amount of halfDollars in the drawer is greater than the amount of halfDollars needed
			if (HalfDollarCoinsInDrawer >= halfDollarsNeeded)
			{
				HalfDollarCoinsAsChange += halfDollarsNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinsAsChange"));
			}
			// If there are some halfDollars in the drawer but not enough for all the change
			else if (HalfDollarCoinsInDrawer > 0)
			{
				HalfDollarCoinsAsChange += HalfDollarCoinsInDrawer;
				halfDollarsNeeded -= HalfDollarCoinsAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollarCoinsAsChange"));
			}
			amount -= HalfDollarCoinsAsChange * .5;

			int quartersNeeded = (int)Math.Floor(amount / .25);
			// If the amount of quarters in the drawer is greater than the amount of quarters needed
			if (QuartersInDrawer >= quartersNeeded)
			{
				QuartersAsChange += quartersNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersAsChange"));
			}
			// If there are some quarters in the drawer but not enough for all the change
			else if (QuartersInDrawer > 0)
			{
				QuartersAsChange += QuartersInDrawer;
				quartersNeeded -= QuartersAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("QuartersAsChange"));
			}
			amount -= QuartersAsChange * .25;

			int dimesNeeded = (int)Math.Floor(amount / .1);
			// If the amount of dimes in the drawer is greater than the amount of dimes needed
			if (DimesInDrawer >= dimesNeeded)
			{
				DimesAsChange += dimesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesAsChange"));
			}
			// If there are some dimes in the drawer but not enough for all the change
			else if (DimesInDrawer > 0)
			{
				DimesAsChange += DimesInDrawer;
				dimesNeeded -= DimesAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("DimesAsChange"));
			}
			amount -= DimesAsChange * .1;

			int nickelsNeeded = (int)Math.Floor(amount / .05);
			// If the amount of nickels in the drawer is greater than the amount of nickels needed
			if (NickelsInDrawer >= nickelsNeeded)
			{
				NickelsAsChange += nickelsNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsAsChange"));
			}
			// If there are some nickels in the drawer but not enough for all the change
			else if (NickelsInDrawer > 0)
			{
				NickelsAsChange += NickelsInDrawer;
				nickelsNeeded -= NickelsAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("NickelsAsChange"));
			}
			amount -= NickelsAsChange * .05;

			int penniesNeeded = (int)Math.Floor(amount / .01);
			// If the amount of pennies in the drawer is greater than the amount of pennies needed
			if (PenniesInDrawer >= penniesNeeded)
			{
				PenniesAsChange += penniesNeeded;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesAsChange"));
			}
			// If there are some pennies in the drawer but not enough for all the change
			else if (PenniesInDrawer > 0)
			{
				PenniesAsChange += PenniesInDrawer;
				penniesNeeded -= PenniesAsChange;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("PenniesAsChange"));
			}
			amount -= PenniesAsChange * .01;
		}
	}
}
