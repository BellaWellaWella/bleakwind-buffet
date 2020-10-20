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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {

        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl));
        public static DependencyProperty CustomerQuantityProperty = DependencyProperty.Register("CustomerQuantity", typeof(int), typeof(CurrencyControl));
        public static DependencyProperty ChangeQuantityProperty = DependencyProperty.Register("ChangeQuantity", typeof(int), typeof(CurrencyControl));

        /// <summary>
        /// Get & Set the Label property
        /// </summary>
        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set { SetValue(LabelProperty, value);
                KindOfMoney.Text = (string)value; }
        }

        /// <summary>
        /// Get & Set the Customer Quantity Property
        /// </summary>
        public int CustomerQuantity
        {
            get => (int)GetValue(CustomerQuantityProperty);
            set => SetValue(CustomerQuantityProperty, value);
        }

        /// <summary>
        /// Get & Set the Change Quantity Property
        /// </summary>
        public int ChangeQuantity
        {
            get => (int)GetValue(ChangeQuantityProperty);
            set => SetValue(ChangeQuantityProperty, value);
        }


        public CurrencyControl()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerQuantity++;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            CustomerQuantity--;
        }
    }
}
