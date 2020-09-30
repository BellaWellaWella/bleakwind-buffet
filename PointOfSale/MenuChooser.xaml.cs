﻿/*
 * 
 * Author: Bella Goddard
 * Class: MenuChooser.xaml.cs
 * 
 * The purpose of this class is to provide the back code for the main menu choices screen
 * 
 * 
 * 
*/
using BleakwindBuffet.Data;
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
    /// Interaction logic for MenuChooser.xaml
    /// </summary>
    public partial class MenuChooser : UserControl
    {
        List<IOrderItem> currentOrder = new List<IOrderItem>();
        int totalPrice = 0;
        /// <summary>
        /// The ancestor we can utilize to switch screens
        /// </summary>
        public Controller Ancestor { get; set; }

        /// <summary>
        /// menu chooser constructor
        /// </summary>
        public MenuChooser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// what happens on click for the briarheart burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BriarheartBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.BriarheartBurger);
        }

        /// <summary>
        /// what happens on click for the warrior water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.WarriorWater);

        }

        /// <summary>
        /// what happens on click for the sailors soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SailorsSodaButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.SailorsSoda);
        }

        /// <summary>
        /// what happens on click for the markarth milk button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MarkarthMilk);

        }

        /// <summary>
        /// what happens on click for the candlehearth coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.CandlehearthCoffee);
        }

        /// <summary>
        /// what happens on click for the aretino apple juice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.AretinoAppleJuice);

        }

        /// <summary>
        /// what happens on click for the dragonborn waffle fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.DragonbornWaffleFries);
        }

        /// <summary>
        /// what happens on click for the fried mirrak button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriedMirrakButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.FriedMiraak);
        }

        /// <summary>
        /// what happens on click for the mad otar grits button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.MadOtarGrits);
        }

        /// <summary>
        /// what happens on click for the vokun salad button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.VokunSalad);
        }

        /// <summary>
        /// what happens on click for the double draugr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.DoubleDraugr);
        }

        /// <summary>
        /// what happens on click for the thalmor triple button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.ThalmorTriple);
        }

        /// <summary>
        /// what happens on click for the garden orc omelette button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.GardenOrcOmelette);
        }

        /// <summary>
        /// what happens on click for the philly poacher button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhillyPoacherButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.PhillyPoacher);
        }

        /// <summary>
        /// what happens on click for the smokehouse skeleton button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.SmokehouseSkeleton);
        }

        /// <summary>
        /// what happens on click for the thugs t bone button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.SwitchScreen(Screen.ThugsTBone);
        }
    }
}
