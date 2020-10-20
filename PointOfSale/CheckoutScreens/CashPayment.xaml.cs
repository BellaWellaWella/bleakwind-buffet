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

namespace PointOfSale.CheckoutScreens
{
    /// <summary>
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        Controller Ancestor;

        /// <summary>
        /// Constructor for CashPayment user control
        /// </summary>
        /// <param name="ancestor"></param>
        public CashPayment(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;



            CurrencyControl HundredControl = new CurrencyControl() { Label = "$100"};
           // HundredControl.SetBinding(HundredControl,"ChangeHundred");
            mainGrid.Children.Add(HundredControl);
            Grid.SetRow(HundredControl, 1);
            Grid.SetColumn(HundredControl, 0);
            CurrencyControl FiftyControl = new CurrencyControl() { Label = "$50" };
            mainGrid.Children.Add(FiftyControl);
            Grid.SetRow(FiftyControl, 2);
            Grid.SetColumn(FiftyControl, 0);
            CurrencyControl TwentyControl = new CurrencyControl() { Label = "$20" };
            mainGrid.Children.Add(TwentyControl);
            Grid.SetRow(TwentyControl, 3);
            Grid.SetColumn(TwentyControl, 0);
            CurrencyControl TenControl = new CurrencyControl() { Label = "$10" };
            mainGrid.Children.Add(TenControl);
            Grid.SetRow(TenControl, 4);
            Grid.SetColumn(TenControl, 0);
            CurrencyControl FiveControl = new CurrencyControl() { Label = "$5" };
            mainGrid.Children.Add(FiveControl);
            Grid.SetRow(FiveControl, 5);
            Grid.SetColumn(FiveControl, 0);
            CurrencyControl TwoControl = new CurrencyControl() { Label = "$2" };
            mainGrid.Children.Add(TwoControl);
            Grid.SetRow(TwoControl, 6);
            Grid.SetColumn(TwoControl, 0);
            CurrencyControl OneBillControl = new CurrencyControl() { Label = "$1" };
            mainGrid.Children.Add(OneBillControl);
            Grid.SetRow(OneBillControl, 7);
            Grid.SetColumn(OneBillControl, 0);

            CurrencyControl OneCoinControl = new CurrencyControl() { Label = "100¢" };
            mainGrid.Children.Add(OneCoinControl);
            Grid.SetRow(OneCoinControl, 1);
            Grid.SetColumn(OneCoinControl, 1);
            CurrencyControl HalfDollarControl = new CurrencyControl() { Label = "50¢" };
            mainGrid.Children.Add(HalfDollarControl);
            Grid.SetRow(HalfDollarControl, 2);
            Grid.SetColumn(HalfDollarControl, 1);
            CurrencyControl QuarterControl = new CurrencyControl() { Label = "25¢" };
            mainGrid.Children.Add(QuarterControl);
            Grid.SetRow(QuarterControl, 3);
            Grid.SetColumn(QuarterControl, 1);
            CurrencyControl DimeControl = new CurrencyControl() { Label = "10¢" };
            mainGrid.Children.Add(DimeControl);
            Grid.SetRow(DimeControl, 4);
            Grid.SetColumn(DimeControl, 1);
            CurrencyControl NickelControl = new CurrencyControl() { Label = "5¢" };
            mainGrid.Children.Add(NickelControl);
            Grid.SetRow(NickelControl, 5);
            Grid.SetColumn(NickelControl, 1);
            CurrencyControl PennyControl = new CurrencyControl() { Label = "1¢" };
            mainGrid.Children.Add(PennyControl);
            Grid.SetRow(PennyControl, 6);
            Grid.SetColumn(PennyControl, 1);

        }
        

        /// <summary>
        /// Button to go back to main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.CompleteOrder);
        }

        private void CheckoutButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
