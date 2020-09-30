/*
 * 
 * Author: Bella Goddard
 * Class: SailorsSoda.xaml.cs
 * 
 * The purpose of this class is to provide the back code for the sailors soda choices screen
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
    /// Interaction logic for SailorsSoda.xaml
    /// </summary>
    public partial class SailorsSoda : UserControl
    {
        Controller Ancestor;

        /// <summary>
        /// the constructor for ItemCustom
        /// </summary>
        /// <param name="ancestor"> the ancestor to pass in</param>
        public SailorsSoda(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;
        }
        /*
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox1_Checked(object sender, RoutedEventArgs e)
        {

        }
        */
        /// <summary>
        /// Button to add item to order and go back to main screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToOrderButton_Click_1(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MenuChooser);
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
