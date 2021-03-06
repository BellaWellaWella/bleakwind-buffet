﻿/*
 * 
 * Author: Bella Goddard
 * Class: ItemCustom.xaml.cs
 * 
 * The purpose of this class is to provide the back code for the item customization screen
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ItemCustom.xaml
    /// </summary>
    public partial class ItemCustom : UserControl
    {
        Controller Ancestor;

        /// <summary>
        /// the constructor for ItemCustom
        /// </summary>
        /// <param name="ancestor"> the ancestor to pass in</param>
        public ItemCustom(Controller ancestor)
        {
            InitializeComponent();
            this.Ancestor = ancestor;
        }

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

