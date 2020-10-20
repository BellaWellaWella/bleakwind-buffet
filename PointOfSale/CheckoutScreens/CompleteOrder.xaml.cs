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
using RoundRegister;
using System.Globalization;
using BleakwindBuffet.Data;

namespace PointOfSale.CheckoutScreens
{
    /// <summary>
    /// Interaction logic for CompleteOrder.xaml
    /// </summary>
    public partial class CompleteOrder : UserControl
    {
        Controller Ancestor;

        // 1 = cash, 2 = card
        int typeOfPayment = 0;

        public CompleteOrder(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;
        }

        /// <summary>
        /// Button to go back to main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MenuChooser);
        }

        private void CashButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.CashPayment);
            typeOfPayment = 1;

        }

        private void CardButton_Click(object sender, RoutedEventArgs e)
        {
            typeOfPayment = 2;
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                CardTransactionResult r = CardReader.RunCard(currentOrder.Total);
                if (r == CardTransactionResult.Approved)
                {
                    TextBox1.Text = "Card Approved";

                    PrintReciept();

                    //Restarts order
                    Ancestor.DataContext = new BleakwindBuffet.Data.Order();
                }
                else if (r == CardTransactionResult.Declined)
                {
                    TextBox1.Text = "Card Declined";
                }
                else if (r == CardTransactionResult.IncorrectPin)
                {
                    TextBox1.Text = "Incorrect Pin";
                }
                else if (r == CardTransactionResult.InsufficientFunds)
                {
                    TextBox1.Text = "InsufficientFunds";
                }
                else if (r == CardTransactionResult.ReadError)
                {
                    TextBox1.Text = "Read Error";
                }

            }
        }

        public void PrintReciept()
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                RecieptPrinter.PrintLine("Thank You For Dining At Bleakwind Buffet");
                RecieptPrinter.PrintLine("");
                RecieptPrinter.PrintLine("Order Number: " + currentOrder.Number);
                RecieptPrinter.PrintLine(DateTime.Now.ToString());
                RecieptPrinter.PrintLine("");

                foreach (IOrderItem item in currentOrder)
                {
                    RecieptPrinter.PrintLine(item.ToString() + " - " + item.Price.ToString());
                    foreach(string t in item.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("  " + t);
                    }
                }
                RecieptPrinter.PrintLine("");
                RecieptPrinter.PrintLine("Subtotal: " + currentOrder.Subtotal.ToString("C"));
                RecieptPrinter.PrintLine("Tax: " + currentOrder.Tax.ToString("C"));
                RecieptPrinter.PrintLine("Total: " + currentOrder.Total.ToString("C"));
                RecieptPrinter.PrintLine("");

                if (typeOfPayment == 1)
                {
                    RecieptPrinter.PrintLine("Cash Payment");
                    //ADD FUNCTIONALITY Print Change
                }
                else if(typeOfPayment == 2)
                {
                    RecieptPrinter.PrintLine("Card Payment");
                }

                RecieptPrinter.CutTape();
            }

            
        }
    }
}

