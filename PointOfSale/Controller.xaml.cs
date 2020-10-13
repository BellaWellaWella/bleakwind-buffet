/*
 * 
 * Author: Bella Goddard
 * Class: Controller.xaml.cs
 * 
 * The purpose of this class is to provide the back code for the controller that is the framework for the program
 * 
 * 
 * 
*/
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using PointOfSale.DrinkCustom;
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
    /// Interaction logic for Controller.xaml
    /// </summary>
    public partial class Controller : UserControl
    {
        Dictionary<Screen, UserControl> screens = new Dictionary<Screen, UserControl>();

        /// <summary>
        /// adds screens to the list
        /// </summary>
        public Controller()
        {
            
            InitializeComponent();
            menuChooser.Ancestor = this;
            screens.Add(Screen.MenuChooser, menuChooser);
            screens.Add(Screen.ItemCustom, new ItemCustom(this));
            screens.Add(Screen.WarriorWater, new DrinkCustom.WarriorWater(this));
            screens.Add(Screen.SailorsSoda, new SailorsSoda(this));
            screens.Add(Screen.MarkarthMilk, new DrinkCustom.MarkarthMilk(this));
            screens.Add(Screen.AretinoAppleJuice, new DrinkCustom.AretinoAppleJuice(this));
            screens.Add(Screen.CandlehearthCoffee, new DrinkCustom.CandlehearthCoffee(this));
            screens.Add(Screen.DragonbornWaffleFries, new SideCustom.DragonbornWaffleFries(this));
            screens.Add(Screen.MadOtarGrits, new SideCustom.MadOtarGrits(this));
            screens.Add(Screen.FriedMiraak, new SideCustom.FriedMiraak(this));
            screens.Add(Screen.VokunSalad, new SideCustom.VokunSalad(this));
            screens.Add(Screen.BriarheartBurger, new EntreeCustom.BriarheartBurger(this));
            screens.Add(Screen.DoubleDraugr, new EntreeCustom.DoubleDraugr(this));
            screens.Add(Screen.SmokehouseSkeleton, new EntreeCustom.SmokehouseSkeleton(this));
            screens.Add(Screen.ThalmorTriple, new EntreeCustom.ThalmorTriple(this));
            screens.Add(Screen.GardenOrcOmelette, new EntreeCustom.GardenOrcOmelette(this));
            screens.Add(Screen.PhillyPoacher, new EntreeCustom.PhillyPoacher(this));
            screens.Add(Screen.ThugsTBone, new EntreeCustom.ThugsTBone(this));
            screens.Add(Screen.Combo, new Combo(this));

            //Order mainOrder = new Order();

            BleakwindBuffet.Data.Order currentOrder = new BleakwindBuffet.Data.Order();

            this.DataContext = currentOrder;
        }

        /// <summary>
        /// Switches the displayed screen
        /// </summary>
        /// <param name="screen">The identity of the screen to show</param>
        public FrameworkElement SwitchScreen(Screen screen)
        {
            switchableContent.Child = screens[screen];
            return screens[screen];
        }

        //ignore
        private void menuChoose_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            EnterButton.IsEnabled = false;
            EnterButton.Opacity = 0;
            EnterButton.Width = 0;
            EnterButton.Height = 0;
            MainScreen.Opacity = 0;
            MainScreen.IsEnabled = false;
            MainScreen.Width = 0;
            MainScreen.Height = 0;
            
        }
    }
}
