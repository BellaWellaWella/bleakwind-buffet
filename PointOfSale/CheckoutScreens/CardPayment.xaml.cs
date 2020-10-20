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

namespace PointOfSale.CheckoutScreens
{
    /// <summary>
    /// Interaction logic for CardPayment.xaml
    /// </summary>
    public partial class CardPayment : UserControl
    {
        Controller Ancestor;

        /// <summary>
        /// Constructor for card payment user control
        /// </summary>
        /// <param name="ancestor"></param>
        public CardPayment(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;

            //ignore this class, changed ideas

            
        }

    }
}
