/*
 * Author: Samuel McGowan
 * Class: CashRegisterTests.cs
 * Purpose: Test the CashRegisterModelView.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;
using PointOfSale;

namespace BleakwindBuffet.DataTests.UnitTests
{
	public class CashRegisterTests
	{
        Order order = new Order();

        [Fact]
        public void GetsCorrectTotal()
        {
            order.Add(new BriarheartBurger());
            CashRegisterModelView cr = new CashRegisterModelView(order);
            Assert.Equal(order.Total, cr.Total);
        }

        [Fact]
        public void GetsCorrectAmountDue()
        {
            order.Add(new BriarheartBurger());
            CashRegisterModelView cr = new CashRegisterModelView(order);
            Assert.Equal(order.Total, cr.AmountDue);
            cr.FivesFromCustomer = 1;
            double amountDue = cr.AmountDue;
            Assert.Equal(order.Total - 5, amountDue);
            cr.HundredsFromCustomer = 1;
            amountDue = cr.AmountDue;
            Assert.Equal(0, amountDue);
        }

        [Fact]
        public void GetsCorrectChangeDue()
        {
            order.Add(new BriarheartBurger());
            CashRegisterModelView cr = new CashRegisterModelView(order);
            Assert.Equal(0, cr.ChangeDue);
            cr.TensFromCustomer = 1;
            double changeDue = cr.ChangeDue;
            Assert.Equal(10-order.Total, changeDue);
        }

        [Fact]
        public void FindCorrectChangeGivenWhatIsInTheDrawer()
        {
            order.Add(new WarriorWater());
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();
            cr.FiftiesInDrawer = 2;
            cr.MakeChange(100);
            Assert.Equal(2, cr.FiftiesAsChange);
        }

        [Fact]
        public void ChangingHundredsNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "HundredsInDrawer", () =>
            {
                cr.HundredsInDrawer++;
            });

            Assert.PropertyChanged(cr, "HundredsFromCustomer", () =>
            {
                cr.HundredsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.HundredsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.HundredsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "HundredsAsChange", () =>
            {
                cr.HundredsAsChange++;
            });
        }

        [Fact]
        public void ChangingFiftiesNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "FiftiesInDrawer", () =>
            {
                cr.FiftiesInDrawer++;
            });

            Assert.PropertyChanged(cr, "FiftiesFromCustomer", () =>
            {
                cr.FiftiesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.FiftiesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.FiftiesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "FiftiesAsChange", () =>
            {
                cr.FiftiesAsChange++;
            });
        }

        [Fact]
        public void ChangingTwentiesNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "TwentiesInDrawer", () =>
            {
                cr.TwentiesInDrawer++;
            });

            Assert.PropertyChanged(cr, "TwentiesFromCustomer", () =>
            {
                cr.TwentiesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.TwentiesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.TwentiesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "TwentiesAsChange", () =>
            {
                cr.TwentiesAsChange++;
            });
        }

        [Fact]
        public void ChangingTensNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "TensInDrawer", () =>
            {
                cr.TensInDrawer++;
            });

            Assert.PropertyChanged(cr, "TensFromCustomer", () =>
            {
                cr.TensFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.TensFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.TensFromCustomer++;
            });

            Assert.PropertyChanged(cr, "TensAsChange", () =>
            {
                cr.TensAsChange++;
            });
        }

        [Fact]
        public void ChangingFivesNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "FivesInDrawer", () =>
            {
                cr.FivesInDrawer++;
            });

            Assert.PropertyChanged(cr, "FivesFromCustomer", () =>
            {
                cr.FivesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.FivesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.FivesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "FivesAsChange", () =>
            {
                cr.FivesAsChange++;
            });
        }

        [Fact]
        public void ChangingTwosNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "TwosInDrawer", () =>
            {
                cr.TwosInDrawer++;
            });

            Assert.PropertyChanged(cr, "TwosFromCustomer", () =>
            {
                cr.TwosFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.TwosFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.TwosFromCustomer++;
            });

            Assert.PropertyChanged(cr, "TwosAsChange", () =>
            {
                cr.TwosAsChange++;
            });
        }

        [Fact]
        public void ChangingOnesNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "OnesInDrawer", () =>
            {
                cr.OnesInDrawer++;
            });

            Assert.PropertyChanged(cr, "OnesFromCustomer", () =>
            {
                cr.OnesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.OnesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.OnesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "OnesAsChange", () =>
            {
                cr.OnesAsChange++;
            });
        }

        [Fact]
        public void ChangingDollarCoinsNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "DollarCoinsInDrawer", () =>
            {
                cr.DollarCoinsInDrawer++;
            });

            Assert.PropertyChanged(cr, "DollarCoinsFromCustomer", () =>
            {
                cr.DollarCoinsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.DollarCoinsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.DollarCoinsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "DollarCoinsAsChange", () =>
            {
                cr.DollarCoinsAsChange++;
            });
        }

        [Fact]
        public void ChangingHalfDollarCoinsNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "HalfDollarCoinsInDrawer", () =>
            {
                cr.HalfDollarCoinsInDrawer++;
            });

            Assert.PropertyChanged(cr, "HalfDollarCoinsFromCustomer", () =>
            {
                cr.HalfDollarCoinsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.HalfDollarCoinsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.HalfDollarCoinsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "HalfDollarCoinsAsChange", () =>
            {
                cr.HalfDollarCoinsAsChange++;
            });
        }

        [Fact]
        public void ChangingQuartersNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "QuartersInDrawer", () =>
            {
                cr.QuartersInDrawer++;
            });

            Assert.PropertyChanged(cr, "QuartersFromCustomer", () =>
            {
                cr.QuartersFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.QuartersFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.QuartersFromCustomer++;
            });

            Assert.PropertyChanged(cr, "QuartersAsChange", () =>
            {
                cr.QuartersAsChange++;
            });
        }

        [Fact]
        public void ChangingDimesNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "DimesInDrawer", () =>
            {
                cr.DimesInDrawer++;
            });

            Assert.PropertyChanged(cr, "DimesFromCustomer", () =>
            {
                cr.DimesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.DimesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.DimesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "DimesAsChange", () =>
            {
                cr.DimesAsChange++;
            });
        }

        [Fact]
        public void ChangingNickelsNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "NickelsInDrawer", () =>
            {
                cr.NickelsInDrawer++;
            });

            Assert.PropertyChanged(cr, "NickelsFromCustomer", () =>
            {
                cr.NickelsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.NickelsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.NickelsFromCustomer++;
            });

            Assert.PropertyChanged(cr, "NickelsAsChange", () =>
            {
                cr.NickelsAsChange++;
            });
        }

        [Fact]
        public void ChangingPenniesNotifiesSpecialInstructionsProperty()
        {
            CashRegisterModelView cr = new CashRegisterModelView(order);
            RoundRegister.CashDrawer.ResetDrawer();

            Assert.PropertyChanged(cr, "PenniesInDrawer", () =>
            {
                cr.PenniesInDrawer++;
            });

            Assert.PropertyChanged(cr, "PenniesFromCustomer", () =>
            {
                cr.PenniesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "AmountDue", () =>
            {
                cr.PenniesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "ChangeDue", () =>
            {
                cr.PenniesFromCustomer++;
            });

            Assert.PropertyChanged(cr, "PenniesAsChange", () =>
            {
                cr.PenniesAsChange++;
            });
        }
    }
}
