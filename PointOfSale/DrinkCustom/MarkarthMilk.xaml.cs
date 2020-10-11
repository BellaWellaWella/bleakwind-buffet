/*
 * 
 * Author: Bella Goddard
 * Class: MarkarthMilk.xaml.cs
 * 
 * The purpose of this class is to provide the back code for the Markarth milk choices screen
 * 
 * 
 * 
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

namespace PointOfSale.DrinkCustom
{
    /// <summary>
    /// Interaction logic for MarkarthMilk.xaml
    /// </summary>
    public partial class MarkarthMilk : UserControl
    {
        Controller Ancestor;

        /// <summary>
        /// the constructor for ItemCustom
        /// </summary>
        /// <param name="ancestor"> the ancestor to pass in</param>
        public MarkarthMilk(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;
            //this.DataContext = new BleakwindBuffet.Data.Drinks.MarkarthMilk();

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
    }
}

