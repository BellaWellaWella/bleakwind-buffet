/*
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
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
        
        //int totalPrice = 0;
        /// <summary>
        /// The ancestor we can utilize to switch screens
        /// </summary>
        public Controller Ancestor { get; set; }

        //public static Screen currentScreen;


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
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            { 
                BriarheartBurger bb = new BriarheartBurger();
                currentOrder.Add(bb);
                var screen = Ancestor.SwitchScreen(Screen.BriarheartBurger);
                screen.DataContext = bb;
            }
            
        }

        /// <summary>
        /// what happens on click for the warrior water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WarriorWaterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                WarriorWater ww = new WarriorWater();
                currentOrder.Add(ww);
                var screen = Ancestor.SwitchScreen(Screen.WarriorWater);
                screen.DataContext = ww;
            }


        }

        /// <summary>
        /// what happens on click for the sailors soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SailorsSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                SailorSoda ss = new SailorSoda();
                currentOrder.Add(ss);
                var screen = Ancestor.SwitchScreen(Screen.SailorsSoda);
                screen.DataContext = ss;
            }

        }

        /// <summary>
        /// what happens on click for the markarth milk button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MarkarthMilkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                MarkarthMilk mm = new MarkarthMilk();
                currentOrder.Add(mm);
                var screen = Ancestor.SwitchScreen(Screen.MarkarthMilk);
                screen.DataContext = mm;
            }

        }

        /// <summary>
        /// what happens on click for the candlehearth coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CandlehearthCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                CandlehearthCoffee cc = new CandlehearthCoffee();
                currentOrder.Add(cc);
                var screen = Ancestor.SwitchScreen(Screen.CandlehearthCoffee);
                screen.DataContext = cc;
            }
        }

        /// <summary>
        /// what happens on click for the aretino apple juice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AretinoAppleJuiceButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                AretinoAppleJuice aa = new AretinoAppleJuice();
                currentOrder.Add(aa);
                var screen = Ancestor.SwitchScreen(Screen.AretinoAppleJuice);
                screen.DataContext = aa;
            }

        }

        /// <summary>
        /// what happens on click for the dragonborn waffle fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DragonbornWaffleFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                DragonbornWaffleFries dw = new DragonbornWaffleFries();
                currentOrder.Add(dw);
                var screen = Ancestor.SwitchScreen(Screen.DragonbornWaffleFries);
                screen.DataContext = dw;
            };
        }

        /// <summary>
        /// what happens on click for the fried mirrak button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FriedMirrakButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                FriedMiraak fm = new FriedMiraak();
                currentOrder.Add(fm);
                var screen = Ancestor.SwitchScreen(Screen.FriedMiraak);
                screen.DataContext = fm;
            }
        }

        /// <summary>
        /// what happens on click for the mad otar grits button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MadOtarGritsButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                MadOtarGrits mo = new MadOtarGrits();
                currentOrder.Add(mo);
                var screen = Ancestor.SwitchScreen(Screen.MadOtarGrits);
                screen.DataContext = mo;
            }
        }

        /// <summary>
        /// what happens on click for the vokun salad button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VokunSaladButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                VokunSalad vs = new VokunSalad();
                currentOrder.Add(vs);
                var screen = Ancestor.SwitchScreen(Screen.VokunSalad);
                screen.DataContext = vs;
            }
        }

        /// <summary>
        /// what happens on click for the double draugr button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoubleDraugrButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                DoubleDraugr dd = new DoubleDraugr();
                currentOrder.Add(dd);
                var screen = Ancestor.SwitchScreen(Screen.DoubleDraugr);
                screen.DataContext = dd;
            }
        }

        /// <summary>
        /// what happens on click for the thalmor triple button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThalmorTripleButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                ThalmorTriple tt = new ThalmorTriple();
                currentOrder.Add(tt);
                var screen = Ancestor.SwitchScreen(Screen.ThalmorTriple);
                screen.DataContext = tt;
            }
        }

        /// <summary>
        /// what happens on click for the garden orc omelette button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GardenOrcOmeletteButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                GardenOrcOmelette go = new GardenOrcOmelette();
                currentOrder.Add(go);
                var screen = Ancestor.SwitchScreen(Screen.GardenOrcOmelette);
                screen.DataContext = go;
            }
        }

        /// <summary>
        /// what happens on click for the philly poacher button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhillyPoacherButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                PhillyPoacher pp = new PhillyPoacher();
                currentOrder.Add(pp);
                var screen = Ancestor.SwitchScreen(Screen.PhillyPoacher);
                screen.DataContext = pp;
            }
        }

        /// <summary>
        /// what happens on click for the smokehouse skeleton button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmokehouseSkeletonButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                SmokehouseSkeleton ss = new SmokehouseSkeleton();
                currentOrder.Add(ss);
                var screen = Ancestor.SwitchScreen(Screen.SmokehouseSkeleton);
                screen.DataContext = ss;
            }
        }

        /// <summary>
        /// what happens on click for the thugs t bone button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThugsTBoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is BleakwindBuffet.Data.Order currentOrder)
            {
                ThugsTBone tt = new ThugsTBone();
                currentOrder.Add(tt);
                var screen = Ancestor.SwitchScreen(Screen.ThugsTBone);
                screen.DataContext = tt;
            }

        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Ancestor.DataContext = new BleakwindBuffet.Data.Order();   
        }
    }
}
