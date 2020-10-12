/*
 * 
 * Author: Bella Goddard
 * Class: Order.xaml.cs
 * 
 * The purpose of this class is to provide the back code for the order choices screen
 * 
 * 
 * 
*/
using BleakwindBuffet.Data;
using PointOfSale.EntreeCustom;
using PointOfSale.SideCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for Order.xaml
    /// </summary>
    public partial class Order : UserControl
    {
        public Order()
        {
            InitializeComponent();
            
        }
        
        /// <summary>
        /// Code-behind for the remove function from the button. You have to select the item, and then hit remove for it to remove
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            { 
                currentOrder.Remove((IOrderItem) orderList.SelectedItem);
                
            }
        }
        
    }
}
