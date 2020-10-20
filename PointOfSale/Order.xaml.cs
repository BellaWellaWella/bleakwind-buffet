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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
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
        public Controller Ancestor { get; set; }

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

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                if(orderList.SelectedItem is Entree)
                {
                    if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.BriarheartBurger)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.BriarheartBurger);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.DoubleDraugr)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.DoubleDraugr);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.GardenOrcOmelette)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.GardenOrcOmelette);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.PhillyPoacher)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.PhillyPoacher);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.SmokehouseSkeleton)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.SmokehouseSkeleton);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.ThalmorTriple)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.ThalmorTriple);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Entrees.ThugsTBone)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.ThugsTBone);
                        screen.DataContext = orderList.SelectedItem;
                    }
                }
                else if (orderList.SelectedItem is Drink)
                {
                    if (orderList.SelectedItem is BleakwindBuffet.Data.Drinks.AretinoAppleJuice)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.AretinoAppleJuice);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Drinks.CandlehearthCoffee)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.CandlehearthCoffee);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Drinks.MarkarthMilk)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.MarkarthMilk);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Drinks.SailorSoda)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.SailorsSoda);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Drinks.WarriorWater)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.WarriorWater);
                        screen.DataContext = orderList.SelectedItem;
                    }
                }
                else
                {
                    if (orderList.SelectedItem is BleakwindBuffet.Data.Sides.DragonbornWaffleFries)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.DragonbornWaffleFries);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Sides.FriedMiraak)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.FriedMiraak);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Sides.MadOtarGrits)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.MadOtarGrits);
                        screen.DataContext = orderList.SelectedItem;
                    }
                    else if (orderList.SelectedItem is BleakwindBuffet.Data.Sides.VokunSalad)
                    {
                        var screen = Ancestor.SwitchScreen(Screen.VokunSalad);
                        screen.DataContext = orderList.SelectedItem;
                    }
                }
            
            }
            
        }
    }
}
